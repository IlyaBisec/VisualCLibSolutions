using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGDITestApp
{
    public partial class MainForm : Form
    {
        public string text;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
        // Run draw process
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            DrawCustomFigure drawCustom = new DrawCustomFigure();
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            drawCustom.drawFrame(g);
            drawCustom.drawDashLine(g);
            drawCustom.drawFlipFrame(g);
            drawCustom.drawDottedLine(g);
        }


        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = Convert.ToString("X: " + e.Location.X);
            lbY.Text = Convert.ToString("Y: " + e.Location.Y);
        }
    }
}
