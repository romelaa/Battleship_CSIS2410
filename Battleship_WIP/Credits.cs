using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    public partial class Credits : Form
    {
        private Game G;
        public Credits(Game g)
        {
            G = g;
            InitializeComponent();
            DisplayWinner();
        }

        private void DisplayWinner()
        {
            if (G.gameOver == true) {
                lblWinner.Text = "Congratulations player! You defeated the enemy in seconds";
            }
        }
    }
}
