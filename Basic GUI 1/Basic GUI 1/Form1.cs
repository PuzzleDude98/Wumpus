using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_GUI_1
{
    public partial class Form1 : Form
    {

        private Region TriangleControl(Size size, string D)
        {
            GraphicsPath path = new GraphicsPath();
            if (D == "R")
            {
                Point[] points = { new Point(0, 0), new Point(size.Width, size.Height / 2), new Point(0, size.Height) };
                path.AddLines(points);
            }
            else
            {
                Point[] points = { new Point(0, size.Height/2), new Point(size.Width, 0), new Point(size.Width, size.Height) };
                path.AddLines(points);
            }
            return new Region(path);
        }

        public void DefineButtons()
        {
            buttonNE.Region = TriangleControl(buttonNE.Size, "R");

            buttonE.Region = TriangleControl(buttonE.Size, "L");

            buttonSE.Region = TriangleControl(buttonSE.Size, "R");

            buttonNW.Region = TriangleControl(buttonNW.Size, "L");

            buttonW.Region = TriangleControl(buttonW.Size, "R");

            buttonSW.Region = TriangleControl(buttonSW.Size, "L");
        }

        double Ratio;

        public Form1()
        {
            InitializeComponent();

            DefineButtons();

            Ratio = this.Size.Height / this.Size.Width;
        }

        private void MakeHexagon()
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Point[] HexPoints = { new Point(470, 0), new Point(690, 125), new Point(690, 375), new Point(470, 500), new Point(250, 375), new Point(250, 125) };
            //Pen blackpen = new Pen(Color.Black,2);
            //e.Graphics.DrawPolygon(blackpen, HexPoints);
            //e.Graphics.FillPolygon(Brushes.Tan, HexPoints);
        }

        private void MovePlayer(int x, int y)
        {

        }

        private void buttonNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved northeast!");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved east!");
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved southeast!");
        }

        private void buttonNW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved northwest!");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved west!");
        }

        private void buttonSW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You moved southwest!");
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point[] HexPoints = { new Point(panel1.Size.Width / 2, 0), new Point(panel1.Size.Width - 20, panel1.Size.Height / 4), new Point(panel1.Size.Width - 20, panel1.Size.Height / 4 * 3), new Point(panel1.Size.Width / 2, panel1.Size.Height), new Point(20, panel1.Size.Height / 4 * 3), new Point(20, panel1.Size.Height / 4) };
            Pen blackpen = new Pen(Color.Black, 5);
            e.Graphics.DrawPolygon(blackpen, HexPoints);
            e.Graphics.FillPolygon(Brushes.Tan, HexPoints);
        }
    }
}
