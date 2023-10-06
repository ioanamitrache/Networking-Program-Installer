#pragma once
#include <string>
#include <WinSock2.h>

using namespace std;

namespace Engine
{
	class Server
	{
	public:
		// Common
		static const int ERR_DATA_NOT_SENT = -5;
		static const int ERR_DATA_NOT_RECEIVED = -6;
		static const int ERR_CLIENT_CONFIRMATION_FAILED = -9;

		// Initialize
		static const int ERR_INITIALIZE = -1;

		// Connect
		static const int ERR_NOT_CONNECTED = -2;
		static const int ERR_INVALID_SOCKET = -3;
		static const int ERR_CONNECTION_FAILED = -4;
		
		// SendFile
		static const int ERR_FILEPATH_EMPTY = -7;
		static const int ERR_FILE_OPEN = -8;

	protected:
		Server(); // Not private since in CLR there is a Server that derives this one
		virtual void NotifyDownload(int percentage) = 0;

	private:
		bool m_isConnected;
		string m_hostIP;
		SOCKET m_clientSocket;
		string m_hostName;

		static int LastError;
		bool HandleError(const int &retCode);
		bool ReceiveData(void *data, const int &len, int *totalBytesReceived = NULL);
		bool SendData(const void *data, const int &len);
		bool ConfirmFromClient();

	public:

		int Initialize();
		int Connect(const string& ipAddress);
		int SendFile(const string& filePath);
		void Disconnect();
		string GetHostName();
	};
}