using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameCorrected
{
    public partial class Enterance : Form
    {
        Character info;

        public Enterance(Character c)
        {
            InitializeComponent();
            info = c;
        }

        private void Enterance_Load(object sender, EventArgs e)
        {
            ProgEnergy.Value = info.energy * 10;
            lblBrawn.Text = "" + info.brawn;
            lblBrains.Text = "" + info.brains;
            lblMagic.Text = "" + info.magic;
            lblCharm.Text = "" + info.charm;
            pbCharacter.Image = info.picture;
            pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRoom.Image = Properties.Resources.Enterance;
            pbRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThree.Hide();
            lblChoice3.Hide();
            btnTwo.Text = "Leave!";
            lblChoice2.Text = "Flee the Dangerous Dungeon, like a coward.";
            btnOne.Text = "Enter";
            lblChoice1.Text = "Enter the Dangerous Dungeon, like a true Adventurer!";
            lblEnergy.BackColor = Color.Green;
            ProgEnergy.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Lose_Screen n = new Lose_Screen();
            n.Show();
            this.Hide();
        }
    }
}
