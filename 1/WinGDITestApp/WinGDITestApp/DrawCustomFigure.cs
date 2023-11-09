using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGDITestApp
{
    public class DrawCustomFigure
    {
        #region GDI_elements

        Pen m_Pen = new Pen(Color.Black, 2);


        // Base figure
        Point[] m_PointsFrame =
        {
           // new Point(30, 30),
            new Point(50, 50), // X Y
            new Point(100, 50),
            new Point(100, 100),
            new Point(300, 100),
            new Point(300, 150),
            new Point(480, 150),
            new Point(500, 170),
            new Point(500, 200),
        };

        // Line 2 left -> right
        Point[] m_PointsLineIn =
        {
            new Point(100, 100),
            new Point(100, 300),
        };

        // Line 3 left -> right
        Point[] m_PointsLineFurther =
        {
            new Point(300, 150),
            new Point(300, 300),
        };

        // Line 1 left -> right
        Point[] m_PointsLineOut =
        {
            new Point(50, 50),
            new Point(50, 350),
        };

        // Line to inside from flip, 4 line
        Point[] m_PointsLineInInside =
        {
            new Point(480, 250),
            new Point(480, 200),
            new Point(500, 200),
        };


        // Line - U to inside 5 line
        Point[] m_PointsLineU =
        {
            new Point(400, 150),
            new Point(400, 170),
            new Point(450, 170),
            new Point(450, 150),
        };

        // Curves points for a curve line
        Point[] m_PointsCurve =
        {
             // Start point
            new Point(480, 200),
            new Point(444, 184),
            new Point(424, 192),
            new Point(389, 184), // 4
            new Point(380, 162),
            new Point(357, 170),
            new Point(340, 150), // end
        };

        // Points for a dashed line
        Point[] m_PointsDash =
        {
             // Start point
            new Point(480, 200), // 1
            new Point(500, 170),
            new Point(455, 187), // 2
            new Point(483, 154),
            new Point(411, 191), // 3
            new Point(428, 170),
            new Point(389, 184), // 4
            new Point(400, 170),
            new Point(357, 170), // 5
            new Point(374, 150),
            new Point(348, 160), // 6
            new Point(356, 151),

        };


        #endregion
        // Drawing the frame of the figure
        public void drawFrame(Graphics graphics)
        {
            graphics.DrawLines(m_Pen, m_PointsFrame);

            // Lines
            graphics.DrawLines(m_Pen, m_PointsLineIn);
            graphics.DrawLines(m_Pen, m_PointsLineOut);
            graphics.DrawLines(m_Pen, m_PointsLineFurther);

            graphics.DrawLines(m_Pen, m_PointsLineInInside);
            graphics.DrawLines(m_Pen, m_PointsLineU);
        }

        // Reflection of the drawn frame
        public void drawFlipFrame(Graphics graphics)
        {
            int xmin = m_PointsFrame.Min(x => x.X);
            int xmax = m_PointsFrame.Max(x => x.X);

            graphics.TranslateTransform(0, xmin * 8);
            graphics.ScaleTransform(1, -1);
            //graphics.TranslateTransform(0, xmin * 2);
            graphics.DrawLines(m_Pen, m_PointsFrame.ToArray());
        }

        // Drawing a dotted line
        public void drawDottedLine(Graphics graphics)
        {
            // length, btw space, length space, end length 
            float[] dashValues = { 75, 10, 5, 20 };
            Pen blackPen = new Pen(Color.Black, 1);
            blackPen.DashPattern = dashValues;
            graphics.DrawLine(blackPen, new Point(2, 200), new Point(600, 200));
        }

        // Drawing a dashed line
        public void drawDashLine(Graphics graphics)
        {

            Pen dashPen = new Pen(Color.Red);
            Pen curvePen = new Pen(Color.Blue);

          
            // Set the width to 6.
            dashPen.Width = 1.5F;
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;


            // Create a custom dash pattern.
            //  greenPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };

            // Drawing a curve
            graphics.DrawCurve(curvePen, m_PointsCurve);

            // Drawing a line.
            // array
            graphics.DrawLine(dashPen, m_PointsDash[0], m_PointsDash[1]);
            graphics.DrawLine(dashPen, m_PointsDash[2], m_PointsDash[3]);
            graphics.DrawLine(dashPen, m_PointsDash[4], m_PointsDash[5]);
            graphics.DrawLine(dashPen, m_PointsDash[6], m_PointsDash[7]);
            graphics.DrawLine(dashPen, m_PointsDash[8], m_PointsDash[9]);
            graphics.DrawLine(dashPen, m_PointsDash[10], m_PointsDash[11]);
          
        }
    
    
    }
}
