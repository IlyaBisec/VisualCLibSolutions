using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLineApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Point startPoint, endtPoint;
        Point point1, point2;

        bool drawing = false;


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawString("Борисов И. А. ИСТ-41, 4 вариант", new Font("Arial", 14), Brushes.Blue, new Point(10, 10));
            graphics.DrawLine(new Pen(Brushes.Green, 4), point1, point2);

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.drawing = true;
                this.startPoint = new Point(400, 100); //e.x
                this.endtPoint = new Point(400, 250);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drawing)
            {
                this.point1 = new Point(this.startPoint.X, this.startPoint.Y);
                this.point2 = new Point(this.endtPoint.X, this.endtPoint.Y);
                
                Invalidate();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.drawing = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.T: // Up
                    {
                        this.point1.Y -= 2;
                        this.point2.Y -= 2;

                        break;
                    }
                case Keys.F:
                    {
                        this.point1.Y += 2;
                        this.point2.Y += 2;
                        break;
                    }
                case Keys.G: // Left
                    {
                        if (e.Shift)
                        {
                            this.point1.X -= 2;
                            this.point2.X -= 2;
                        }
                        break;
                    }
                case Keys.H:
                    {
                        if (e.Shift)
                        {
                            this.point1.X += 2;
                            this.point2.X += 2;
                        }
                        break;
                    }
                case Keys.X:
                    {
                        this.point1 = new Point(0, 0);
                        this.point2 = new Point(0, 0);

                        break;
                    }
            }
            Invalidate();
        }

    }
}
