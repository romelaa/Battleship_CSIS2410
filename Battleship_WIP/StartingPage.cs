using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    public partial class StartingPage : Form
    {
        private Game G;

        public StartingPage(Game g)
        {
            G = g;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}