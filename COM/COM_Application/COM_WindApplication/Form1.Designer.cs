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
            this.tbp_Word = new System.Windows.Forms.TabPage();
            this.pnl_Preview = new System.Windows.Forms.Panel();
            this.pnl_Controls = new System.Windows.Forms.Panel();
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
            this.tbp_Options = new System.Windows.Forms.TabPage();
            this.tbp_About = new System.Windows.Forms.TabPage();
            this.previewHandlerHost = new PreviewHandlers.PreviewHandlerHost();
            this.btn_CheckResult = new System.Windows.Forms.Button();
            this.tab_COM.SuspendLayout();
            this.tbp_Word.SuspendLayout();
            this.pnl_Preview.SuspendLayout();
            this.pnl_Controls.SuspendLayout();
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
            this.tab_COM.Size = new System.Drawing.Size(902, 396);
            this.tab_COM.TabIndex = 0;
            // 
            // tbp_Main
            // 
            this.tbp_Main.Location = new System.Drawing.Point(4, 22);
            this.tbp_Main.Name = "tbp_Main";
            this.tbp_Main.Size = new System.Drawing.Size(894, 345);
            this.tbp_Main.TabIndex = 4;
            this.tbp_Main.Text = "Welcome";
            this.tbp_Main.UseVisualStyleBackColor = true;
            // 
            // tbp_Word
            // 
            this.tbp_Word.Controls.Add(this.pnl_Preview);
            this.tbp_Word.Controls.Add(this.pnl_Controls);
            this.tbp_Word.Location = new System.Drawing.Point(4, 22);
            this.tbp_Word.Name = "tbp_Word";
            this.tbp_Word.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Word.Size = new System.Drawing.Size(894, 370);
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
            this.pnl_Preview.Size = new System.Drawing.Size(714, 364);
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
            this.pnl_Controls.Size = new System.Drawing.Size(174, 364);
            this.pnl_Controls.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(9, 322);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 30);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CreateDoc
            // 
            this.btn_CreateDoc.Location = new System.Drawing.Point(9, 237);
            this.btn_CreateDoc.Name = "btn_CreateDoc";
            this.btn_CreateDoc.Size = new System.Drawing.Size(148, 30);
            this.btn_CreateDoc.TabIndex = 10;
            this.btn_CreateDoc.Text = "Create document";
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
            this.lb_SenderName.Size = new System.Drawing.Size(85, 15);
            this.lb_SenderName.TabIndex = 8;
            this.lb_SenderName.Text = "Sender name:";
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
            this.lb_CompanyName.Size = new System.Drawing.Size(97, 15);
            this.lb_CompanyName.TabIndex = 6;
            this.lb_CompanyName.Text = "Company name:";
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
            this.lb_DepartmentName.Size = new System.Drawing.Size(110, 15);
            this.lb_DepartmentName.TabIndex = 4;
            this.lb_DepartmentName.Text = "Department name:";
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
            this.lb_ProjectName.Size = new System.Drawing.Size(83, 15);
            this.lb_ProjectName.TabIndex = 2;
            this.lb_ProjectName.Text = "Project name:";
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
            this.lb_RecipientName.Size = new System.Drawing.Size(97, 15);
            this.lb_RecipientName.TabIndex = 0;
            this.lb_RecipientName.Text = "Recipient name:";
            // 
            // tbp_Excel
            // 
            this.tbp_Excel.Location = new System.Drawing.Point(4, 22);
            this.tbp_Excel.Name = "tbp_Excel";
            this.tbp_Excel.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Excel.Size = new System.Drawing.Size(894, 345);
            this.tbp_Excel.TabIndex = 1;
            this.tbp_Excel.Text = "Excel";
            this.tbp_Excel.UseVisualStyleBackColor = true;
            // 
            // tbp_Options
            // 
            this.tbp_Options.Location = new System.Drawing.Point(4, 22);
            this.tbp_Options.Name = "tbp_Options";
            this.tbp_Options.Size = new System.Drawing.Size(894, 345);
            this.tbp_Options.TabIndex = 3;
            this.tbp_Options.Text = "Options";
            this.tbp_Options.UseVisualStyleBackColor = true;
            // 
            // tbp_About
            // 
            this.tbp_About.Location = new System.Drawing.Point(4, 22);
            this.tbp_About.Name = "tbp_About";
            this.tbp_About.Size = new System.Drawing.Size(894, 345);
            this.tbp_About.TabIndex = 2;
            this.tbp_About.Text = "About";
            this.tbp_About.UseVisualStyleBackColor = true;
            // 
            // previewHandlerHost
            // 
            this.previewHandlerHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewHandlerHost.Location = new System.Drawing.Point(0, 0);
            this.previewHandlerHost.Name = "previewHandlerHost";
            this.previewHandlerHost.Size = new System.Drawing.Size(714, 364);
            this.previewHandlerHost.TabIndex = 0;
            // 
            // btn_CheckResult
            // 
            this.btn_CheckResult.Location = new System.Drawing.Point(9, 279);
            this.btn_CheckResult.Name = "btn_CheckResult";
            this.btn_CheckResult.Size = new System.Drawing.Size(148, 30);
            this.btn_CheckResult.TabIndex = 12;
            this.btn_CheckResult.Text = "Check result";
            this.btn_CheckResult.UseVisualStyleBackColor = true;
            this.btn_CheckResult.Click += new System.EventHandler(this.btn_CheckResult_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 396);
            this.Controls.Add(this.tab_COM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "COM Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_COM.ResumeLayout(false);
            this.tbp_Word.ResumeLayout(false);
            this.pnl_Preview.ResumeLayout(false);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_Preview;
        private PreviewHandlers.PreviewHandlerHost previewHandlerHost;
        private System.Windows.Forms.TabPage tbp_Main;
        private System.Windows.Forms.Button btn_CheckResult;
    }
}

