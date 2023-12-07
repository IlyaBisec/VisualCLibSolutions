using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

// Unfortunately, COM objects cannot be passed by reference, 
// which leads to the error "the reference to the object does not point to an instance 
// of the object" - which also leads to a violation of the following principles:
//
// DRY(Don’t Repeat Yourself), KISS(Keep It Simple, Stupid) and 
// SOLID(Single-responsibility principle only)
//
// Therefore, all the functionality of this class has been moved to the main class. 
// Even the constructor will not help here, since its presence in the class directly 
// contradicts the condition of the task:
//
// Opening a new Excel instance, creating a table, adding a table, making a histogram 
// based on data from the table, saving and closing
//
//
// In any other case, I didn't have enough time and knowledge to figure out how to fix
// the error with references to an instance of a COM object
//
// COM Excel
// Ilya Bisec - 07.12.23

namespace COM_WindApplication.com
{
    // A class that implements opening an Excel application,
    // creating a table with the weather in countries and their regions with
    // an average value, creating a histogram based on the table, saving a document
    // and exiting Excel
    internal class ComExcel
    {
        // Creating a table in Excel or initializing, adding headers
        public void createTable(String monthName = "Месяц")
        {
            try
            {
                // Initialization Excel
                m_excelApp = new Excel.Application();
                m_workbook = m_excelApp.Workbooks.Add();
                m_worksheet = m_workbook.ActiveSheet;

                // Writing headers in Excel
                m_headersRange = m_worksheet.Range["A1:D1"];
                m_headersRange.Value2 = new[] { "Страна", "Город", monthName, "Среднее значение температур" };
                m_headersRange.Font.Bold = true;

                m_lastRow = 2;
                m_averageColumn = 4;

            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Create excel table error"); }
        }

        // Implementation creating a template for a tabular weather document in different
        // countries and cities, with different temperatures by month and calculating
        // the average value
        public void addNote(String country, String city, String month, String temperature)
        {
            double temp_temperature = Convert.ToDouble(temperature);
            try
            {
                // Search for a column with the name of the month
                int monthColumn = 0;
                for (int i = 1; i <= m_worksheet.Cells[1, m_averageColumn].End(XlDirection.xlToLeft).Column; i++)
                {
                    if (m_worksheet.Cells[1, i].Value2 == month)
                    {
                        monthColumn = i;
                        break;
                    }
                }

                // If the column with the month name is not found, create a new one 
                if(monthColumn == 0)
                {
                    monthColumn = m_worksheet.Cells[1, m_averageColumn].End(XlDirection.xlToLeft).Column + 1;
                    m_worksheet.Cells[1, monthColumn].Value2 = month;
                    m_worksheet.Cells[1, monthColumn].Font.Bold = true;
                    m_averageColumn++;
                }

                // Writing data to Excel
                m_worksheet.Cells[m_lastRow, 1].Value2 = country;
                m_worksheet.Cells[m_lastRow, 2].Value2 = city;
                m_worksheet.Cells[m_lastRow, monthColumn].Value2 = temp_temperature;

                m_lastRow++;

                // Calculation and recording of the average temperature value
                int dataStartRow = 2;
                int dataEndRow = m_worksheet.Cells[m_lastRow - 1, m_averageColumn - 1].End(XlDirection.xlDown).Row;
                Range dataRange = m_worksheet.Range[$"C{dataStartRow}:C{dataEndRow}"];
                Range averageCell = m_worksheet.Cells[m_lastRow, m_averageColumn];
                averageCell.Value2 = $"=AVERAGE({dataRange.Address})";
                averageCell.Font.Bold = true;
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "add the new note to the excel table error"); }
        }

        public void saveTableAs()
        {
            var res = Properties.Settings.Default;

            String defaultNewFilePath = res.newDefaultFilePath;
            try
            {
                // Getting an active instance of the Excel application
                //Excel.Application excel_app = (Excel.Application)Marshal.GetActiveObject("Excel.Application"); ;
                //Excel.Workbook excel_workbook = excel_app.ActiveWorkbook;
                //Excel.Worksheet excel_worksheet = excel_workbook.ActiveSheet;

                // Saving excel table
                DateTime todayDate = DateTime.Today;

                m_workbook.SaveAs(defaultNewFilePath + "\\" + todayDate.ToString("yyyy-MM-dd.hh.mm.ss") + ".xlsx");
                m_workbook.Close(false);
                m_excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(m_worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(m_workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excelApp);

                MessageBox.Show("Default file path: " + defaultNewFilePath + todayDate.ToString("yyyy-MM-dd.hh.mm.ss"), "The table of temperature was successfully created!");
                
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Create excel file error"); }

        }
        

        // Implementation of creating a histogram based on a table
        public void createHistogram()
        {

        }

        // Excel variables
        private Excel.Application m_excelApp;
        private Excel.Workbook m_workbook;
        private Excel.Worksheet m_worksheet;
        private Excel.Range m_headersRange;

        private int m_lastRow;
        private int m_averageColumn;
    }
}

//Напиши программу, которая позволяет создать таблицу в Excel.
//    Есть поля страна, город, месяц, температура.И есть кнопки 
//    создать таблицу и добавить запись.При создании таблицы, 
//        в Excel записываются в заголовки имяСтрана, имяГород, 
//        имяМесяц и Среднее значение температур.При заполнении таблицы, данные берутся из полей
//        и записываются соответственно под заголовком имяСтрана - данные с поля страна, имяГород- данные с поля
//        город, в заголовок имяМесяц - данные с поля месяц, а под заголовком имяМесяц - данные с поля температура
//        . При добавлении записи, открывается ранее созданная таблица и добавляются данные с полей, если имя месяца
//        совпадает с уже имеющимся в таблице Excel, то данные записываются под этим именем, если нет создается новый столбец
//        с именем месяца и полем температура под ним.Столбец среднее значение температур, всегда создается последним столбцом в таблице 
//        Excel и высчитывает среднее значение полей в таблице и записывает их в свой столбец. С помощью C# Winforms Microsoft.Office.Interop.Excel