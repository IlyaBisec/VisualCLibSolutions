using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace COM_WindApplication.com
{
    // A class that implements opening an Excel application,
    // creating a table with the weather in countries and their regions with
    // an average value, creating a histogram based on the table, saving a document
    // and exiting Excel
    internal class ComExcel
    {

        //private int currentRow;

        // Implementation creating a template for a tabular weather document in different
        // countries and cities, with different temperatures by month and calculating
        // the average value
        public void createTable(String country, String city, String month, String temperature)
        {
            

            try
            {
                // Excels variables
                Excel.Application excel_app = new Excel.Application();
                Excel.Workbook excel_workbook = excel_app.Workbooks.Add();
                Excel.Worksheet excel_worksheet = excel_workbook.ActiveSheet;

                // Since with currentRow = 1, where 1 is the position of the headers 
                int currentRow = 2;

                excel_worksheet.Cells[currentRow, 1] = country;
                excel_worksheet.Cells[currentRow, 2] = city;
                // m_excelWorksheet.Cells[currentRow, 3] = month;
                excel_worksheet.Cells[currentRow, 3] = temperature;

                //currentRow++;

                
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Create excel table error"); }
        }

        public void addNote(String country, String city, String month, String temperature)
        {
            try
            {
                // Getting an active instance of the Excel application
                Excel.Application excel_app = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
                Excel.Workbook excel_workbook = excel_app.ActiveWorkbook;
                Excel.Worksheet excel_worksheet = excel_workbook.ActiveSheet;

                // Searching for an empty string to add new data
                int lastRow = excel_worksheet.Cells[excel_worksheet.Rows.Count, 1].End(Excel.XlDirection.xlUp).Row + 1;

                excel_worksheet.Cells[lastRow, 1] = country;
                excel_worksheet.Cells[lastRow, 2] = city;
                // m_excelWorksheet.Cells[currentRow, 3] = month;
                excel_worksheet.Cells[lastRow, 3] = temperature;

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
                Excel.Application excel_app = (Excel.Application)Marshal.GetActiveObject("Excel.Application"); ;
                Excel.Workbook excel_workbook = excel_app.ActiveWorkbook;
                Excel.Worksheet excel_worksheet = excel_workbook.ActiveSheet;

                // Saving excel table
                DateTime todayDate = DateTime.Today;

                excel_workbook.SaveAs(defaultNewFilePath + "\\" + todayDate.ToString("yyyy-MM-dd.hh.mm.ss") + ".xlsx");
                excel_workbook.Close();
                excel_app.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel_worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel_workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel_app);

                MessageBox.Show("Default file path: " + defaultNewFilePath + todayDate.ToString("yyyy-MM-dd.hh.mm.ss"), "The table of temperature was successfully created!");
                
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Create excel file error"); }

        }

        

        public void createTable2(String country, String city, String temperature, String month, String defaultNewFilePath)
        {
            Excel.Application excel_App = null;
            int currentRow = 2;

            try
            {
                excel_App = new Excel.Application();
                Excel.Workbook excel_Workbook = excel_App.Workbooks.Add();
                Excel.Worksheet excel_Worksheet = excel_Workbook.ActiveSheet;
                

                // Column titles
                excel_Worksheet.Cells[1, 1] = "Страна";
                excel_Worksheet.Cells[1, 2] = "Город";
                excel_Worksheet.Cells[1, 5] = "Средняя температура";

                // Datum
                // Checking if there is already an entry for this country and city
                for(int row = 2; row <= currentRow; row++)
                {
                    string extingCountry = excel_Worksheet.Cells[row, 1].Text;
                    string existingCity = excel_Worksheet.Cells[row, 2].Text;

                    if(extingCountry == country && existingCity == city)
                    {
                        // The record already exists, add a new month and update the average value
                        int lastColumn = excel_Worksheet.Cells[row, excel_Worksheet.Columns.Count].End(Excel.XlDirection.xlToLeft).Column;
                        int newColumn = lastColumn + 1;

                        excel_Worksheet.Cells[row, newColumn].Value = month;
                        excel_Worksheet.Cells[row, newColumn + 1].Value = temperature;

                        // Count of months
                        int temperatureCount = lastColumn / 2;
                        // Average of temperature
                        double averageTemperature = excel_Worksheet.Cells[row, 3].Value;

                        // Update average value of temperature
                        double newAverageTemperature = (averageTemperature * temperatureCount + double.Parse(temperature)) / (temperatureCount + 1);
                        excel_Worksheet.Cells[row, 3].Value = newAverageTemperature;

                        excel_Workbook.Save();
                        return;
                    }

                    // Record not exists, creating new record
                    excel_Worksheet.Cells[currentRow, 1].Value = country;
                    excel_Worksheet.Cells[currentRow, 2].Value = city;
                    excel_Worksheet.Cells[currentRow, 3].Value = 1; // Count of months
                    excel_Worksheet.Cells[currentRow, 4].Value = month;
                    excel_Worksheet.Cells[currentRow, 5].Value = temperature;

                    currentRow++;

                    // Saving excel table
                    DateTime todayDate = DateTime.Today;

                    excel_App.ActiveWorkbook.SaveAs(defaultNewFilePath + "\\" + todayDate.ToString("yyyyMMdd"));
                    excel_App.ActiveWorkbook.Close();

                    MessageBox.Show("Default file path: " + defaultNewFilePath + todayDate.ToString("yyyyMMdd"), "The table of temperature was successfully created!");
                }


                // Average of temperature
               // excel_Worksheet.Cells[currentRow, 5].Formula = "=AVERAGE(C" + currentRow + ":D" + currentRow + ")";

               

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Create excel table error"); }
            finally
            {
                if (excel_App != null)
                {
                    excel_App.Quit();
                }
            }
        }

       
        public void createSimpleTable(String country, String city, String temperature, String temperature2, String temperature3, String monthName, String monthName2, String monthName3, String defaultNewFilePath)
        {
            Excel.Application excel_App = null;
            int row = 2;

            try
            {

                excel_App = new Excel.Application();
                Excel.Workbook excel_Workbook = excel_App.Workbooks.Add();
                Excel.Worksheet excel_Worksheet = excel_Workbook.ActiveSheet;

                // Column titles
                excel_Worksheet.Cells[1, 1] = "Страна";
                excel_Worksheet.Cells[1, 2] = "Город";
                excel_Worksheet.Cells[1, 3] = monthName;
                excel_Worksheet.Cells[1, 4] = monthName2;
                excel_Worksheet.Cells[1, 5] = monthName3;
                excel_Worksheet.Cells[1, 6] = "Средняя температура";

                // Datum
                excel_Worksheet.Cells[row, 1] = country;
                excel_Worksheet.Cells[row, 2] = city;
                excel_Worksheet.Cells[row, 3] = temperature;
                excel_Worksheet.Cells[row, 4] = temperature2;
                excel_Worksheet.Cells[row, 5] = temperature3;

                // Avarage
                excel_Worksheet.Cells[row, 5].Formula = "=AVERAGE(C" + row + ":D" + row + ":E" + row + ")";

                // Centering headings
                var range = excel_Worksheet.Range["A1:F1"];
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Auto Column Width
                excel_Worksheet.Columns.AutoFit();


                // Saving excel table
                DateTime todayDate = DateTime.Today;

                excel_App.ActiveWorkbook.SaveAs(defaultNewFilePath + "\\" + todayDate.ToString("yyyyMMdd"));
                excel_App.ActiveWorkbook.Close();

                MessageBox.Show("Default file path: " + defaultNewFilePath + todayDate.ToString("yyyyMMdd"), "The table of temperature was successfully created!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Create excel table error"); }
            finally
            {
                if (excel_App != null)
                {
                    excel_App.Quit();
                }
            }
        }
        

        // Implementation of creating a histogram based on a table
        public void createHistogram()
        {

        }
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