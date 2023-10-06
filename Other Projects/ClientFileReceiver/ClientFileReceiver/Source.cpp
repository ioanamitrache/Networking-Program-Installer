#include <iostream>
#include <WinSock2.h>
#include <WS2tcpip.h>
#include <fstream>
#include <windows.h>
#include <Lmcons.h>
#include <Msi.h>

#pragma comment(lib, "ws2_32.lib")

using namespace std;

#define STATUS_OK 0
#define STATUS_ERROR 1

// In case we got an error when sending/receiving, this will have the error code
static int LastError = 0;
// If there was any error during communication, status will change
static int STATUS = STATUS_OK;
/**
Returns true if the communication was successful, else false
retCode - the return code of the last send/recv
len - the length parameter used in the last send/recv
*/
bool HandleError(const int &retCode, const int& len)
{
	if (retCode == SOCKET_ERROR || retCode == -1)
	{
		STATUS = STATUS_ERROR;
		LastError = WSAGetLastError();
		return false;
	}
	return true;
}

/**
Returns true if it received a data, else false
socket - communication socket
data - pointer to the data to be received (can be int*, char*, object*)
len - dimension of data
*/
bool ReceiveData(const SOCKET &socket, void *data, int len, int *totalBytesReceived = NULL)
{
	int retCode = recv(socket, (char*)data, len, 0);
	if (totalBytesReceived != NULL) // parameter provided
	{
		*totalBytesReceived = retCode;
	}
	return HandleError(retCode, len);
}

/**
Returns true if it sent a data, else false
socket - communication socket
data - pointer to the data to be sent (can be int*, char*, object*)
len - dimension of data
*/
bool SendData(const SOCKET &socket, void *data, int len)
{
	int retCode = send(socket, (char*)data, len, 0);
	return HandleError(retCode, len);
}

