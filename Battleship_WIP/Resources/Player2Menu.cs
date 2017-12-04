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
    public partial class Player2Menu : Form
    {
        private Game G;
        private RadioButton[,] p2Buttons = new RadioButton[10, 10];
        private RadioButton selectedButton;
        private Ship selectedShip;
        private int row;
        private int column;

        public Player2Menu(Game g)
        {
            G = g;
            InitializeComponent();
            AddButtonsPlayer2();
        }

        private void HoverHighlight(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            selectedButton = btn;
            row = this.ShipBoard.GetRow(selectedButton);
            column = this.ShipBoard.GetColumn(selectedButton);

            Highlight(true);
        }

        private void Highlight(bool highlight)
        {
            Color colorOption;

            try
            {
                if (selectedShip != null)
                {
                    if (highlight)
                    {
                        colorOption = selectedShip.ShipColor();

                    }
                    else
                    {
                        colorOption = Color.Transparent;
                    }
                    if (selectedShip.HorizontalShip)
                    {
                        for (int i = 0; i < selectedShip.Health; i++)
                        {
                            if (G.P1.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard.GetControlFromPosition(column + i, row).BackColor = colorOption;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < selectedShip.Health; i++)
                        {
                            if (G.P1.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard.GetControlFromPosition(column, row + i).BackColor = colorOption;
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void UndoHighlight(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            selectedButton = btn;
            row = this.ShipBoard.GetRow(selectedButton);
            column = this.ShipBoard.GetColumn(selectedButton);

            Highlight(false);
        }

        private void PositionShip(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            Ship ship = selectedShip;
            row = this.ShipBoard.GetRow(btn);
            column = this.ShipBoard.GetColumn(btn);

            if (btn.Checked)
            {
                if (ship != null)
                {
                    G.P1.SetShip(selectedShip, column, row);
                    G.P1.PrintMyBoard(ShipBoard);
                    selectedShip = null;
                    btn.Checked = false;
                }
                else
                {
                    Display.NoShipError();
                    btn.Checked = false;
                }
            }
            else { }

        }

        private void Destroyer_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Destroyer));
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Submarine));
        }

        private void Cruiser_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Cruiser));
        }

        private void Battleship_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Battleship));
        }

        private void Carrier_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Carrier));
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (selectedShip != null)
            {
                selectedShip.FlipShip();
            }
        }
    }
}