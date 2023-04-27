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
        public Form1()
        {
            InitializeComponent();

            var pathne = new GraphicsPath();
            Point[] pTPointsne = { new Point(0, 0), new Point(220, 125), new Point(0,270) };
            pathne.AddLines(pTPointsne);
            buttonNE.Region = new Region(pathne);

            var pathe = new GraphicsPath();
            Point[] pTPointe = { new Point(0, 125), new Point(220, 0), new Point(220, 250) };
            pathe.AddLines(pTPointe);
            buttonE.Region = new Region(pathe);

            var pathse = new GraphicsPath();
            Point[] pTPointse = { new Point(0, 0), new Point(0, 250), new Point(220, 125) };
            pathse.AddLines(pTPointse);
            buttonSE.Region = new Region(pathse);

            var pathnw = new GraphicsPath();
            Point[] pTPointsnw = { new Point(220, 0), new Point(220, 250), new Point(0, 125) };
            pathnw.AddLines(pTPointsnw);
            buttonNW.Region = new Region(pathnw);

            var pathw = new GraphicsPath();
            Point[] pTPointw = { new Point(0, 0), new Point(0, 250), new Point(220, 125) };
            pathw.AddLines(pTPointw);
            buttonW.Region = new Region(pathw);

            var pathsw = new GraphicsPath();
            Point[] pTPointsw= { new Point(0, 125), new Point(220, 00), new Point(220, 250) };
            pathsw.AddLines(pTPointsw);
            buttonSW.Region = new Region(pathsw);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] HexPoints = { new Point(470, 0), new Point(690, 125), new Point(690, 375), new Point(470, 500), new Point(250, 375), new Point(250, 125) };
            Pen blackpen = new Pen(Color.Black,2);
            e.Graphics.DrawPolygon(blackpen, HexPoints);
        }
    }
}
