using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ZedGraph;

namespace GraphicApp
{
    public partial class MainForm : Form
    {


        private float m_A;
        private int m_N;

        private int m_Xmax;
        private int m_Xmin;
        private int m_Ymax;
        private int m_Ymin;



        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                groupData.Left = Width - this.groupData.Width - 20;
                setAxisParameters();
                Invalidate();
            }
        }


        private void setAxisParameters()
        {
            m_Xmax = int.Parse(tbXMax.Text);
            m_Xmin = int.Parse(tbXMin.Text);

            m_Ymax = int.Parse(tbYMax.Text);
            m_Ymin = int.Parse(tbYMin.Text);

            m_A = float.Parse(tbA.Text);
            m_N = int.Parse(tbN.Text);

        }


        private double function(double x)
        {
            m_A = float.Parse(tbA.Text);

            return (m_A * Math.Sqrt(x) + Math.Sqrt(Math.Log(m_A * x)) + 
                Math.Pow(m_A * x, 3) - Math.Pow(m_A * x, 1 / 10)); 
          
        }

        private void drawGraph()
        {
            setAxisParameters();


            GraphPane pane = graphicsz.GraphPane;
            pane.CurveList.Clear();

            PointPairList list = new PointPairList();

            int resultsSize = (m_Xmax - m_Xmin) * m_N;
            int index = 0;

            for (float x = m_Xmin; x < m_Xmax && index < resultsSize; x += 1f / m_N, index++)
            {
                list.Add(x, function(x));
            }

            LineItem myCurve = pane.AddCurve("MyGraph", list, Color.Blue, SymbolType.None);

            graphicsz.AxisChange();
            graphicsz.Invalidate();
        }


        private void btnPaint_Click(object sender, EventArgs e)
        {
            if (m_Xmin <= 0 && m_Xmax >= 0)
            {
                if (m_Ymin <= 0 && m_Ymax >= 0)
                {
                    drawGraph();
                }
            }

            else
            {
                MessageBox.Show("Draw graph error!");
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graphicsz.GraphPane.Title.Text = "";
            graphicsz.GraphPane.Legend.IsVisible = false;

            graphicsz.GraphPane.XAxis.Title.Text = "X";
            graphicsz.GraphPane.YAxis.Title.Text = "Y";
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbN.Text = "";

            tbXMax.Text = "";
            tbXMin.Text = "";

            tbYMax.Text = "";
            tbYMin.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
