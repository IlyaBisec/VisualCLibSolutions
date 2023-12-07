namespace COM_WindApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_COM = new System.Windows.Forms.TabControl();
            this.tbp_Main = new System.Windows.Forms.TabPage();
            this.lb_Excel = new System.Windows.Forms.Label();
            this.lb_Word = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.tbp_Word = new System.Windows.Forms.TabPage();
            this.pnl_Preview = new System.Windows.Forms.Panel();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.btn_CheckResult = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CreateDoc = new System.Windows.Forms.Button();
            this.tb_SenderName = new System.Windows.Forms.TextBox();
            this.lb_SenderName = new System.Windows.Forms.Label();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.tb_DepartmentName = new System.Windows.Forms.TextBox();
            this.lb_DepartmentName = new System.Windows.Forms.Label();
            this.tb_ProjectName = new System.Windows.Forms.TextBox();
            this.lb_ProjectName = new System.Windows.Forms.Label();
            this.tb_RecipientName = new System.Windows.Forms.TextBox();
            this.lb_RecipientName = new System.Windows.Forms.Label();
            this.tbp_Excel = new System.Windows.Forms.TabPage();
            this.pnl_PreviewExcel = new System.Windows.Forms.Panel();
            this.pnl_ExcelControls = new System.Windows.Forms.Panel();
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.lb_NameCountry = new System.Windows.Forms.Label();
            this.btn_CheckExcelResult = new System.Windows.Forms.Button();
            this.btn_ExitExelApp = new System.Windows.Forms.Button();
            this.tb_MonthTemperature = new System.Windows.Forms.TextBox();
            this.lb_MonthTemperature = new System.Windows.Forms.Label();
            this.lb_MonthName = new System.Windows.Forms.Label();
            this.lb_NameRegion = new System.Windows.Forms.Label();
            this.tb_NameRegion = new System.Windows.Forms.TextBox();
            this.tb_MonthName = new System.Windows.Forms.TextBox();
            this.cmb_NameRegion = new System.Windows.Forms.ComboBox();
            this.cmb_MonthName = new System.Windows.Forms.ComboBox();
            this.tb_NameCountry = new System.Windows.Forms.TextBox();
            this.cmb_NameCountry = new System.Windows.Forms.ComboBox();
            this.btn_TemperatureAverage = new System.Windows.Forms.Button();
            this.btn_RandomFill = new System.Windows.Forms.Button();
            this.tbp_Options = new System.Windows.Forms.TabPage();
            this.btn_PathToTxtCities = new System.Windows.Forms.Button();
            this.tb_PathToTxtCities = new System.Windows.Forms.TextBox();
            this.lb_PathToTxtCities = new System.Windows.Forms.Label();
            this.btn_DemoExcelTemplate = new System.Windows.Forms.Button();
            this.tb_DemoExcelTemplate = new System.Windows.Forms.TextBox();
            this.lb_DemoExcelTemplate = new System.Windows.Forms.Label();
            this.chekb_TurnOffComboboxDictionary = new System.Windows.Forms.CheckBox();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.btn_DemoTemplate = new System.Windows.Forms.Button();
            this.btn_NewDefFilePath = new System.Windows.Forms.Button();
            this.tb_DemoTemplate = new System.Windows.Forms.TextBox();
            this.lb_DemoTemplate = new System.Windows.Forms.Label();
            this.tb_NewDefFilePath = new System.Windows.Forms.TextBox();
            this.lb_NewDefFilePath = new System.Windows.Forms.Label();
            this.tb_TemplateDocPath = new System.Windows.Forms.TextBox();
            this.lb_TemplateDocPath = new System.Windows.Forms.Label();
            this.chekb_AdvancedSettings = new System.Windows.Forms.CheckBox();
            this.btn_TemplateDocPath = new System.Windows.Forms.Button();
            this.tbp_About = new System.Windows.Forms.TabPage();
            this.lb_About = new System.Windows.Forms.Label();
            this.lb_COMApp = new System.Windows.Forms.Label();
            this.chekb_ClearExcelFiledsAfterAddNote = new System.Windows.Forms.CheckBox();
            this.previewHandlerHost = new PreviewHandlers.PreviewHandlerHost();
            this.previreHandleHostExcel = new PreviewHandlers.PreviewHandlerHost();
            this.tab_COM.SuspendLayout();
            this.tbp_Main.SuspendLayout();
            this.tbp_Word.SuspendLayout();
            this.pnl_Preview.SuspendLayout();
            this.pnl_Controls.SuspendLayout();
            this.tbp_Excel.SuspendLayout();
            this.pnl_PreviewExcel.SuspendLayout();
            this.pnl_ExcelControls.SuspendLayout();
            this.tbp_Options.SuspendLayout();
            this.tbp_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_COM
            // 
            this.tab_COM.Controls.Add(this.tbp_Main);
            this.tab_COM.Controls.Add(this.tbp_Word);
            this.tab_COM.Controls.Add(this.tbp_Excel);
            this.tab_COM.Controls.Add(this.tbp_Options);
            this.tab_COM.Controls.Add(this.tbp_About);
            this.tab_COM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_COM.Location = new System.Drawing.Point(0, 0);
            this.tab_COM.Name = "tab_COM";
            this.tab_COM.SelectedIndex = 0;
            this.tab_COM.Size = new System.Drawing.Size(902, 397);
            this.tab_COM.TabIndex = 0;
            // 
            // tbp_Main
            // 
            this.tbp_Main.Controls.Add(this.lb_Excel);
            this.tbp_Main.Controls.Add(this.lb_Word);
            this.tbp_Main.Controls.Add(this.label2);
            this.tbp_Main.Controls.Add(this.lb_Welcome);
            this.tbp_Main.Location = new System.Drawing.Point(4, 22);
            this.tbp_Main.Name = "tbp_Main";
            this.tbp_Main.Size = new System.Drawing.Size(894, 364);
            this.tbp_Main.TabIndex = 4;
            this.tbp_Main.Text = "Welcome";
            this.tbp_Main.UseVisualStyleBackColor = true;
            // 
            // lb_Excel
            // 
            this.lb_Excel.AutoSize = true;
            this.lb_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Excel.Location = new System.Drawing.Point(8, 273);
            this.lb_Excel.Name = "lb_Excel";
            this.lb_Excel.Size = new System.Drawing.Size(740, 34);
            this.lb_Excel.TabIndex = 3;
            this.lb_Excel.Text = "Модуль Excel - составит для вас данные о погоде, не только зимой и летом, но и вы" +
    "считает среднее значеие.\r\nДа еще и в табличном виде! Нужно в Excel? И это по сил" +
    "ам! Как тебе такое Илон Маск?";
            // 
            // lb_Word
            // 
            this.lb_Word.AutoSize = true;
            this.lb_Word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Word.Location = new System.Drawing.Point(8, 165);
            this.lb_Word.Name = "lb_Word";
            this.lb_Word.Size = new System.Drawing.Size(855, 85);
            this.lb_Word.TabIndex = 2;
            this.lb_Word.Text = resources.GetString("lb_Word.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 102);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Welcome.Location = new System.Drawing.Point(332, 15);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(289, 24);
            this.lb_Welcome.TabIndex = 0;
            this.lb_Welcome.Text = "Welcome и Добро пожаловать!";
            // 
            // tbp_Word
            // 
            this.tbp_Word.Controls.Add(this.pnl_Preview);
            this.tbp_Word.Controls.Add(this.pnl_Controls);
            this.tbp_Word.Location = new System.Drawing.Point(4, 22);
            this.tbp_Word.Name = "tbp_Word";
            this.tbp_Word.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Word.Size = new System.Drawing.Size(894, 371);
            this.tbp_Word.TabIndex = 0;
            this.tbp_Word.Text = "Word";
            this.tbp_Word.UseVisualStyleBackColor = true;
            // 
            // pnl_Preview
            // 
            this.pnl_Preview.Controls.Add(this.previewHandlerHost);
            this.pnl_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Preview.Location = new System.Drawing.Point(177, 3);
            this.pnl_Preview.Name = "pnl_Preview";
            this.pnl_Preview.Size = new System.Drawing.Size(714, 365);
            this.pnl_Preview.TabIndex = 1;
            this.pnl_Preview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Preview_Paint);
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.btn_CheckResult);
            this.pnl_Controls.Controls.Add(this.btn_Exit);
            this.pnl_Controls.Controls.Add(this.btn_CreateDoc);
            this.pnl_Controls.Controls.Add(this.tb_SenderName);
            this.pnl_Controls.Controls.Add(this.lb_SenderName);
            this.pnl_Controls.Controls.Add(this.tb_CompanyName);
            this.pnl_Controls.Controls.Add(this.lb_CompanyName);
            this.pnl_Controls.Controls.Add(this.tb_DepartmentName);
            this.pnl_Controls.Controls.Add(this.lb_DepartmentName);
            this.pnl_Controls.Controls.Add(this.tb_ProjectName);
            this.pnl_Controls.Controls.Add(this.lb_ProjectName);
            this.pnl_Controls.Controls.Add(this.tb_RecipientName);
            this.pnl_Controls.Controls.Add(this.lb_RecipientName);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Controls.Location = new System.Drawing.Point(3, 3);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(174, 365);
            this.pnl_Controls.TabIndex = 0;
            // 
            // btn_CheckResult
            // 
            this.btn_CheckResult.Location = new System.Drawing.Point(9, 279);
            this.btn_CheckResult.Name = "btn_CheckResult";
            this.btn_CheckResult.Size = new System.Drawing.Size(148, 30);
            this.btn_CheckResult.TabIndex = 12;
            this.btn_CheckResult.Text = "Проверить результат";
            this.btn_CheckResult.UseVisualStyleBackColor = true;
            this.btn_CheckResult.Click += new System.EventHandler(this.btn_CheckResult_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(9, 322);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 30);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Выйти";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CreateDoc
            // 
            this.btn_CreateDoc.Location = new System.Drawing.Point(9, 237);
            this.btn_CreateDoc.Name = "btn_CreateDoc";
            this.btn_CreateDoc.Size = new System.Drawing.Size(148, 30);
            this.btn_CreateDoc.TabIndex = 10;
            this.btn_CreateDoc.Text = "Создать документ";
            this.btn_CreateDoc.UseVisualStyleBackColor = true;
            this.btn_CreateDoc.Click += new System.EventHandler(this.btn_CreateDoc_Click);
            // 
            // tb_SenderName
            // 
            this.tb_SenderName.Location = new System.Drawing.Point(9, 211);
            this.tb_SenderName.Name = "tb_SenderName";
            this.tb_SenderName.Size = new System.Drawing.Size(148, 20);
            this.tb_SenderName.TabIndex = 9;
            // 
            // lb_SenderName
            // 
            this.lb_SenderName.AutoSize = true;
            this.lb_SenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SenderName.Location = new System.Drawing.Point(6, 193);
            this.lb_SenderName.Name = "lb_SenderName";
            this.lb_SenderName.Size = new System.Drawing.Size(119, 15);
            this.lb_SenderName.TabIndex = 8;
            this.lb_SenderName.Text = "ФИО отправителя:";
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Location = new System.Drawing.Point(9, 163);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(148, 20);
            this.tb_CompanyName.TabIndex = 7;
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CompanyName.Location = new System.Drawing.Point(6, 145);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(127, 15);
            this.lb_CompanyName.TabIndex = 6;
            this.lb_CompanyName.Text = "Название компании:";
            // 
            // tb_DepartmentName
            // 
            this.tb_DepartmentName.Location = new System.Drawing.Point(9, 117);
            this.tb_DepartmentName.Name = "tb_DepartmentName";
            this.tb_DepartmentName.Size = new System.Drawing.Size(148, 20);
            this.tb_DepartmentName.TabIndex = 5;
            // 
            // lb_DepartmentName
            // 
            this.lb_DepartmentName.AutoSize = true;
            this.lb_DepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DepartmentName.Location = new System.Drawing.Point(6, 99);
            this.lb_DepartmentName.Name = "lb_DepartmentName";
            this.lb_DepartmentName.Size = new System.Drawing.Size(112, 15);
            this.lb_DepartmentName.TabIndex = 4;
            this.lb_DepartmentName.Text = "Название отдела:";
            // 
            // tb_ProjectName
            // 
            this.tb_ProjectName.Location = new System.Drawing.Point(9, 68);
            this.tb_ProjectName.Name = "tb_ProjectName";
            this.tb_ProjectName.Size = new System.Drawing.Size(148, 20);
            this.tb_ProjectName.TabIndex = 3;
            // 
            // lb_ProjectName
            // 
            this.lb_ProjectName.AutoSize = true;
            this.lb_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ProjectName.Location = new System.Drawing.Point(6, 50);
            this.lb_ProjectName.Name = "lb_ProjectName";
            this.lb_ProjectName.Size = new System.Drawing.Size(118, 15);
            this.lb_ProjectName.TabIndex = 2;
            this.lb_ProjectName.Text = "Название проекта:";
            // 
            // tb_RecipientName
            // 
            this.tb_RecipientName.Location = new System.Drawing.Point(9, 22);
            this.tb_RecipientName.Name = "tb_RecipientName";
            this.tb_RecipientName.Size = new System.Drawing.Size(148, 20);
            this.tb_RecipientName.TabIndex = 1;
            // 
            // lb_RecipientName
            // 
            this.lb_RecipientName.AutoSize = true;
            this.lb_RecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_RecipientName.Location = new System.Drawing.Point(6, 4);
            this.lb_RecipientName.Name = "lb_RecipientName";
            this.lb_RecipientName.Size = new System.Drawing.Size(109, 15);
            this.lb_RecipientName.TabIndex = 0;
            this.lb_RecipientName.Text = "ФИО получателя:";
            // 
            // tbp_Excel
            // 
            this.tbp_Excel.Controls.Add(this.pnl_PreviewExcel);
            this.tbp_Excel.Controls.Add(this.pnl_ExcelControls);
            this.tbp_Excel.Controls.Add(this.btn_RandomFill);
            this.tbp_Excel.Location = new System.Drawing.Point(4, 22);
            this.tbp_Excel.Name = "tbp_Excel";
            this.tbp_Excel.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Excel.Size = new System.Drawing.Size(894, 371);
            this.tbp_Excel.TabIndex = 1;
            this.tbp_Excel.Text = "Excel";
            this.tbp_Excel.UseVisualStyleBackColor = true;
            // 
            // pnl_PreviewExcel
            // 
            this.pnl_PreviewExcel.Controls.Add(this.previreHandleHostExcel);
            this.pnl_PreviewExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PreviewExcel.Location = new System.Drawing.Point(169, 3);
            this.pnl_PreviewExcel.Name = "pnl_PreviewExcel";
            this.pnl_PreviewExcel.Size = new System.Drawing.Size(722, 365);
            this.pnl_PreviewExcel.TabIndex = 2;
            this.pnl_PreviewExcel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_PreviewExcel_Paint);
            // 
            // pnl_ExcelControls
            // 
            this.pnl_ExcelControls.Controls.Add(this.btn_AddNote);
            this.pnl_ExcelControls.Controls.Add(this.lb_NameCountry);
            this.pnl_ExcelControls.Controls.Add(this.btn_CheckExcelResult);
            this.pnl_ExcelControls.Controls.Add(this.btn_ExitExelApp);
            this.pnl_ExcelControls.Controls.Add(this.tb_MonthTemperature);
            this.pnl_ExcelControls.Controls.Add(this.lb_MonthTemperature);
            this.pnl_ExcelControls.Controls.Add(this.lb_MonthName);
            this.pnl_ExcelControls.Controls.Add(this.lb_NameRegion);
            this.pnl_ExcelControls.Controls.Add(this.tb_NameRegion);
            this.pnl_ExcelControls.Controls.Add(this.tb_MonthName);
            this.pnl_ExcelControls.Controls.Add(this.cmb_NameRegion);
            this.pnl_ExcelControls.Controls.Add(this.cmb_MonthName);
            this.pnl_ExcelControls.Controls.Add(this.tb_NameCountry);
            this.pnl_ExcelControls.Controls.Add(this.cmb_NameCountry);
            this.pnl_ExcelControls.Controls.Add(this.btn_TemperatureAverage);
            this.pnl_ExcelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ExcelControls.Location = new System.Drawing.Point(3, 3);
            this.pnl_ExcelControls.Name = "pnl_ExcelControls";
            this.pnl_ExcelControls.Size = new System.Drawing.Size(166, 365);
            this.pnl_ExcelControls.TabIndex = 0;
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.Location = new System.Drawing.Point(3, 200);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(151, 30);
            this.btn_AddNote.TabIndex = 29;
            this.btn_AddNote.Text = "Добавить запись";
            this.btn_AddNote.UseVisualStyleBackColor = true;
            this.btn_AddNote.Click += new System.EventHandler(this.btn_AddNote_Click);
            // 
            // lb_NameCountry
            // 
            this.lb_NameCountry.AutoSize = true;
            this.lb_NameCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NameCountry.Location = new System.Drawing.Point(5, 9);
            this.lb_NameCountry.Name = "lb_NameCountry";
            this.lb_NameCountry.Size = new System.Drawing.Size(113, 15);
            this.lb_NameCountry.TabIndex = 26;
            this.lb_NameCountry.Text = "Название страны:";
            // 
            // btn_CheckExcelResult
            // 
            this.btn_CheckExcelResult.Location = new System.Drawing.Point(3, 241);
            this.btn_CheckExcelResult.Name = "btn_CheckExcelResult";
            this.btn_CheckExcelResult.Size = new System.Drawing.Size(151, 30);
            this.btn_CheckExcelResult.TabIndex = 21;
            this.btn_CheckExcelResult.Text = "Проверить результат";
            this.btn_CheckExcelResult.UseVisualStyleBackColor = true;
            this.btn_CheckExcelResult.Click += new System.EventHandler(this.btn_CheckExcelResult_Click);
            // 
            // btn_ExitExelApp
            // 
            this.btn_ExitExelApp.Location = new System.Drawing.Point(3, 322);
            this.btn_ExitExelApp.Name = "btn_ExitExelApp";
            this.btn_ExitExelApp.Size = new System.Drawing.Size(151, 30);
            this.btn_ExitExelApp.TabIndex = 20;
            this.btn_ExitExelApp.Text = "Выйти";
            this.btn_ExitExelApp.UseVisualStyleBackColor = true;
            this.btn_ExitExelApp.Click += new System.EventHandler(this.btn_ExitExelApp_Click);
            // 
            // tb_MonthTemperature
            // 
            this.tb_MonthTemperature.Location = new System.Drawing.Point(3, 174);
            this.tb_MonthTemperature.Name = "tb_MonthTemperature";
            this.tb_MonthTemperature.Size = new System.Drawing.Size(153, 20);
            this.tb_MonthTemperature.TabIndex = 18;
            // 
            // lb_MonthTemperature
            // 
            this.lb_MonthTemperature.AutoSize = true;
            this.lb_MonthTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MonthTemperature.Location = new System.Drawing.Point(4, 156);
            this.lb_MonthTemperature.Name = "lb_MonthTemperature";
            this.lb_MonthTemperature.Size = new System.Drawing.Size(133, 15);
            this.lb_MonthTemperature.TabIndex = 17;
            this.lb_MonthTemperature.Text = "Температура месяца:";
            // 
            // lb_MonthName
            // 
            this.lb_MonthName.AutoSize = true;
            this.lb_MonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MonthName.Location = new System.Drawing.Point(2, 104);
            this.lb_MonthName.Name = "lb_MonthName";
            this.lb_MonthName.Size = new System.Drawing.Size(113, 15);
            this.lb_MonthName.TabIndex = 15;
            this.lb_MonthName.Text = "Название месяца:";
            // 
            // lb_NameRegion
            // 
            this.lb_NameRegion.AutoSize = true;
            this.lb_NameRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NameRegion.Location = new System.Drawing.Point(7, 54);
            this.lb_NameRegion.Name = "lb_NameRegion";
            this.lb_NameRegion.Size = new System.Drawing.Size(117, 15);
            this.lb_NameRegion.TabIndex = 13;
            this.lb_NameRegion.Text = "Название региона:";
            // 
            // tb_NameRegion
            // 
            this.tb_NameRegion.Location = new System.Drawing.Point(5, 81);
            this.tb_NameRegion.Name = "tb_NameRegion";
            this.tb_NameRegion.Size = new System.Drawing.Size(151, 20);
            this.tb_NameRegion.TabIndex = 14;
            this.tb_NameRegion.Visible = false;
            // 
            // tb_MonthName
            // 
            this.tb_MonthName.Location = new System.Drawing.Point(5, 122);
            this.tb_MonthName.Name = "tb_MonthName";
            this.tb_MonthName.Size = new System.Drawing.Size(151, 20);
            this.tb_MonthName.TabIndex = 16;
            this.tb_MonthName.Visible = false;
            // 
            // cmb_NameRegion
            // 
            this.cmb_NameRegion.FormattingEnabled = true;
            this.cmb_NameRegion.Location = new System.Drawing.Point(3, 80);
            this.cmb_NameRegion.Name = "cmb_NameRegion";
            this.cmb_NameRegion.Size = new System.Drawing.Size(151, 21);
            this.cmb_NameRegion.TabIndex = 23;
            // 
            // cmb_MonthName
            // 
            this.cmb_MonthName.FormattingEnabled = true;
            this.cmb_MonthName.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cmb_MonthName.Location = new System.Drawing.Point(5, 122);
            this.cmb_MonthName.Name = "cmb_MonthName";
            this.cmb_MonthName.Size = new System.Drawing.Size(151, 21);
            this.cmb_MonthName.TabIndex = 24;
            // 
            // tb_NameCountry
            // 
            this.tb_NameCountry.Location = new System.Drawing.Point(5, 32);
            this.tb_NameCountry.Name = "tb_NameCountry";
            this.tb_NameCountry.Size = new System.Drawing.Size(151, 20);
            this.tb_NameCountry.TabIndex = 28;
            this.tb_NameCountry.Visible = false;
            // 
            // cmb_NameCountry
            // 
            this.cmb_NameCountry.FormattingEnabled = true;
            this.cmb_NameCountry.Location = new System.Drawing.Point(5, 31);
            this.cmb_NameCountry.Name = "cmb_NameCountry";
            this.cmb_NameCountry.Size = new System.Drawing.Size(151, 21);
            this.cmb_NameCountry.TabIndex = 27;
            this.cmb_NameCountry.SelectedIndexChanged += new System.EventHandler(this.cmb_NameCountry_SelectedIndexChanged);
            // 
            // btn_TemperatureAverage
            // 
            this.btn_TemperatureAverage.Location = new System.Drawing.Point(3, 282);
            this.btn_TemperatureAverage.Name = "btn_TemperatureAverage";
            this.btn_TemperatureAverage.Size = new System.Drawing.Size(151, 30);
            this.btn_TemperatureAverage.TabIndex = 19;
            this.btn_TemperatureAverage.Text = "Средняя температура";
            this.btn_TemperatureAverage.UseVisualStyleBackColor = true;
            this.btn_TemperatureAverage.Visible = false;
            // 
            // btn_RandomFill
            // 
            this.btn_RandomFill.Location = new System.Drawing.Point(6, 347);
            this.btn_RandomFill.Name = "btn_RandomFill";
            this.btn_RandomFill.Size = new System.Drawing.Size(151, 30);
            this.btn_RandomFill.TabIndex = 25;
            this.btn_RandomFill.Text = "Случайное заполнение";
            this.btn_RandomFill.UseVisualStyleBackColor = true;
            this.btn_RandomFill.Visible = false;
            // 
            // tbp_Options
            // 
            this.tbp_Options.Controls.Add(this.chekb_ClearExcelFiledsAfterAddNote);
            this.tbp_Options.Controls.Add(this.btn_PathToTxtCities);
            this.tbp_Options.Controls.Add(this.tb_PathToTxtCities);
            this.tbp_Options.Controls.Add(this.lb_PathToTxtCities);
            this.tbp_Options.Controls.Add(this.btn_DemoExcelTemplate);
            this.tbp_Options.Controls.Add(this.tb_DemoExcelTemplate);
            this.tbp_Options.Controls.Add(this.lb_DemoExcelTemplate);
            this.tbp_Options.Controls.Add(this.chekb_TurnOffComboboxDictionary);
            this.tbp_Options.Controls.Add(this.btn_SaveSettings);
            this.tbp_Options.Controls.Add(this.btn_DemoTemplate);
            this.tbp_Options.Controls.Add(this.btn_NewDefFilePath);
            this.tbp_Options.Controls.Add(this.tb_DemoTemplate);
            this.tbp_Options.Controls.Add(this.lb_DemoTemplate);
            this.tbp_Options.Controls.Add(this.tb_NewDefFilePath);
            this.tbp_Options.Controls.Add(this.lb_NewDefFilePath);
            this.tbp_Options.Controls.Add(this.tb_TemplateDocPath);
            this.tbp_Options.Controls.Add(this.lb_TemplateDocPath);
            this.tbp_Options.Controls.Add(this.chekb_AdvancedSettings);
            this.tbp_Options.Controls.Add(this.btn_TemplateDocPath);
            this.tbp_Options.Location = new System.Drawing.Point(4, 22);
            this.tbp_Options.Name = "tbp_Options";
            this.tbp_Options.Size = new System.Drawing.Size(894, 364);
            this.tbp_Options.TabIndex = 3;
            this.tbp_Options.Text = "Настройки";
            this.tbp_Options.UseVisualStyleBackColor = true;
            // 
            // btn_PathToTxtCities
            // 
            this.btn_PathToTxtCities.Location = new System.Drawing.Point(499, 249);
            this.btn_PathToTxtCities.Name = "btn_PathToTxtCities";
            this.btn_PathToTxtCities.Size = new System.Drawing.Size(39, 20);
            this.btn_PathToTxtCities.TabIndex = 17;
            this.btn_PathToTxtCities.Text = "...";
            this.btn_PathToTxtCities.UseVisualStyleBackColor = true;
            this.btn_PathToTxtCities.Visible = false;
            this.btn_PathToTxtCities.Click += new System.EventHandler(this.btn_PathToTxtCities_Click);
            // 
            // tb_PathToTxtCities
            // 
            this.tb_PathToTxtCities.Location = new System.Drawing.Point(11, 249);
            this.tb_PathToTxtCities.Name = "tb_PathToTxtCities";
            this.tb_PathToTxtCities.Size = new System.Drawing.Size(482, 20);
            this.tb_PathToTxtCities.TabIndex = 16;
            this.tb_PathToTxtCities.Visible = false;
            // 
            // lb_PathToTxtCities
            // 
            this.lb_PathToTxtCities.AutoSize = true;
            this.lb_PathToTxtCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_PathToTxtCities.Location = new System.Drawing.Point(8, 223);
            this.lb_PathToTxtCities.Name = "lb_PathToTxtCities";
            this.lb_PathToTxtCities.Size = new System.Drawing.Size(256, 17);
            this.lb_PathToTxtCities.TabIndex = 15;
            this.lb_PathToTxtCities.Text = "Путь к текстовому файлу с городами:";
            this.lb_PathToTxtCities.Visible = false;
            // 
            // btn_DemoExcelTemplate
            // 
            this.btn_DemoExcelTemplate.Location = new System.Drawing.Point(499, 187);
            this.btn_DemoExcelTemplate.Name = "btn_DemoExcelTemplate";
            this.btn_DemoExcelTemplate.Size = new System.Drawing.Size(39, 20);
            this.btn_DemoExcelTemplate.TabIndex = 14;
            this.btn_DemoExcelTemplate.Text = "...";
            this.btn_DemoExcelTemplate.UseVisualStyleBackColor = true;
            this.btn_DemoExcelTemplate.Visible = false;
            this.btn_DemoExcelTemplate.Click += new System.EventHandler(this.btn_DemoExcelTemplate_Click);
            // 
            // tb_DemoExcelTemplate
            // 
            this.tb_DemoExcelTemplate.Location = new System.Drawing.Point(11, 187);
            this.tb_DemoExcelTemplate.Name = "tb_DemoExcelTemplate";
            this.tb_DemoExcelTemplate.Size = new System.Drawing.Size(482, 20);
            this.tb_DemoExcelTemplate.TabIndex = 13;
            this.tb_DemoExcelTemplate.Visible = false;
            // 
            // lb_DemoExcelTemplate
            // 
            this.lb_DemoExcelTemplate.AutoSize = true;
            this.lb_DemoExcelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DemoExcelTemplate.Location = new System.Drawing.Point(8, 161);
            this.lb_DemoExcelTemplate.Name = "lb_DemoExcelTemplate";
            this.lb_DemoExcelTemplate.Size = new System.Drawing.Size(392, 17);
            this.lb_DemoExcelTemplate.TabIndex = 12;
            this.lb_DemoExcelTemplate.Text = "Путь для демонстрационного Excel шаблона приложения:";
            this.lb_DemoExcelTemplate.Visible = false;
            // 
            // chekb_TurnOffComboboxDictionary
            // 
            this.chekb_TurnOffComboboxDictionary.AutoSize = true;
            this.chekb_TurnOffComboboxDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chekb_TurnOffComboboxDictionary.Location = new System.Drawing.Point(633, 80);
            this.chekb_TurnOffComboboxDictionary.Name = "chekb_TurnOffComboboxDictionary";
            this.chekb_TurnOffComboboxDictionary.Size = new System.Drawing.Size(166, 21);
            this.chekb_TurnOffComboboxDictionary.TabIndex = 11;
            this.chekb_TurnOffComboboxDictionary.Text = "Ручной ввод г. и мес.";
            this.chekb_TurnOffComboboxDictionary.UseVisualStyleBackColor = true;
            this.chekb_TurnOffComboboxDictionary.CheckedChanged += new System.EventHandler(this.chekb_TurnOffComboboxDictionary_CheckedChanged);
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(754, 329);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(137, 33);
            this.btn_SaveSettings.TabIndex = 10;
            this.btn_SaveSettings.Tag = "";
            this.btn_SaveSettings.Text = "Сохранить изменения";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // btn_DemoTemplate
            // 
            this.btn_DemoTemplate.Location = new System.Drawing.Point(499, 132);
            this.btn_DemoTemplate.Name = "btn_DemoTemplate";
            this.btn_DemoTemplate.Size = new System.Drawing.Size(39, 20);
            this.btn_DemoTemplate.TabIndex = 9;
            this.btn_DemoTemplate.Text = "...";
            this.btn_DemoTemplate.UseVisualStyleBackColor = true;
            this.btn_DemoTemplate.Visible = false;
            this.btn_DemoTemplate.Click += new System.EventHandler(this.btn_DemoTemplate_Click);
            // 
            // btn_NewDefFilePath
            // 
            this.btn_NewDefFilePath.Location = new System.Drawing.Point(499, 81);
            this.btn_NewDefFilePath.Name = "btn_NewDefFilePath";
            this.btn_NewDefFilePath.Size = new System.Drawing.Size(39, 20);
            this.btn_NewDefFilePath.TabIndex = 8;
            this.btn_NewDefFilePath.Text = "...";
            this.btn_NewDefFilePath.UseVisualStyleBackColor = true;
            this.btn_NewDefFilePath.Click += new System.EventHandler(this.btn_NewDefFilePath_Click);
            // 
            // tb_DemoTemplate
            // 
            this.tb_DemoTemplate.Location = new System.Drawing.Point(11, 132);
            this.tb_DemoTemplate.Name = "tb_DemoTemplate";
            this.tb_DemoTemplate.Size = new System.Drawing.Size(482, 20);
            this.tb_DemoTemplate.TabIndex = 7;
            this.tb_DemoTemplate.Visible = false;
            // 
            // lb_DemoTemplate
            // 
            this.lb_DemoTemplate.AutoSize = true;
            this.lb_DemoTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DemoTemplate.Location = new System.Drawing.Point(8, 106);
            this.lb_DemoTemplate.Name = "lb_DemoTemplate";
            this.lb_DemoTemplate.Size = new System.Drawing.Size(393, 17);
            this.lb_DemoTemplate.TabIndex = 6;
            this.lb_DemoTemplate.Text = "Путь для демонстрационного Word шаблона приложения:";
            this.lb_DemoTemplate.Visible = false;
            // 
            // tb_NewDefFilePath
            // 
            this.tb_NewDefFilePath.Location = new System.Drawing.Point(11, 81);
            this.tb_NewDefFilePath.Name = "tb_NewDefFilePath";
            this.tb_NewDefFilePath.Size = new System.Drawing.Size(482, 20);
            this.tb_NewDefFilePath.TabIndex = 5;
            // 
            // lb_NewDefFilePath
            // 
            this.lb_NewDefFilePath.AutoSize = true;
            this.lb_NewDefFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NewDefFilePath.Location = new System.Drawing.Point(8, 55);
            this.lb_NewDefFilePath.Name = "lb_NewDefFilePath";
            this.lb_NewDefFilePath.Size = new System.Drawing.Size(195, 17);
            this.lb_NewDefFilePath.TabIndex = 4;
            this.lb_NewDefFilePath.Text = "Путь для новых документов:";
            // 
            // tb_TemplateDocPath
            // 
            this.tb_TemplateDocPath.Location = new System.Drawing.Point(11, 32);
            this.tb_TemplateDocPath.Name = "tb_TemplateDocPath";
            this.tb_TemplateDocPath.Size = new System.Drawing.Size(482, 20);
            this.tb_TemplateDocPath.TabIndex = 3;
            // 
            // lb_TemplateDocPath
            // 
            this.lb_TemplateDocPath.AutoSize = true;
            this.lb_TemplateDocPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TemplateDocPath.Location = new System.Drawing.Point(8, 10);
            this.lb_TemplateDocPath.Name = "lb_TemplateDocPath";
            this.lb_TemplateDocPath.Size = new System.Drawing.Size(344, 17);
            this.lb_TemplateDocPath.TabIndex = 2;
            this.lb_TemplateDocPath.Text = "Путь для шаблона Word документа по умолчанию:";
            // 
            // chekb_AdvancedSettings
            // 
            this.chekb_AdvancedSettings.AutoSize = true;
            this.chekb_AdvancedSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chekb_AdvancedSettings.Location = new System.Drawing.Point(633, 31);
            this.chekb_AdvancedSettings.Name = "chekb_AdvancedSettings";
            this.chekb_AdvancedSettings.Size = new System.Drawing.Size(189, 21);
            this.chekb_AdvancedSettings.TabIndex = 1;
            this.chekb_AdvancedSettings.Text = "Продвинутые настройки";
            this.chekb_AdvancedSettings.UseVisualStyleBackColor = true;
            this.chekb_AdvancedSettings.CheckedChanged += new System.EventHandler(this.chekb_AdvancedSettings_CheckedChanged);
            // 
            // btn_TemplateDocPath
            // 
            this.btn_TemplateDocPath.Location = new System.Drawing.Point(499, 32);
            this.btn_TemplateDocPath.Name = "btn_TemplateDocPath";
            this.btn_TemplateDocPath.Size = new System.Drawing.Size(39, 20);
            this.btn_TemplateDocPath.TabIndex = 0;
            this.btn_TemplateDocPath.Text = "...";
            this.btn_TemplateDocPath.UseVisualStyleBackColor = true;
            this.btn_TemplateDocPath.Click += new System.EventHandler(this.btn_TemplateDocPath_Click);
            // 
            // tbp_About
            // 
            this.tbp_About.Controls.Add(this.lb_About);
            this.tbp_About.Controls.Add(this.lb_COMApp);
            this.tbp_About.Location = new System.Drawing.Point(4, 22);
            this.tbp_About.Name = "tbp_About";
            this.tbp_About.Size = new System.Drawing.Size(894, 364);
            this.tbp_About.TabIndex = 2;
            this.tbp_About.Text = "Контакты";
            this.tbp_About.UseVisualStyleBackColor = true;
            // 
            // lb_About
            // 
            this.lb_About.AutoSize = true;
            this.lb_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_About.Location = new System.Drawing.Point(8, 46);
            this.lb_About.Name = "lb_About";
            this.lb_About.Size = new System.Drawing.Size(863, 153);
            this.lb_About.TabIndex = 3;
            this.lb_About.Text = resources.GetString("lb_About.Text");
            // 
            // lb_COMApp
            // 
            this.lb_COMApp.AutoSize = true;
            this.lb_COMApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_COMApp.Location = new System.Drawing.Point(381, 11);
            this.lb_COMApp.Name = "lb_COMApp";
            this.lb_COMApp.Size = new System.Drawing.Size(152, 24);
            this.lb_COMApp.TabIndex = 2;
            this.lb_COMApp.Text = "COM Application";
            // 
            // chekb_ClearExcelFiledsAfterAddNote
            // 
            this.chekb_ClearExcelFiledsAfterAddNote.AutoSize = true;
            this.chekb_ClearExcelFiledsAfterAddNote.Checked = true;
            this.chekb_ClearExcelFiledsAfterAddNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chekb_ClearExcelFiledsAfterAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chekb_ClearExcelFiledsAfterAddNote.Location = new System.Drawing.Point(633, 122);
            this.chekb_ClearExcelFiledsAfterAddNote.Name = "chekb_ClearExcelFiledsAfterAddNote";
            this.chekb_ClearExcelFiledsAfterAddNote.Size = new System.Drawing.Size(206, 38);
            this.chekb_ClearExcelFiledsAfterAddNote.TabIndex = 18;
            this.chekb_ClearExcelFiledsAfterAddNote.Text = "Очистить поля Excel после\r\nдобавления";
            this.chekb_ClearExcelFiledsAfterAddNote.UseVisualStyleBackColor = true;
            this.chekb_ClearExcelFiledsAfterAddNote.Visible = false;
            this.chekb_ClearExcelFiledsAfterAddNote.CheckedChanged += new System.EventHandler(this.chekb_ClearExcelFiledsAfterAddNote_CheckedChanged);
            // 
            // previewHandlerHost
            // 
            this.previewHandlerHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewHandlerHost.Location = new System.Drawing.Point(0, 0);
            this.previewHandlerHost.Name = "previewHandlerHost";
            this.previewHandlerHost.Size = new System.Drawing.Size(714, 365);
            this.previewHandlerHost.TabIndex = 0;
            // 
            // previreHandleHostExcel
            // 
            this.previreHandleHostExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previreHandleHostExcel.Location = new System.Drawing.Point(0, 0);
            this.previreHandleHostExcel.Name = "previreHandleHostExcel";
            this.previreHandleHostExcel.Size = new System.Drawing.Size(722, 365);
            this.previreHandleHostExcel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 397);
            this.Controls.Add(this.tab_COM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "COM Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_COM.ResumeLayout(false);
            this.tbp_Main.ResumeLayout(false);
            this.tbp_Main.PerformLayout();
            this.tbp_Word.ResumeLayout(false);
            this.pnl_Preview.ResumeLayout(false);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.tbp_Excel.ResumeLayout(false);
            this.pnl_PreviewExcel.ResumeLayout(false);
            this.pnl_ExcelControls.ResumeLayout(false);
            this.pnl_ExcelControls.PerformLayout();
            this.tbp_Options.ResumeLayout(false);
            this.tbp_Options.PerformLayout();
            this.tbp_About.ResumeLayout(false);
            this.tbp_About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_COM;
        private System.Windows.Forms.TabPage tbp_Word;
        private System.Windows.Forms.TabPage tbp_Excel;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.Label lb_CompanyName;
        private System.Windows.Forms.TextBox tb_DepartmentName;
        private System.Windows.Forms.Label lb_DepartmentName;
        private System.Windows.Forms.TextBox tb_ProjectName;
        private System.Windows.Forms.Label lb_ProjectName;
        private System.Windows.Forms.TextBox tb_RecipientName;
        private System.Windows.Forms.Label lb_RecipientName;
        private System.Windows.Forms.TextBox tb_SenderName;
        private System.Windows.Forms.Label lb_SenderName;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_CreateDoc;
        private System.Windows.Forms.TabPage tbp_About;
        private System.Windows.Forms.TabPage tbp_Options;
        private PreviewHandlers.PreviewHandlerHost previewHandlerHost;
        private System.Windows.Forms.TabPage tbp_Main;
        private System.Windows.Forms.Button btn_CheckResult;
        private System.Windows.Forms.Label lb_Excel;
        private System.Windows.Forms.Label lb_Word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label lb_About;
        private System.Windows.Forms.Label lb_COMApp;
        private System.Windows.Forms.Label lb_TemplateDocPath;
        private System.Windows.Forms.CheckBox chekb_AdvancedSettings;
        private System.Windows.Forms.Button btn_TemplateDocPath;
        private System.Windows.Forms.TextBox tb_DemoTemplate;
        private System.Windows.Forms.Label lb_DemoTemplate;
        private System.Windows.Forms.TextBox tb_NewDefFilePath;
        private System.Windows.Forms.Label lb_NewDefFilePath;
        private System.Windows.Forms.TextBox tb_TemplateDocPath;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.Button btn_DemoTemplate;
        private System.Windows.Forms.Button btn_NewDefFilePath;
        private System.Windows.Forms.CheckBox chekb_TurnOffComboboxDictionary;
        private System.Windows.Forms.Panel pnl_ExcelControls;
        private System.Windows.Forms.Button btn_CheckExcelResult;
        private System.Windows.Forms.Button btn_ExitExelApp;
        private System.Windows.Forms.Button btn_TemperatureAverage;
        private System.Windows.Forms.TextBox tb_MonthTemperature;
        private System.Windows.Forms.Label lb_MonthTemperature;
        private System.Windows.Forms.TextBox tb_MonthName;
        private System.Windows.Forms.Label lb_MonthName;
        private System.Windows.Forms.TextBox tb_NameRegion;
        private System.Windows.Forms.Label lb_NameRegion;
        private System.Windows.Forms.ComboBox cmb_MonthName;
        private System.Windows.Forms.ComboBox cmb_NameRegion;
        private System.Windows.Forms.Button btn_RandomFill;
        private System.Windows.Forms.Button btn_DemoExcelTemplate;
        private System.Windows.Forms.TextBox tb_DemoExcelTemplate;
        private System.Windows.Forms.Label lb_DemoExcelTemplate;
        private PreviewHandlers.PreviewHandlerHost previreHandleHostExcel;
        private System.Windows.Forms.Panel pnl_PreviewExcel;
        private System.Windows.Forms.Panel pnl_Preview;
        private System.Windows.Forms.Button btn_PathToTxtCities;
        private System.Windows.Forms.TextBox tb_PathToTxtCities;
        private System.Windows.Forms.Label lb_PathToTxtCities;
        private System.Windows.Forms.TextBox tb_NameCountry;
        private System.Windows.Forms.ComboBox cmb_NameCountry;
        private System.Windows.Forms.Label lb_NameCountry;
        private System.Windows.Forms.Button btn_AddNote;
        private System.Windows.Forms.CheckBox chekb_ClearExcelFiledsAfterAddNote;
    }
}

