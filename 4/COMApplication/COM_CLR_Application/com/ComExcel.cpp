#pragma once

#include "../stdafx.h"

namespace COM
{
	namespace ExcelApp
	{
		class ExcelTemplate
		{
		public:
			void openExcel();
			void closeExcel();

			void createTemplate();
			void createHistogram();

			void saveTable();

		private:
			// Titles
			std::string m_countryRegion;
			std::string m_monthName;
			std::string m_totalTitle;

			// Number of months columns created
			int m_countOfMonth;


		};
	}
}