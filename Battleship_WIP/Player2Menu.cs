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
            this.BackgroundImage = global::Battleship_WIP.Properties.Resources.background;
            AddButtonsPlayer2();
        }

        private void HoverHighlight(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            selectedButton = btn;
            row = this.ShipBoard2.GetRow(selectedButton);
            column = this.ShipBoard2.GetColumn(selectedButton);

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
                        colorOption = selectedShip.ShipOnlyColor();

                    }
                    else
                    {
                        colorOption = Color.Transparent;
                    }
                    if (selectedShip.HorizontalShip)
                    {
                        for (int i = 0; i < selectedShip.Health; i++)
                        {
                            if (G.P2.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard2.GetControlFromPosition(column + i, row).BackColor = colorOption;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < selectedShip.Health; i++)
                        {
                            if (G.P2.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard2.GetControlFromPosition(column, row + i).BackColor = colorOption;
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
            row = this.ShipBoard2.GetRow(selectedButton);
            column = this.ShipBoard2.GetColumn(selectedButton);

            Highlight(false);
        }

        private void Position2Ship(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            Ship ship = selectedShip;
            row = this.ShipBoard2.GetRow(btn);
            column = this.ShipBoard2.GetColumn(btn);

            if (btn.Checked)
            {
                if (ship != null)
                {
                    G.P2.SetShip(selectedShip, column, row);
                    G.P2.ShowShips(ShipBoard2);
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

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            selectedShip = G.P2.Armada.Find(x => x.VesselType.Equals(TileType.Destroyer));
            btnDestroyer.Enabled = false;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            selectedShip = G.P2.Armada.Find(x => x.VesselType.Equals(TileType.Submarine));
            btnSub.Enabled = false;
        }

        private void btnCruiser_Click(object sender, EventArgs e)
        {
            selectedShip = G.P2.Armada.Find(x => x.VesselType.Equals(TileType.Cruiser));
            btnCruiser.Enabled = false;
        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            selectedShip = G.P2.Armada.Find(x => x.VesselType.Equals(TileType.Battleship));
            btnBattleship.Enabled = false;
        }

        private void btnCarrier_Click(object sender, EventArgs e)
        {
            selectedShip = G.P2.Armada.Find(x => x.VesselType.Equals(TileType.Carrier));
            btnCarrier.Enabled = false;
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            if (selectedShip != null)
            {
                selectedShip.FlipShip();
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
