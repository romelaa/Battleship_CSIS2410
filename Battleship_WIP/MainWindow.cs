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
    public partial class MainWindow : Form
    {
        private int row;
        private int column;
        private Game G;
        private RadioButton[,] leftButtons = new RadioButton[10, 10];
        private RadioButton[,] rightButtons = new RadioButton[10, 10];
        private RadioButton SelectedBtn;


        public MainWindow(Game g)
        {
            G = g;
            InitializeComponent();
            MessageBox.Show($"{G.P1.Name} will start.");
            AddLeftButtons();
            AddRighttButtons();
            this.FormHeader(G.P1);
            G.P1.ShowShips(LeftBoard);
            LeftBoard.Enabled = false;
            
        }

        private void LeftGrid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            row = this.LeftBoard.GetRow(btn);
            column = this.LeftBoard.GetColumn(btn);
            SelectedBtn = btn;
        }

        private void RightGrid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            row = this.RightBoard.GetRow(btn);
            column = this.RightBoard.GetColumn(btn);
            SelectedBtn = btn;

            
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            TakeATurn();
        }

        private void TakeATurn()
        {
            if (SelectedBtn != null)
            {
                if (G.P1.IsTurn)
                {
                    G.P2.CheckHit(column, row);
                    G.P2.SingleTileUpdate(RightBoard, column, row);
                    SelectedBtn.Enabled = false;
                    SelectedBtn = null;
                    G.SwitchTurn();
                    MessageBox.Show($"{G.P2.PlayerBoard[column, row].TileType}!");
                    G.P1.HideShips(LeftBoard);
                    MessageBox.Show($"{G.P2.Name} get ready.");
                    G.P2.ShowShips(RightBoard);
                    LeftBoard.Enabled = true;
                    RightBoard.Enabled = false;
                    this.FormHeader(G.P2);
                    
                }
                else
                {
                    G.P1.CheckHit(column, row);
                    G.P1.SingleTileUpdate(LeftBoard, column, row);
                    SelectedBtn.Enabled = false;
                    SelectedBtn = null;
                    G.SwitchTurn();
                    MessageBox.Show($"{G.P1.PlayerBoard[column, row].TileType}!");
                    G.P2.HideShips(RightBoard);
                    MessageBox.Show($"{G.P1.Name} get ready.");
                    G.P1.ShowShips(LeftBoard);
                    RightBoard.Enabled = true;
                    LeftBoard.Enabled = false;
                    this.FormHeader(G.P1);
                    
                }
            }
            else
            {
                MessageBox.Show("Must select a coordinate to fire at!");
            }
        }
    }
}
