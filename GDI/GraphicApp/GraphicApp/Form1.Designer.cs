namespace GraphicApp
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
            this.components = new System.ComponentModel.Container();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbYMax = new System.Windows.Forms.TextBox();
            this.tbXMax = new System.Windows.Forms.TextBox();
            this.tbYMin = new System.Windows.Forms.TextBox();
            this.tbXMin = new System.Windows.Forms.TextBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbYMax = new System.Windows.Forms.Label();
            this.lbXMax = new System.Windows.Forms.Label();
            this.lbYMin = new System.Windows.Forms.Label();
            this.lbXMin = new System.Windows.Forms.Label();
            this.graphicsz = new ZedGraph.ZedGraphControl();
            this.groupData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupData
            // 
            this.groupData.Controls.Add(this.btnExit);
            this.groupData.Controls.Add(this.btnClearFields);
            this.groupData.Controls.Add(this.btnPaint);
            this.groupData.Controls.Add(this.tbN);
            this.groupData.Controls.Add(this.tbA);
            this.groupData.Controls.Add(this.tbYMax);
            this.groupData.Controls.Add(this.tbXMax);
            this.groupData.Controls.Add(this.tbYMin);
            this.groupData.Controls.Add(this.tbXMin);
            this.groupData.Controls.Add(this.lbN);
            this.groupData.Controls.Add(this.lbA);
            this.groupData.Controls.Add(this.lbYMax);
            this.groupData.Controls.Add(this.lbXMax);
            this.groupData.Controls.Add(this.lbYMin);
            this.groupData.Controls.Add(this.lbXMin);
            this.groupData.Location = new System.Drawing.Point(446, 12);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(173, 284);
            this.groupData.TabIndex = 0;
            this.groupData.TabStop = false;
            this.groupData.Text = "Data";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(9, 218);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(137, 23);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(9, 189);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(137, 23);
            this.btnPaint.TabIndex = 7;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(46, 152);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 6;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(46, 125);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 5;
            // 
            // tbYMax
            // 
            this.tbYMax.Location = new System.Drawing.Point(46, 94);
            this.tbYMax.Name = "tbYMax";
            this.tbYMax.Size = new System.Drawing.Size(100, 20);
            this.tbYMax.TabIndex = 4;
            // 
            // tbXMax
            // 
            this.tbXMax.Location = new System.Drawing.Point(46, 40);
            this.tbXMax.Name = "tbXMax";
            this.tbXMax.Size = new System.Drawing.Size(100, 20);
            this.tbXMax.TabIndex = 2;
            // 
            // tbYMin
            // 
            this.tbYMin.Location = new System.Drawing.Point(46, 67);
            this.tbYMin.Name = "tbYMin";
            this.tbYMin.Size = new System.Drawing.Size(100, 20);
            this.tbYMin.TabIndex = 3;
            // 
            // tbXMin
            // 
            this.tbXMin.Location = new System.Drawing.Point(46, 16);
            this.tbXMin.Name = "tbXMin";
            this.tbXMin.Size = new System.Drawing.Size(100, 20);
            this.tbXMin.TabIndex = 1;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(6, 155);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(16, 13);
            this.lbN.TabIndex = 5;
            this.lbN.Text = "n:";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(6, 128);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(16, 13);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "a:";
            // 
            // lbYMax
            // 
            this.lbYMax.AutoSize = true;
            this.lbYMax.Location = new System.Drawing.Point(6, 97);
            this.lbYMax.Name = "lbYMax";
            this.lbYMax.Size = new System.Drawing.Size(36, 13);
            this.lbYMax.TabIndex = 3;
            this.lbYMax.Text = "Ymax:";
            // 
            // lbXMax
            // 
            this.lbXMax.AutoSize = true;
            this.lbXMax.Location = new System.Drawing.Point(6, 42);
            this.lbXMax.Name = "lbXMax";
            this.lbXMax.Size = new System.Drawing.Size(36, 13);
            this.lbXMax.TabIndex = 2;
            this.lbXMax.Text = "Xmax:";
            // 
            // lbYMin
            // 
            this.lbYMin.AutoSize = true;
            this.lbYMin.Location = new System.Drawing.Point(6, 70);
            this.lbYMin.Name = "lbYMin";
            this.lbYMin.Size = new System.Drawing.Size(33, 13);
            this.lbYMin.TabIndex = 1;
            this.lbYMin.Text = "Ymin:";
            // 
            // lbXMin
            // 
            this.lbXMin.AutoSize = true;
            this.lbXMin.Location = new System.Drawing.Point(6, 16);
            this.lbXMin.Name = "lbXMin";
            this.lbXMin.Size = new System.Drawing.Size(33, 13);
            this.lbXMin.TabIndex = 0;
            this.lbXMin.Text = "Xmin:";
            // 
            // graphicsz
            // 
            this.graphicsz.Location = new System.Drawing.Point(12, 12);
            this.graphicsz.Name = "graphicsz";
            this.graphicsz.ScrollGrace = 0D;
            this.graphicsz.ScrollMaxX = 0D;
            this.graphicsz.ScrollMaxY = 0D;
            this.graphicsz.ScrollMaxY2 = 0D;
            this.graphicsz.ScrollMinX = 0D;
            this.graphicsz.ScrollMinY = 0D;
            this.graphicsz.ScrollMinY2 = 0D;
            this.graphicsz.Size = new System.Drawing.Size(428, 284);
            this.graphicsz.TabIndex = 1;
            this.graphicsz.UseExtendedPrintDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 308);
            this.Controls.Add(this.graphicsz);
            this.Controls.Add(this.groupData);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbYMax;
        private System.Windows.Forms.TextBox tbXMax;
        private System.Windows.Forms.TextBox tbYMin;
        private System.Windows.Forms.TextBox tbXMin;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbYMax;
        private System.Windows.Forms.Label lbXMax;
        private System.Windows.Forms.Label lbYMin;
        private System.Windows.Forms.Label lbXMin;
        private ZedGraph.ZedGraphControl graphicsz;
    }
}

