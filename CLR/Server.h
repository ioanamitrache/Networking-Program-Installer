#pragma once
#include "../Engine/Classes/Server.h" // C++

namespace CLR
{
	class Server : public Engine::Server
	{
	private:
		static Server* m_instance;
		Server() {};

	protected:
		virtual void NotifyDownload(int percentage) override;

	public:
		static Server* GetInstance();
	};
}