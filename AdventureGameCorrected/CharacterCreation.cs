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
        string picture;
        
        public CharacterCreation()
        {
            InitializeComponent();
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

            }
            else
            {

            }
          
        }
    }
}
