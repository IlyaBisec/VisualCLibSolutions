using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawSquare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Point startPoint;

        float x1 = 20, x2 = 20;
        int width = 20, height = 20;

        Rectangle rectangle;
        bool drawing = false;
        Color color;

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawString("Borisov Ilya", new Font("Arial", 14), Brushes.Blue, new Point(10, 10));
            graphics.DrawRectangle(new Pen(color, 4), new Rectangle());
            //graphics.DrawRectangle(new Pen(color, 4), x1,x2,width,height);
            graphics.FillRectangle(new SolidBrush(color), this.rectangle);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.drawing = true;
                this.startPoint = new Point(e.X, e.Y); //e.x
            }
            else if (e.Button == MouseButtons.Left)
            {
                this.drawing = false;
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.AllowFullOpen = false;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                    color = colorDialog.Color;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drawing)
            {
                this.rectangle = new Rectangle(this.startPoint.X, this.startPoint.Y, e.X - this.startPoint.X, e.Y -
this.startPoint.Y);
                
                Invalidate();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.drawing = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
             int movespeed = 5;

            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        this.rectangle.Y -= movespeed;
                        break;
                    }
                case Keys.S:
                    {
                        this.rectangle.Y += movespeed;
                        break;
                    }
                case Keys.A:
                    {

                        this.rectangle.X -= movespeed;
                        break;
                    }
                case Keys.D:
                    {
                        this.rectangle.X += movespeed;
                        break;
                    }
                case Keys.X:
                    {
                        this.rectangle = new Rectangle(0, 0, 0, 0);
                        break;
                    }
            }
            Invalidate();
        }

    }
}
