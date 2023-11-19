namespace COM_WindApplication.gui
{
    internal class PreviewFile
    {
        public PreviewFile(string appName, string pathName)
        {
            path = pathName;
            applicationName = appName;
        }
        public string path { get; set; }
        public string applicationName { get; set; }
    }
}
