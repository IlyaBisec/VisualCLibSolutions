using System.Drawing;
using System.Windows.Forms;

namespace DrawFigure
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Point startPoint;
        Point point1, point2;

        Rectangle ellipse_rect;
        bool drawing = false;

        Color color;
        


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawString("Borisov Ilya", new Font("Arial", 14), Brushes.Blue, new Point(10, 10));
            graphics.DrawEllipse(new Pen(Brushes.Red, 2), this.ellipse_rect);
            graphics.FillEllipse(new SolidBrush(color), this.ellipse_rect);

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.drawing = true;
                this.startPoint = new Point(e.X, e.Y); //e.x
            }
            else if(e.Button == MouseButtons.Left)
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
                this.ellipse_rect = new Rectangle(this.startPoint.X, this.startPoint.Y, e.X - this.startPoint.X, e.Y -
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
                        this.ellipse_rect.Y -= movespeed;
                        break;
                    }
                case Keys.S:
                    {
                        this.ellipse_rect.Y += movespeed;
                        break;
                    }
                case Keys.A:
                    {

                        this.ellipse_rect.X -= movespeed;
                        break;
                    }
                case Keys.D:
                    {
                        this.ellipse_rect.X += movespeed;
                        break;
                    }
                case Keys.X:
                    {
                        this.ellipse_rect = new Rectangle(0, 0, 0, 0);
                        break;
                    }
            }
            Invalidate();
        }

    }
}
