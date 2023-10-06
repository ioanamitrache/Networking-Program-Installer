#include <iostream>
#include <fstream>
#include <ws2tcpip.h>
#include <WinSock2.h>

#pragma comment(lib, "ws2_32.lib")

using namespace std;

int main() {
	WSADATA wsData;
	WORD ver = MAKEWORD(2, 2);

	if (WSAStartup(ver, &wsData) != 0) {
		std::cerr << "Error: starting winsock failed!" << std::endl;
		return -1;
	}

	SOCKET clientSock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	if (clientSock == INVALID_SOCKET) {
		std::cerr << "Error: creating socket failed!, " << WSAGetLastError() << std::endl;
		return -1;
	}

	char clientAddress[NI_MAXHOST];
	memset(clientAddress, 0, NI_MAXHOST);

	std::cout << "Enter client IP address: ";
	std::cin.getline(clientAddress, NI_MAXHOST);

	sockaddr_in hint;
	hint.sin_family = AF_INET;
	hint.sin_port = htons(55000);
	//hint.sin_port = htons(51111);
	inet_pton(AF_INET, clientAddress, &hint.sin_addr);


	if (connect(clientSock, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR) {
		std::cerr << "Error: connection to client failed!, " << WSAGetLastError() << std::endl;
		closesocket(clientSock);
		WSACleanup();
		return -1;
	}

	const char* welcomeMsg = "Welcome to file server!";
	bool clientClose = false;
	char fileToBeSent[FILENAME_MAX];
	const int fileAvailable = 200;
	const int fileNotfound = 404;
	const int BUFFER_SIZE = 1024;
	char bufferFile[BUFFER_SIZE];
	ifstream file;

	// sending welcome message
	int bysendMsg = send(clientSock, welcomeMsg, strlen(welcomeMsg) + 1, 0);

	if (bysendMsg == 0) {
		// error sending data - break loop
		closesocket(clientSock);
		WSACleanup();
		return -1;
	}

	cout << "Enter file name: " << endl;
	memset(fileToBeSent, 0, FILENAME_MAX);
	cin.getline(fileToBeSent, FILENAME_MAX);

	do {
		// open file
		file.open(fileToBeSent, std::ios::binary);

		if (file.is_open()) {
			// file is available
			int bySendinfo = send(clientSock, (char*)&fileAvailable, sizeof(int), 0);
			if (bySendinfo == 0 || bySendinfo == -1) {
				// error sending data - break loop
				cout << "Error: sending file confirmation code failed!";
				clientClose = true;
			}

			// get file size
			file.seekg(0, ios::end);
			long fileSize = file.tellg();
			cout << "File Size:" << fileSize << '\n';

			// send filesize to client
			bySendinfo = send(clientSock, (char*)&fileSize, sizeof(long), 0);
			if (bySendinfo == 0 || bySendinfo == -1) {
				// error sending data - break loop
				cout << "Error: sending file size failed!";
				clientClose = true;
			}
			file.seekg(0, std::ios::beg);

			//send file name to client
			bySendinfo = send(clientSock, (char*)&fileToBeSent, sizeof(fileToBeSent), 0);
			if (bySendinfo == 0 || bySendinfo == -1) {
				// error sending data - break loop
				cout << "Error: sending file name failed!";
				clientClose = true;
			}

			// read file with do-while loop
			do {
				// read and send file parts to client
				file.read(bufferFile, BUFFER_SIZE);
				if (file.gcount() > 0)
				{
					bySendinfo = send(clientSock, (char*)&bufferFile, file.gcount(), 0);
				}

				cout << "File content: " << bufferFile << endl;
				if (bySendinfo == 0 || bySendinfo == -1) {
					// error sending data - break loop
					cout << "Error: sending file content failed! error code: " << bySendinfo << endl;
					clientClose = true;
					break;
				}
				if (bySendinfo == fileSize)
				{
					clientClose = true;
					break;
				}
			} while (file.gcount() > 0);
			file.close();
			clientClose = true;
			cout << "File successfully sent!" << endl;
		}
		else {
			// Can't open file or file not found
			cout << "File corrupted or not found." << endl;
			int bySendCode = send(clientSock, (char*)&fileNotfound, sizeof(int), 0);
			if (bySendCode == 0 || bySendCode == -1) {
				// error sending data - break loop
				cout << "Error: sending file not found code failed!";
				clientClose = true;
			}
		}
	} while (!clientClose);

	// cleanup
	closesocket(clientSock);
	WSACleanup();

	return 0;

}