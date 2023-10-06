#include "pch.h"
#include "Server.h"
#include "Manager.h"

namespace CLR
{
	Server* Server::m_instance = nullptr;

	Server* Server::GetInstance()
	{
		if (m_instance == nullptr)
			m_instance = new Server();
		return m_instance;
	}

	void Server::NotifyDownload(int percentage)
	{
		Manager^ manager = Manager::GetInstance();
		manager->NotifyDownload(percentage);
	}
}