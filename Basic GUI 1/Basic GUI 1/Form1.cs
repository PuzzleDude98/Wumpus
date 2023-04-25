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
            var path = new GraphicsPath();
            Point[] pTPoints = { new Point(30, 0), new Point(60, 60), new Point(0, 60) };
            path.AddLines(pTPoints);
            button1.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000);
        }
    }
}
