#include "pch.h"
#include "Server.h"
#include <WS2tcpip.h>
#include <fstream>

namespace Engine
{
	Server::Server() : 
		m_isConnected(false)
	{
		
	}

	int Server::Initialize()
	{
		WSADATA wsData;
		WORD ver = MAKEWORD(2, 2);

		if (WSAStartup(ver, &wsData) != 0)
		{
			//std::cerr << "Error: starting winsock failed!" << std::endl;
			return ERR_INITIALIZE;
		}

		return 0;
	}
	
	int Server::Connect(const string& ipAddress)
	{
		if (m_isConnected)
		{
			// Send message
			return ERR_NOT_CONNECTED;
		}
		
		m_isConnected = false;
		m_hostIP.clear();
		m_clientSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

		if (m_clientSocket == INVALID_SOCKET)
		{
// 			std::cerr << "Error: creating socket failed!, " << WSAGetLastError() << std::endl;
			return ERR_INVALID_SOCKET;
		}

		sockaddr_in hint;
		hint.sin_family = AF_INET;
		hint.sin_port = htons(55000);
		//hint.sin_port = htons(51111);
		inet_pton(AF_INET, ipAddress.c_str(), &hint.sin_addr);

		if (connect(m_clientSocket, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR)
		{
// 			std::cerr << "Error: connection to client failed!, " << WSAGetLastError() << std::endl;
			Disconnect();
			return ERR_CONNECTION_FAILED;
		}

		char host[NI_MAXHOST];
		char serv[NI_MAXSERV];

		if (getnameinfo((sockaddr*)&hint, sizeof(hint), host, NI_MAXHOST, serv, NI_MAXSERV, 0) == 0) {
			m_hostName = host;
		}
		else {
			inet_ntop(AF_INET, &hint.sin_addr, host, NI_MAXHOST);
			m_hostName = host;
		}

		m_isConnected = true;
		m_hostIP = ipAddress;

		// sending welcome message
		const char* welcomeMsg = "Connected to NPI Server!\n---------------Welcome!---------------\n\n";
		if (!SendData(welcomeMsg, strlen(welcomeMsg) + 1))
			return ERR_DATA_NOT_SENT;
		if (!ConfirmFromClient())
			return ERR_CLIENT_CONFIRMATION_FAILED;

		return 0;
	}

	int Server::LastError = 0;
	bool Server::HandleError(const int &retCode)
	{
		if (retCode == SOCKET_ERROR || retCode == -1)
		{
			Server::LastError = WSAGetLastError();
			Disconnect();
			return false;
		}
		return true;
	}

	bool Server::ReceiveData(void *data, const int &len, int *totalBytesReceived/* = NULL*/)
	{
		int retCode = recv(m_clientSocket, (char*)data, len, 0);
		if (totalBytesReceived != NULL) // parameter provided
		{
			*totalBytesReceived = retCode;
		}
		return HandleError(retCode);
	}

	bool Server::SendData(const void *data, const int &len)
	{
		int retCode = send(m_clientSocket, (char*)data, len, 0);
		return HandleError(retCode);
	}

	bool Server::ConfirmFromClient()
	{
		int clientCode = 0;
		if (!ReceiveData(&clientCode, sizeof(clientCode)))
			return false;
		if (clientCode != 1000)
			return false;
		return true;
	}

	int Server::SendFile(const string& filePath)
	{
		if (filePath.empty()) 
		{
			return ERR_FILEPATH_EMPTY;
		}

		const int fileAvailable = 200;
		const int fileNotfound = 404;
		const int BUFFER_SIZE = 2500000;
		char* bufferFile = (char*)malloc(BUFFER_SIZE * sizeof(char));
		ifstream file;

		file.open(filePath.c_str(), std::ios::binary);
		if (file.is_open())
		{
			// Sending file available code at the client
			if (!SendData(&fileAvailable, sizeof(fileAvailable)))
			{
				free(bufferFile);
				return ERR_DATA_NOT_SENT;
			}
			if (!ConfirmFromClient())
			{
				free(bufferFile);
				return ERR_CLIENT_CONFIRMATION_FAILED;
			}

			// Positioning cursor at the end of the file to get the size
			file.seekg(0, ios::end);
			long fileSize = file.tellg();

			// Sending the file size to the client for checkup
			if (!SendData(&fileSize, sizeof(fileSize)))
			{
				free(bufferFile);
				return ERR_DATA_NOT_SENT;
			}
			if (!ConfirmFromClient())
			{
				free(bufferFile);
				return ERR_CLIENT_CONFIRMATION_FAILED;
			}

			// Repositioning cursor at the beginning of the file
			file.seekg(0, std::ios::beg);

			// Sending the file name to client
			size_t fileNameStartIndex = filePath.rfind("\\") + 1;
			string fileName = filePath.substr(fileNameStartIndex, filePath.size() - fileNameStartIndex);
			if (!SendData(fileName.c_str(), fileName.length()))
			{
				free(bufferFile);
				return ERR_DATA_NOT_SENT;
			}
			if (!ConfirmFromClient())
			{
				free(bufferFile);
				return ERR_CLIENT_CONFIRMATION_FAILED;
			}

			long fileBytesSent = 0;
			int lastPercentage = 0, newPercentage;
			// Read the file and send part of the files
			do 
			{
				memset(bufferFile, 0, BUFFER_SIZE);

				// Read BUFFER_SIZE bytes from file and send them to the client
				file.read(bufferFile, BUFFER_SIZE);
				if (file.gcount() > 0)
				{
					fileBytesSent += file.gcount();
					if (!SendData(bufferFile, file.gcount()))
					{
						free(bufferFile);
						return ERR_DATA_NOT_SENT;
					}
					if (!ConfirmFromClient())
					{
						free(bufferFile);
						return ERR_CLIENT_CONFIRMATION_FAILED;
					}
					newPercentage = (float)fileBytesSent / fileSize * 100;
					if (newPercentage > lastPercentage)
					{
						NotifyDownload(newPercentage);
						lastPercentage = newPercentage;
					}
				}
				else // if nothing was read, the last iteration sent all the file
					break;

			} while (file.gcount() > 0);

			file.close();
		}
		else
		{
			// Send err code file not found at the client
			if (!SendData(&fileNotfound, sizeof(fileNotfound)))
			{
				free(bufferFile);
				return ERR_DATA_NOT_SENT;
			}
			if (!ConfirmFromClient())
			{
				free(bufferFile);
				return ERR_CLIENT_CONFIRMATION_FAILED;
			}
			free(bufferFile);
			return ERR_FILE_OPEN;
		}

		free(bufferFile);
		Disconnect();
		return 0;
	}

	void Server::Disconnect()
	{
		m_isConnected = false;
		m_hostIP.clear();
		closesocket(m_clientSocket);
		WSACleanup();
	}

	string Server::GetHostName()
	{
		if (!m_hostIP.empty()) 
		{
			return m_hostName;
		}
		return NULL;
	}
}