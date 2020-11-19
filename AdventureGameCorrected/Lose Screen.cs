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
    public partial class Lose_Screen : Form
    {
        public Lose_Screen()
        {
            InitializeComponent();
        }

        private void Lose_Screen_Load(object sender, EventArgs e)
        {
            pbBackground.Width = this.Width;
            pbBackground.Height = this.Height;
            pbBackground.Left = 0;
            pbBackground.Top = 0;
            pbBackground.Image = Properties.Resources.Skull;
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Lose_Screen_SizeChanged(object sender, EventArgs e)
        { 
            pbBackground.Width = this.Width;
            pbBackground.Height = this.Height;
            pbBackground.Left = 0;
            pbBackground.Top = 0;
            pbBackground.Image = Properties.Resources.Skull;
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
