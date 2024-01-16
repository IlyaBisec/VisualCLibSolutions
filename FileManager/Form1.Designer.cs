namespace FileManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_FileInfo = new System.Windows.Forms.TabPage();
            this.tbp_FileManage = new System.Windows.Forms.TabPage();
            this.btn_AboutFile = new System.Windows.Forms.Button();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Memo2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbp_FileInfo.SuspendLayout();
            this.tbp_FileManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_FileInfo);
            this.tabControl1.Controls.Add(this.tbp_FileManage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tbp_FileInfo
            // 
            this.tbp_FileInfo.Controls.Add(this.tb_Memo);
            this.tbp_FileInfo.Controls.Add(this.btn_AboutFile);
            this.tbp_FileInfo.Location = new System.Drawing.Point(4, 22);
            this.tbp_FileInfo.Name = "tbp_FileInfo";
            this.tbp_FileInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_FileInfo.Size = new System.Drawing.Size(470, 338);
            this.tbp_FileInfo.TabIndex = 0;
            this.tbp_FileInfo.Text = "File Info";
            this.tbp_FileInfo.UseVisualStyleBackColor = true;
            // 
            // tbp_FileManage
            // 
            this.tbp_FileManage.Controls.Add(this.tb_Memo2);
            this.tbp_FileManage.Controls.Add(this.btn_Save);
            this.tbp_FileManage.Controls.Add(this.btn_Open);
            this.tbp_FileManage.Location = new System.Drawing.Point(4, 22);
            this.tbp_FileManage.Name = "tbp_FileManage";
            this.tbp_FileManage.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_FileManage.Size = new System.Drawing.Size(470, 338);
            this.tbp_FileManage.TabIndex = 1;
            this.tbp_FileManage.Text = "File Manage";
            this.tbp_FileManage.UseVisualStyleBackColor = true;
            // 
            // btn_AboutFile
            // 
            this.btn_AboutFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AboutFile.Location = new System.Drawing.Point(3, 3);
            this.btn_AboutFile.Name = "btn_AboutFile";
            this.btn_AboutFile.Size = new System.Drawing.Size(464, 23);
            this.btn_AboutFile.TabIndex = 0;
            this.btn_AboutFile.Text = "Info about file";
            this.btn_AboutFile.UseVisualStyleBackColor = true;
            this.btn_AboutFile.Click += new System.EventHandler(this.btn_AboutFile_Click);
            // 
            // tb_Memo
            // 
            this.tb_Memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Memo.Location = new System.Drawing.Point(3, 26);
            this.tb_Memo.Multiline = true;
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(464, 309);
            this.tb_Memo.TabIndex = 1;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(6, 307);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(124, 23);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(343, 307);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Memo2
            // 
            this.tb_Memo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Memo2.Location = new System.Drawing.Point(3, 3);
            this.tb_Memo2.Multiline = true;
            this.tb_Memo2.Name = "tb_Memo2";
            this.tb_Memo2.Size = new System.Drawing.Size(464, 298);
            this.tb_Memo2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tbp_FileInfo.ResumeLayout(false);
            this.tbp_FileInfo.PerformLayout();
            this.tbp_FileManage.ResumeLayout(false);
            this.tbp_FileManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_FileInfo;
        private System.Windows.Forms.TabPage tbp_FileManage;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.Button btn_AboutFile;
        private System.Windows.Forms.TextBox tb_Memo2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
    }
}

