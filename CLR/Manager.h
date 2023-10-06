#pragma once

namespace CLR
{
	public ref class Manager // ref - in C# not in C++
	{
	private:
		static Manager^ instance; // ^ - in C# not in C++, is actually an instance of ManagedManager

	protected:
		Manager();
		static void SetInstance(Manager^% inst); // % - handle eq. reference in CLR/C++

	public:
		static Manager^ GetInstance();

		virtual void NotifyDownload(int percentage) = 0;

		int ServerInitialize();
		int ServerConnect(System::String^ ipAddress);
		int ServerSendFile(System::String^ filePath);
		void ServerDisconnect();
		System::String^ GetHostName();
	};
}