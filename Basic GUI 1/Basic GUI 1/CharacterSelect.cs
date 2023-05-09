using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_GUI_1
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect()
        {
            InitializeComponent();
        }

        public string Costume { get; set; }

        private void pictureBoxPlain_Click(object sender, EventArgs e)
        {
            Costume = "Plain";
            this.Close();
        }

        private void pictureBoxBow_Click(object sender, EventArgs e)
        {
            Costume = "Bow";
            this.Close();
        }

        private void pictureBoxBen_Click(object sender, EventArgs e)
        {
            Costume = "Ben";
            this.Close();
        }

        private void pictureBoxRedshirt_Click(object sender, EventArgs e)
        {
            Costume = "Redshirt";
            this.Close();
        }
    }
}
