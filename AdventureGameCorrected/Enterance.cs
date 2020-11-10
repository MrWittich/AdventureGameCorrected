﻿using System;
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
            lblEnergy.BackColor = System.Drawing.Color.Transparent;
            lblBrawn.Text = "" + info.brawn;
            lblBrains.Text = "" + info.brains;
            lblMagic.Text = "" + info.magic;
            lblCharm.Text = "" + info.charm;
            pbCharacter.Image = info.picture;
            pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
