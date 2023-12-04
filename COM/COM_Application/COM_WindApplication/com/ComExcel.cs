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

        // Implementation of creating a histogram based on a table
        public void createHistogram()
        {

        }
    }
}
