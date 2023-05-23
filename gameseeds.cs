using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidSpooferV2
{
    public partial class gameseeds : Form
    {
        public gameseeds()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.fallguys = true;
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.apex = true;
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.polygon = true;
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.dbd = true;
        }

        private void guna2GradientTileButton9_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.fortnite = true;
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.rainbow = true;
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.pubg = true;
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.eft = true;
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.dayz = true;
        }

        private void guna2GradientTileButton10_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.nullwoof = true;
        }

        private void guna2GradientTileButton11_Click(object sender, EventArgs e)
        {
            variables.reset();
            variables.randwoof = true;
        }
    }
}
