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

        private Region TriangleControl(int p11, int p12, int p21, int p22, int p31, int p32)
        {
            var path = new GraphicsPath();
            Point[] points = { new Point(p11, p12), new Point(p21, p22), new Point(p31, p32) };
            path.AddLines(points);
            return new Region(path);
        }

        public Form1()
        {
            InitializeComponent();

            buttonNE.Region = TriangleControl(0, 0, 220, 125, 0, 250);

            buttonE.Region = TriangleControl(0, 125, 220, 0, 220, 250);

            buttonSE.Region = TriangleControl(0, 0, 0, 250, 220, 125);

            buttonNW.Region = TriangleControl(220, 0, 220, 250, 0, 125);

            buttonW.Region = TriangleControl(0, 0, 0, 250, 220, 125);

            buttonSW.Region = TriangleControl(0, 125, 220, 0, 220, 250);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] HexPoints = { new Point(470, 0), new Point(690, 125), new Point(690, 375), new Point(470, 500), new Point(250, 375), new Point(250, 125) };
            Pen blackpen = new Pen(Color.Black,2);
            e.Graphics.DrawPolygon(blackpen, HexPoints);
        }

        private void Move(int x, int y)
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

    }
}
