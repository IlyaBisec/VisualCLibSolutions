#pragma once

#include "stdafx.h"


namespace COM
{
	namespace WordApp
	{
		//using namespace word = Microsoft::Office::Interop::Word;

		// A class template that implements opening a Word application, 
		// creating a text message, saving a document and exiting Word
		class WordTemplate
		{
		public:

			void openWord();
			void closeWord();

			// Implementation of creating a text  message template from sender 
			// to recipient
			void createTemplate();

			void saveDocument();

		private:

			std::string m_recipientName  = "";
			std::string m_projectName    = "";
			std::string m_departmentName = "";
			std::string m_companyName	 = "";
			std::string m_senderName	 = "";
		};
	}
}