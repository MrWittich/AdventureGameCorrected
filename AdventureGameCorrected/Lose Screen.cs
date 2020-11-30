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
        string message;
        public Lose_Screen(string m)
        {
            InitializeComponent();
            message = m;
        }

        private void Lose_Screen_Load(object sender, EventArgs e)
        {
            pbBackground.Width = this.Width;
            pbBackground.Height = this.Height;
            pbBackground.Left = 0;
            pbBackground.Top = 0;
            pbBackground.Image = Properties.Resources.Skull;
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            lblLose.Parent = pbBackground;
            lblLose.BackColor = Color.Transparent;
            lblLose.ForeColor = Color.Red;
            lblLoseText.Text = message;
            lblLoseText.Parent = pbBackground;
            lblLoseText.BackColor = Color.Transparent;
            lblLoseText.ForeColor = Color.White;
            lblAgain.Parent = pbBackground;
            lblAgain.BackColor = Color.Transparent;
            lblAgain.ForeColor = Color.Red;
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
