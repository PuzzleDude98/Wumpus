using HuntTheWumpus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                Point[] points = { new Point(0, size.Height / 2), new Point(size.Width, 0), new Point(size.Width, size.Height) };
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

        public Form1()
        {
            InitializeComponent();
            DefineButtons();
        }

        string State = "move";
        string Costume = "Plain";

        private void MakeHexagon()
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Point[] HexPoints = { new Point(470, 0), new Point(690, 125), new Point(690, 375), new Point(470, 500), new Point(250, 375), new Point(250, 125) };
            //Pen blackpen = new Pen(Color.Black,2);
            //e.Graphics.DrawPolygon(blackpen, HexPoints);
            //e.Graphics.FillPolygon(Brushes.Tan, HexPoints);
        } // Currently unused, see panel1_Paint instead


        private (string, string, bool[]) placeholderMove() { return ("1", "",new bool[] { false,false,false,true,true,true}); }

        private (bool, string) placeholderShoot() { return (false,""); }

        private void DirectionButtonPress(string direction)
        {
            switch (State)
            {
                case "move":
                    MessageBox.Show("You moved " + direction + "!");

                    (string roomnumber, string warnings, bool[] openrooms) = placeholderMove(); //Process move - replace with GameControl method

                    labelRoom.Text = roomnumber;

                    labelWarning.Text = warnings;
                    if (labelWarning.Text == "")
                    {
                        labelWarning.Visible = false;
                    }
                    else
                    {
                        labelWarning.Visible = true;
                    }

                    buttonNW.Enabled = openrooms[0];
                    buttonNE.Enabled = openrooms[1];
                    buttonE.Enabled = openrooms[2];
                    buttonSE.Enabled = openrooms[3];
                    buttonSW.Enabled = openrooms[4];
                    buttonW.Enabled = openrooms[5];

                    break;

                case "shoot":
                    (bool success, string arrows) = placeholderShoot(); // Process shoot - replace with GameControl method
                    break;
                default:
                    MessageBox.Show("Something went wrong! No action state was selected.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            ResetShoot();

        }



        private void buttonNE_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("northeast");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("east");
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("southeast");
        }

        private void buttonNW_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("northwest");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("west");
        }

        private void buttonSW_Click(object sender, EventArgs e)
        {
            DirectionButtonPress("southwest");
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point[] HexPoints = { new Point(panel1.Size.Width / 2, 0), new Point(panel1.Size.Width - 20, panel1.Size.Height / 4), new Point(panel1.Size.Width - 20, panel1.Size.Height / 4 * 3), new Point(panel1.Size.Width / 2, panel1.Size.Height), new Point(20, panel1.Size.Height / 4 * 3), new Point(20, panel1.Size.Height / 4) };
            Pen blackpen = new Pen(Color.Black, 5);
            e.Graphics.DrawPolygon(blackpen, HexPoints);
            e.Graphics.FillPolygon(Brushes.Tan, HexPoints);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                pictureBoxCharacter.Image = Properties.Resources.ResourceManager.GetObject(Costume + "Front") as Image;
                State = "shoot";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                ResetShoot();
            }
        }

        private void ResetShoot()
        {
            pictureBoxCharacter.Image = Properties.Resources.ResourceManager.GetObject(Costume + "Back") as Image;
            State = "move";
        }

        private void buttonArrows_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arrow purchase here");
        } // Add method from GameControl here

        private void buttonSecret_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Secret purchase here");
        } // Add method from GameControl here

        private void HideHint_Tick(object sender, EventArgs e)
        {
            labelShoot.Visible = false;
            HideHint.Enabled = false;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            pictureBoxCharacter.Image = Properties.Resources.ResourceManager.GetObject(Costume + "Front") as Image;
            State = "move";
        }

        private void buttonCharacter_Click(object sender, EventArgs e)
        {
            CharacterSelect characterSelect = new CharacterSelect();
            characterSelect.ShowDialog();
            Costume = characterSelect.Costume;
            ResetShoot();
        }
    }
}
