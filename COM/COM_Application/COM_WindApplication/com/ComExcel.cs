using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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
        public void createTable()
        {
            try
            {
                var res = Properties.Settings.Default;

                // Initialization Excel
                m_excelApp = new Excel.Application();
                m_excelWorkbook = m_excelApp.Workbooks.Add();
                m_excelWorksheet = m_excelWorkbook.ActiveSheet;

                // Writing headers in Excel
                m_excelWorksheet.Cells[1, 1] = "Страна";
                m_excelWorksheet.Cells[1, 2] = "Город";
                //int column = 3;


                //worksheet.Cells[1, column] = "Месяц";
                //column++;


                // Saving excel table
                var createdExcelFile = res.newDefaultFilePath + "\\" + "TemperatureDocument" + ".xlsx";

                m_excelWorkbook.SaveAs(createdExcelFile);
                m_excelWorkbook.Close();
                m_excelApp.Quit();

                MessageBox.Show("Default file path: " + res.newDefaultFilePath + "TemperatureDocument", "The table of temperature was successfully created!");

            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Create excel table error"); }
        }

        // Implementation creating a template for a tabular weather document in different
        // countries and cities, with different temperatures by month and calculating
        // the average value
        public void addNote(String country, String city, String month, String temperature)
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + "TemperatureDocument" + ".xlsx";

            double temp_temperature = Convert.ToDouble(temperature);

            try
            {
                m_excelApp = new Excel.Application();
                m_excelWorkbook = m_excelApp.Workbooks.Open(createdLastFile);
                m_excelWorksheet = m_excelWorkbook.ActiveSheet;

                int row = 2;
                while (m_excelWorksheet.Cells[row, 1].Value != null)
                {
                    if (m_excelWorksheet.Cells[row, 1].Value.ToString() == country)
                    {
                        m_excelWorksheet.Cells[row, 2] = city;
                        break;
                    }
                    row++;
                }

                if (m_excelWorksheet.Cells[row, 1].Value == null)
                {
                    m_excelWorksheet.Cells[row, 1] = country;
                    m_excelWorksheet.Cells[row, 2] = city;
                }

                bool monthExists = false;
                int column = 3;
                while (m_excelWorksheet.Cells[1, column].Value != null)
                {
                    if (m_excelWorksheet.Cells[1, column].Value.ToString() == month)
                    {
                        m_excelWorksheet.Cells[row, column] = temp_temperature;
                        monthExists = true;
                        break;
                    }
                    column++;
                }

                if (!monthExists)
                {
                    m_excelWorksheet.Cells[1, column] = month;
                    m_excelWorksheet.Cells[row, column] = temp_temperature;
                }

                m_excelWorkbook.Save();
                m_excelWorkbook.Close();
                m_excelApp.Quit();

                Marshal.ReleaseComObject(m_excelWorksheet);
                Marshal.ReleaseComObject(m_excelWorkbook);
                Marshal.ReleaseComObject(m_excelApp);

                Marshal.FinalReleaseComObject(m_excelWorksheet);
                Marshal.FinalReleaseComObject(m_excelWorkbook);
                Marshal.FinalReleaseComObject(m_excelApp);


                MessageBox.Show("An entry has been added!");
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "add the new note to the excel table error"); }
        }

        // Opens the saved file, creates a column with "average temperature", reads 
        // the temperature values by month and writes them to its column
        public void calculateAverageTemperature()
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + "TemperatureDocument" + ".xlsx";
            try
            {
                m_excelApp = new Excel.Application();
                m_excelWorkbook = m_excelApp.Workbooks.Open(createdLastFile);
                m_excelWorksheet = m_excelWorkbook.ActiveSheet;

                int lastColumnIndex = m_excelWorksheet.Cells[1, m_excelWorksheet.Columns.Count].End[Excel.XlDirection.xlToLeft].Column;
                string averageColumnHeader = "Cреднее значение температур";
                m_excelWorksheet.Cells[1, lastColumnIndex + 1] = averageColumnHeader;

                int lastRowIndex = m_excelWorksheet.Cells[m_excelWorksheet.Rows.Count, 1].End[Excel.XlDirection.xlUp].Row;
                for (int row = 2; row <= lastRowIndex; row++)
                {
                    double sum = 0;
                    int count = 0;

                    for (int column = 3; column <= lastColumnIndex; column++)
                    {
                        if (m_excelWorksheet.Cells[row, column].Value != null)
                        {
                            sum += double.Parse(m_excelWorksheet.Cells[row, column].Value.ToString());
                            count++;
                        }
                    }

                    double average = count > 0 ? sum / count : 0;
                    m_excelWorksheet.Cells[row, lastColumnIndex + 1] = average;
                }

                m_excelWorkbook.SaveAs(createdLastFile);
                m_excelWorkbook.Close();
                m_excelApp.Quit();


                releaseExcelObject(m_excelWorksheet);
                releaseExcelObject(m_excelWorkbook);
                releaseExcelObject(m_excelApp);

                MessageBox.Show("The average temperature values are calculated!");
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "Error in creating the average temperature value"); }

        }

        // Implementation of creating a histogram based on a table
        public void createHistogram()
        {
            var res = Properties.Settings.Default;
            var createdLastFile = res.newDefaultFilePath + "\\" + "TemperatureDocument" + ".xlsx";

            try
            {
                m_excelApp = new Excel.Application();
                m_excelWorkbook = m_excelApp.Workbooks.Open(createdLastFile);
                m_excelWorksheet = m_excelWorkbook.ActiveSheet;

                // Reading data from an Excel spreadsheet
                Excel.Range range = m_excelWorksheet.UsedRange;
                int rowCount = range.Rows.Count;
                int colCount = range.Columns.Count;

                object[,] data = new object[rowCount, colCount];
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        data[i - 1, j - 1] = range.Cells[i, j].Value2;
                    }
                }

                m_excelWorkbook.Close();
                m_excelApp.Quit();

                // Building a histogram
                Excel.Chart chart = new Excel.Chart();
                chart.ChartType = Excel.XlChartType.xlColumnClustered;
                chart.SetSourceData(m_excelWorksheet.Range["A1", $"A{rowCount}"]);
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Гистограмма";
                chart.Location(Excel.XlChartLocation.xlLocationAsObject, m_excelWorksheet.Name);

                // Save file
                m_excelWorkbook.SaveAs(createdLastFile);

                MessageBox.Show("The histogram is saved in a file!");

                releaseExcelObject(m_excelWorksheet);
                releaseExcelObject(m_excelWorkbook);
                releaseExcelObject(m_excelApp);
            }
            catch (System.Runtime.InteropServices.COMException ex) { MessageBox.Show(ex.ToString(), "It was not possible to create a histogram"); }
        }

        // Frees up resources used to create an Excel spreadsheet
        private void releaseExcelObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
       
        
        // Excel variables
        private Excel.Application m_excelApp;
        private Excel.Workbook m_excelWorkbook;
        private Excel.Worksheet m_excelWorksheet;
    }
}







   
 
