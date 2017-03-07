using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace grafika1
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);

        PointF P1 = new PointF();
        PointF P2 = new PointF();

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        Point[] p = {
            new Point(10, 200),   // start point of first spline
            new Point(75, 110),    // first control point of first spline
            new Point(80, 150),    // second control point of first spline

            new Point(100, 250),  // endpoint of first spline and 
                         // start point of second spline

            new Point(125, 180),   // first control point of second spline
            new Point(175, 300),  // second control point of second spline
            new Point(200, 210)    // endpoint of second spline
        };
        private void Button2_Click(object sender, EventArgs e)
        {
            g.DrawBeziers(pen1, p);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            g.DrawLine(pen1, P2.X, P2.Y, P1.X, P1.Y);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            P1.X = (float)Double.Parse(textBox1.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            P1.Y = (float)Double.Parse(textBox2.Text);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            P2.X = (float)Double.Parse(textBox3.Text);
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            P2.Y = (float)Double.Parse(textBox4.Text);
        }

        private void Cleaner_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Pen myBrush = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = pictureBox1.CreateGraphics();
            formGraphics.DrawRectangle(pen1, new Rectangle(100, 400, 75, 75));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(200, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

            // Draw polygon to screen.
            g.DrawPolygon(pen1, curvePoints);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            Point point1 = new Point(275, 50);
            Point point2 = new Point(250, 25);
            Point point3 = new Point(300, 5);
            Point point4 = new Point(450, 50);
            Point point5 = new Point(400, 100);
            Point point6 = new Point(450, 200);
            Point point7 = new Point(350, 250);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw lines between original points to screen.
            //g.DrawLines(redPen, curvePoints);

            // Draw curve to screen.
           g.DrawCurve(greenPen, curvePoints);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(pen1, new Rectangle(200, 250, 150, 250));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.DrawArc(pen1, 50, 300, 140, 70, 30, 180);
        }
    }
}
