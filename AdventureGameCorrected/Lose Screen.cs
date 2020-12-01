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
            //set background image
            ResizeBackgroundImage();
            //set top text
            lblLose.Parent = pbBackground;
            lblLose.BackColor = Color.Transparent;
            lblLose.ForeColor = Color.Red;
            //set bottom text
            lblLoseText.Width = this.Width;
            lblLoseText.Height = this.Height / 3;
            RelocateLoseText();
            lblLoseText.Text = message;
            lblLoseText.Parent = pbBackground;
            lblLoseText.BackColor = Color.Transparent;
            lblLoseText.ForeColor = Color.Red;
            //set middle text
            lblAgain.Parent = pbBackground;
            lblAgain.BackColor = Color.Transparent;
            lblAgain.ForeColor = Color.Red;
            RelocatePlayAgain();
            lblExit.Parent = pbBackground;
            lblExit.BackColor = Color.Transparent;
            lblExit.ForeColor = Color.Red;
            label2.Parent = pbBackground;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            lblPlayAgain.Parent = pbBackground;
            lblPlayAgain.BackColor = Color.Transparent;
            lblPlayAgain.ForeColor = Color.Red;
        }

        private void Lose_Screen_SizeChanged(object sender, EventArgs e)
        {
            ResizeBackgroundImage();
            RelocatePlayAgain();
            lblLoseText.Width = this.Width;
            lblLoseText.Height = this.Height / 3;
            lblLoseText.Left = 0;
            int fontSize = this.Width / 45;
            lblLoseText.Font = new Font("SWGothe", fontSize, FontStyle.Bold);
        }

        private void RelocatePlayAgain()
        {
            int top = this.Height / 2 - lblAgain.Height / 2;
            lblAgain.Top = top;
            lblPlayAgain.Top = lblExit.Top = label2.Top = lblAgain.Top;

        }

        private void RelocateLoseText()
        {
            lblLoseText.Top = lblAgain.Bottom + 10;
        }

        private void ResizeBackgroundImage()
        {
            pbBackground.Width = this.Width;
            pbBackground.Height = this.Height;
            pbBackground.Left = 0;
            pbBackground.Top = 0;
            pbBackground.Image = Properties.Resources.Skull;
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red;
        }

        private void lblPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
            this.Hide();
        }

        private void lblPlayAgain_MouseHover(object sender, EventArgs e)
        {
            lblPlayAgain.ForeColor = Color.White;
        }

        private void lblPlayAgain_MouseLeave(object sender, EventArgs e)
        {
            lblPlayAgain.ForeColor = Color.Red;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
