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
    public partial class GetPlayer2Name : Form
    {
        private Game G;
        public GetPlayer2Name(Game g)
        {
            G = g;
            InitializeComponent();
        }

        private void btnSubmitP2_Click(object sender, EventArgs e)
        {
            if (txtP2Name.Text.Equals(""))
            {
                G.P2.Name = G.P2.Name;
            }
            else
            {
                G.P2.Name = txtP2Name.Text;
            }
            this.Close();

        }
    }
}
