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
        // Excels variables
        private Excel.Application excelApp;
        private Excel.Workbook excelWorkbook;
        private Excel.Worksheet excelWorksheet;

        // Implementation creating a template for a tabular weather document in different
        // countries and cities, with different temperatures by month and calculating
        // the average value
        public void createTable(String country, String city, String temperature, String month, String defaultNewFilePath)
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
        public void addNote(String country, String city, String temperature, String month, String monthCount, String defaultNewFilePath)
        {

            int startRow = 2;

            while (excelWorksheet.Cells[startRow, 2].Value != null)
            {
                startRow++;
            }

            excelWorksheet.Cells[startRow, 1] = country;
            excelWorksheet.Cells[startRow, 2] = city;

            int month_count = int.Parse(monthCount);

            for (int i = 0; i < month_count; i++)
            {
                string monthName = month + (i + 1).ToString();
                int _temperature = int.Parse(temperature);

                excelWorksheet.Cells[startRow, 3 + i] = monthName;
                excelWorksheet.Cells[startRow, 3 + i].Offset[0, 1] = _temperature;
            }

            // Average of temperature
            excelWorksheet.Cells[startRow, 3 + monthCount].FormulaR1C1 = $"=AVERAGE(RC[-{monthCount}]:RC[-1])";

            // Auto Column Width
            excelWorksheet.Columns.AutoFit();

            // Saving excel table
            DateTime todayDate = DateTime.Today;

            excelApp.ActiveWorkbook.SaveAs(defaultNewFilePath + "\\" + todayDate.ToString("yyyyMMdd"));
            excelApp.ActiveWorkbook.Close();

            MessageBox.Show("Default file path: " + defaultNewFilePath + todayDate.ToString("yyyyMMdd"), "The table of temperature was successfully created!");
        }

        // Implementation of creating a histogram based on a table
        public void createHistogram()
        {

        }
    }
}
