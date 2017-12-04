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
    public partial class GetPlayer1Name : Form
    {
        private Game G;

        public GetPlayer1Name(Game g)
        {
            G = g;
            InitializeComponent();
        }

        private void btnSubmitP1_Click(object sender, EventArgs e)
        {
            if (txtP1Name.Text.Equals(""))
            {
                G.P1.Name = G.P1.Name;
            }
            else
            {
                G.P1.Name = txtP1Name.Text;
            }
            this.Close();

        }
    }
}
