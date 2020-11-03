using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGameCorrected
{
    public partial class Form1 : Form
    {
        bool loop;

        public Form1()
        {
            InitializeComponent();
            loop = true;
        }

        private void lblStart_MouseHover(object sender, EventArgs e)
        {
            lblStart.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void lblStart_MouseLeave(object sender, EventArgs e)
        {
            lblStart.ForeColor = System.Drawing.Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
