#include "pch.h"
#include "Manager.h" // CLR
#include "Server.h" // C++
#include <msclr\marshal_cppstd.h> // CLR
#include <string> // C++

using namespace System; // C#

namespace CLR
{
	Manager::Manager()
	{

	}

	void Manager::SetInstance(Manager^% inst)
	{
		instance = inst;
	}

	Manager^ Manager::GetInstance()
	{
		return instance;
	
	}

	int Manager::ServerInitialize()
	{
		CLR::Server* server = CLR::Server::GetInstance();
		int retCode = server->Initialize();
		return retCode;
	}

	int Manager::ServerConnect(String^ ipAddress)
	{
		CLR::Server* server = CLR::Server::GetInstance();
		msclr::interop::marshal_context context;
		std::string stdIPaddress = context.marshal_as<std::string>(ipAddress);
		int retCode = server->Connect(stdIPaddress);
		return retCode;
	}
	
	int Manager::ServerSendFile(System::String^ filePath)
	{
		CLR::Server* server = CLR::Server::GetInstance();
		msclr::interop::marshal_context context;
		std::string stdFilePath = context.marshal_as<std::string>(filePath);
		int retCode = server->SendFile(stdFilePath);
		return retCode;
	}

	void Manager::ServerDisconnect()
	{
		CLR::Server* server = CLR::Server::GetInstance();
		server->Disconnect();
	}

	String^ Manager::GetHostName()
	{
		CLR::Server* server = CLR::Server::GetInstance();
		String^ pStrManaged = gcnew String(server->GetHostName().c_str());
		return pStrManaged;
		// C++ Memory = native
		// C# Memory = managed
	}
}