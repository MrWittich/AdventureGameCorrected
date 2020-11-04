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

        }
    }
}
