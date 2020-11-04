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
    public partial class CharacterCreation : Form
    {
        int brawn;
        int brains;
        int magic;
        int charm;
        int energy;
        string name;

        Character n;
        
        public CharacterCreation()
        {
            InitializeComponent();
            lblBrawn.Text = "";
            lblBrains.Text = "";
            lblMagic.Text = "";
            lblCharm.Text = "";
            n = new Character();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

        }

        private void cbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPictures.Text == "Archer")
            {
                pbCharacterImage.Image = Properties.Resources.Archer;
            }
            else if (cbPictures.Text == "Dino-Wizard")
            {
                pbCharacterImage.Image = Properties.Resources.DinoMan;
            }
            else if (cbPictures.Text == "Engineer")
            {
                pbCharacterImage.Image = Properties.Resources.Tinkerer;
            }
            else if (cbPictures.Text == "Fighter")
            {
                pbCharacterImage.Image = Properties.Resources.Fighter;
            }
            else if (cbPictures.Text == "Frog Warrior")
            {
                pbCharacterImage.Image = Properties.Resources.FrogFighter;
            }
            else if (cbPictures.Text == "Rogue")
            {
                pbCharacterImage.Image = Properties.Resources.Rogue;
            }
            else if (cbPictures.Text == "Warlock")
            {
                pbCharacterImage.Image = Properties.Resources.Wizard;
            }

            pbCharacterImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cbBrawn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBrawn.Text == "<Reset>")
            {
                brawn = 0;
                lblBrawn.Text = "";
                Reset();
                cbBrawn.Text = "Brawn";
            }
            else
            {
                brawn = Convert.ToInt32(cbBrawn.Text);
                cbBrains.Items.Remove(cbBrawn.Text);
                cbMagic.Items.Remove(cbBrawn.Text);
                cbCharm.Items.Remove(cbBrawn.Text);

                lblBrawn.Text = cbBrawn.Text;
                cbBrawn.Items.Clear();
                cbBrawn.Items.Add("<Reset>");
                cbBrawn.Text = lblBrawn.Text;
            }
          
        }

        private void cbBrains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrains.Text == "<Reset>")
            {
                brains = 0;
                lblBrains.Text = "";
                Reset();
                cbBrains.Text = "Brains";
            }
            else
            {
                brains = Convert.ToInt32(cbBrains.Text);
                cbBrawn.Items.Remove(cbBrains.Text);
                cbMagic.Items.Remove(cbBrains.Text);
                cbCharm.Items.Remove(cbBrains.Text);

                lblBrains.Text = cbBrains.Text;
                cbBrains.Items.Clear();
                cbBrains.Items.Add("<Reset>");
                cbBrains.Text = lblBrains.Text;
            }
        }

        private void cbMagic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMagic.Text == "<Reset>")
            {
                magic = 0;
                lblMagic.Text = "";
                Reset();
                cbMagic.Text = "Magic";
            }
            else
            {
                magic = Convert.ToInt32(cbMagic.Text);
                cbBrawn.Items.Remove(cbMagic.Text);
                cbBrains.Items.Remove(cbMagic.Text);
                cbCharm.Items.Remove(cbMagic.Text);

                lblMagic.Text = cbMagic.Text;
                cbMagic.Items.Clear();
                cbMagic.Items.Add("<Reset>");
                cbMagic.Text = lblMagic.Text;
            }
        }

        private void cbCharm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharm.Text == "<Reset>")
            {
                charm = 0;
                lblCharm.Text = "";
                Reset();
                cbCharm.Text = "Charm";
            }
            else
            {
                charm = Convert.ToInt32(cbCharm.Text);
                lblCharm.Text = cbCharm.Text;
                cbBrawn.Items.Remove(cbCharm.Text);
                cbBrains.Items.Remove(cbCharm.Text);
                cbMagic.Items.Remove(cbCharm.Text);

                cbCharm.Items.Clear();
                cbCharm.Items.Add("<Reset>");
                cbCharm.Text = lblCharm.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(brawn != 0 && brains != 0 && magic != 0 && charm != 0 && name != "" && cbPictures.Text != "")
            {
                n.brawn = brawn;
                n.brains = brains;
                n.magic = magic;
                n.charm = charm;
                n.energy = 10;
                n.name = txtName.Text;
                n.picture = pbCharacterImage.Image;

                Enterance go = new Enterance(n);
                go.Show();
                this.Hide();
            }
            else
            {
                string message = "Please complete Character Creation before beginning your adventure.";
                MessageBox.Show(message);

        
            }
        }

        private void Reset()
        {
            string fill;

            cbBrawn.Items.Clear();
            cbBrains.Items.Clear();
            cbMagic.Items.Clear();
            cbCharm.Items.Clear();

            if(brawn == 0)
            {
                for(int i = 1; i < 5; i++)
                {
                    if(brains != i && magic != i && charm != i)
                    {
                        fill = "";
                        fill = fill + i;
                        cbBrawn.Items.Add(fill);
                    }
                }
            }
            if (brains == 0)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (brawn != i && magic != i && charm != i)
                    {
                        fill = "";
                        fill = fill + i;
                        cbBrains.Items.Add(fill);
                    }
                }
            }
            if (magic == 0)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (brawn != i && brains != i && charm != i)
                    {
                        fill = "";
                        fill = fill + i;
                        cbMagic.Items.Add(fill);
                    }
                }
            }
            if (charm == 0)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (brawn != i && magic != i && brains != i)
                    {
                        fill = "";
                        fill = fill + i;
                        cbCharm.Items.Add(fill);
                    }
                }
            }

            cbBrawn.Items.Add("<Reset>");
            cbBrains.Items.Add("<Reset>");
            cbMagic.Items.Add("<Reset>");
            cbCharm.Items.Add("<Reset>");
        }
    }
}
