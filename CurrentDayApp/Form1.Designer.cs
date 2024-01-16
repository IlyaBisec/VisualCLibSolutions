namespace CurrentDayApp
{
    partial class MainFom
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
            this.lb_CurrentDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_CurrentDay
            // 
            this.lb_CurrentDay.AutoSize = true;
            this.lb_CurrentDay.Location = new System.Drawing.Point(13, 13);
            this.lb_CurrentDay.Name = "lb_CurrentDay";
            this.lb_CurrentDay.Size = new System.Drawing.Size(35, 13);
            this.lb_CurrentDay.TabIndex = 0;
            this.lb_CurrentDay.Text = "label1";
            // 
            // MainFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 64);
            this.Controls.Add(this.lb_CurrentDay);
            this.Name = "MainFom";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CurrentDay;
    }
}

