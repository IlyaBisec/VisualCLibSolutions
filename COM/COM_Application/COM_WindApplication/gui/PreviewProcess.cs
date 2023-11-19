using System.Collections.Generic;

namespace COM_WindApplication.gui
{
    // class PreviewProcess - main
    internal class PreviewProcess
    {
        public IEnumerable<PreviewFile> PreviewProceses { get; private set; } = new[]
        {
            new PreviewFile("Notepad++", $@"D:\Soft\Notepad++\notepad++.exe"),
            //new PreviewFile("Word", $@"F:\Games\ILYAsFolder\BarSU\LABS\4_course\EugineShapovich\VisualKa\VisualCLibSolutions\COM\COM_Application\COM_WindApplication\bin\Debug\doc\DefaultTemplate.docx"),
            //new PreviewProcess("Regedit", $@"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\regedit.exe"),
        };

    }
}
