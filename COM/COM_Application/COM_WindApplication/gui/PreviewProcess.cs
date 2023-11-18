using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_WindApplication.gui
{
    internal class PreviewProcess
    {
        // class PreviewFile
        // ----------------------------------------------
        public PreviewProcess(string appName, string pathName)
        {
            path = pathName;
            applicationName = appName;
        }
        public string path { get; set; }
        public string applicationName { get; set; }

        // ----------------------------------------------

        // это два разных класса, надо разделить

        // class PreviewProcess - main
        // ----------------------------------------------
        public IEnumerable<PreviewProcess> PreviewProceses { get; private set; } = new[]
        {
            new PreviewProcess("Notepad++", $@"D:\Soft\Notepad++\notepad++.exe"),
            new PreviewProcess("Word", $@"F:\Games\ILYAsFolder\BarSU\LABS\4_course\EugineShapovich\VisualKa\VisualCLibSolutions\COM\COM_Application\COM_WindApplication\bin\Debug\doc\DefaultTemplate.docx"),
            //new PreviewProcess("Regedit", $@"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\regedit.exe"),
        };

        // ----------------------------------------------
    }
}