int main() {
	
	WSADATA wsData;
	WORD ver = MAKEWORD(2, 2);

	if (WSAStartup(ver, &wsData) != 0) {
		std::cerr << "Error starting winsock!" << std::endl;
		return -1;
	}

	SOCKET listenerSock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	if (listenerSock == INVALID_SOCKET) {
		std::cerr << "Error creating listener socket! " << WSAGetLastError() << std::endl;
		WSACleanup();
		return -1;
	}

	sockaddr_in listenerHint;
	listenerHint.sin_family = AF_INET;
	listenerHint.sin_port = htons(55000);
	listenerHint.sin_addr.S_un.S_addr = INADDR_ANY;

	int bindResult = bind(listenerSock, (sockaddr*)&listenerHint, sizeof(listenerHint));
	if (bindResult != 0)
		cout << "Binding error" << endl;

	int listenResult = listen(listenerSock, SOMAXCONN);
	if (listenResult != 0)
		cout << "Listening error" << endl;

	sockaddr_in clientHint;
	int clientSize = sizeof(clientHint);

	SOCKET serverSock = accept(listenerSock, (sockaddr*)&clientHint, &clientSize);

	if (serverSock == SOCKET_ERROR) {
		std::cerr << "Error: accepting socket failed! " << WSAGetLastError() << std::endl;
		closesocket(listenerSock);
		WSACleanup();
		return -1;
	}

	char host[NI_MAXHOST];
	char serv[NI_MAXSERV];

	if (getnameinfo((sockaddr*)&clientHint, sizeof(clientHint), host, NI_MAXHOST, serv, NI_MAXSERV, 0) == 0) {
		std::cout << "Host: " << host << " connected on port: " << serv << std::endl;
	}
	else {
		inet_ntop(AF_INET, &clientHint.sin_addr, host, NI_MAXHOST);
		std::cout << "Host: " << host << " connected on port: " << ntohs(clientHint.sin_port) << std::endl;
	}

	closesocket(listenerSock);

	char welcomeMsg[255];

	auto ReceiveFunc = [&](void *data, int len, int *totalBytesReceived = NULL) -> bool
	{
		if (!ReceiveData(serverSock, data, len, totalBytesReceived))
		{
			closesocket(serverSock);
			WSACleanup();
			return false;
		}
		return true;
	};

	auto SendFunc = [&](void *data, int len) -> bool
	{
		if (!SendData(serverSock, data, len))
		{
			closesocket(serverSock);
			WSACleanup();
			return false;
		}
		return true;
	};

	//confirm to the server that we received the data
	int clientConfirmationCode = 1000;
	auto ConfirmToServer = [&]() -> bool
	{
		if (!SendFunc(&clientConfirmationCode, sizeof(clientConfirmationCode)))
		{
			cout << "Error: could not confirm to the server that we received data!" << endl;
			return false;
		}
		return true;
	};

	// Wait for welcome message
	if (!ReceiveFunc(welcomeMsg, 255))
	{
		cout << "Could not receive any message from server!" << endl;
		return -1;
	}
	if (!ConfirmToServer())
		return -1;

	cout << welcomeMsg << endl;

	const int BUFFER_SIZE = 2500000;
	char* bufferFile = (char*)malloc(BUFFER_SIZE * sizeof(char));
	char fileReceived[FILENAME_MAX];
	ofstream file;

	int codeAvailable = 404;
	const int fileAvailable = 200;
	const int fileNotfound = 404;
	long fileRequestedSize = 0;
	string filePath;

	int fileDownloaded = 0;

	//receive file confirmation
	if (!ReceiveFunc(&codeAvailable, sizeof(codeAvailable)))
	{
		cout << "Error: could not receive file confirmation code!" << endl;
		free(bufferFile);
		return -1;
	}
	if (!ConfirmToServer())
	{
		free(bufferFile);
		return -1;
	}

	//file confirmation received
	if (codeAvailable == 200) 
	{
		if (!ReceiveFunc(&fileRequestedSize, sizeof(long)))
		{
			cout << "Error: could not receive file size!" << endl;
			free(bufferFile);
			return -1;
		}
		if (!ConfirmToServer())
		{
			free(bufferFile);
			return -1;
		}
		cout << "File Size:" << fileRequestedSize << '\n';

		//receive file name
		memset(fileReceived, 0, FILENAME_MAX);
		if (!ReceiveFunc(&fileReceived, FILENAME_MAX))
		{
			cout << "Error: could not receive file name!" << endl;
			free(bufferFile);
			return -1;
		}
		if (!ConfirmToServer())
		{
			free(bufferFile);
			return -1;
		}
		string fileName(fileReceived);

		TCHAR username[UNLEN + 1];
		DWORD size = UNLEN + 1;
		GetUserName((TCHAR*)username, &size);

		wstring usernameWstr(&username[0]);
		string usernameStr(usernameWstr.begin(), usernameWstr.end());
		filePath = "C:\\Users\\" + usernameStr + "\\Downloads\\" + fileName;
		cout << "File name: " << fileReceived << endl;

		int totalBytesReceived;
		file.open(filePath, std::ios::binary | std::ios::trunc);

		do 
		{
			memset(bufferFile, 0, BUFFER_SIZE);

			if (!ReceiveFunc(bufferFile, BUFFER_SIZE, &totalBytesReceived))
			{
				cout << "Error: could not receive file content!" << endl;
				free(bufferFile);
				return -1;
			}
			if (!ConfirmToServer())
			{
				free(bufferFile);
				return -1;
			}

			file.write(bufferFile, totalBytesReceived);
			fileDownloaded += totalBytesReceived;
		} while (fileDownloaded < fileRequestedSize);

		file.close();
		cout << "File finished downloading!" << endl;
	}
	else if (codeAvailable == 404) 
	{
		std::cout << "Can't open file or file not found!" << std::endl;
	}

	if (filePath.find(".msi") != string::npos)
	{
		char cmd[150];
		string commandStr = "msiexec /i \"" + filePath + "\" /passive";
		strcpy(cmd, commandStr.c_str());

		int result = system(cmd);

		if (false && !SendFunc(&result, sizeof(result)))
		{
			cout << "Communication error: Can't confirm to the server the installation result" << endl;
			free(bufferFile);
			return -1;
		}

		if (result < 0)
			cout << "Installation error: " << strerror(errno) << endl;
		else
			cout << "Installation successfully finished!" << endl;
	}

	closesocket(serverSock);
	WSACleanup();

	free(bufferFile);

	char c;
	cin >> c;
	
	return 0;
}