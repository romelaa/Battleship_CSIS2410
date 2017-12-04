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
    public partial class Player1Menu : Form
    {
        private Game G;
        private RadioButton[,] p1Buttons = new RadioButton[10, 10];
        private RadioButton selectedButton;
        private Ship selectedShip;
        private int row;
        private int column;
        private short setShips = 0;

        public Player1Menu(Game g)
        {
            G = g;
            InitializeComponent();
            this.BackgroundImage = global::Battleship_WIP.Properties.Resources.background;
            AddButtonsPlayer1();
        }

        private void HoverHighlight(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            selectedButton = btn;
            row = this.ShipBoard1.GetRow(selectedButton);
            column = this.ShipBoard1.GetColumn(selectedButton);

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
                            if (G.P1.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard1.GetControlFromPosition(column + i, row).BackColor = colorOption;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < selectedShip.Health; i++)
                        {
                            if (G.P1.ClearPlacement(selectedShip, column, row))
                            {
                                ShipBoard1.GetControlFromPosition(column, row + i).BackColor = colorOption;
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
            row = this.ShipBoard1.GetRow(selectedButton);
            column = this.ShipBoard1.GetColumn(selectedButton);

            Highlight(false);
        }

        private void PositionShip(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            Ship ship = selectedShip;
            row = this.ShipBoard1.GetRow(btn);
            column = this.ShipBoard1.GetColumn(btn);

            if (btn.Checked)
            {
                if (ship != null)
                {
                    G.P1.SetShip(selectedShip, column, row);
                    G.P1.ShowShips(ShipBoard1);
                    DisableShipButton();
                    btn.Checked = false;
                    selectedShip = null;
                }
                else
                {
                    Display.NoShipError();
                    btn.Checked = false;
                }
            }
            else { /*Intentionally doing nothing for this case*/ }
          
        }

        private void DisableShipButton()
        {
            switch (selectedShip.VesselType)
            {
                case TileType.Destroyer:
                    btnDestroyer.Enabled = false;
                    btnRemoveDestroyer.Enabled = true;
                    setShips++;
                    break;
                case TileType.Submarine:
                    btnSub.Enabled = false;
                    btnRemoveSub.Enabled = true;
                    setShips++;
                    break;
                case TileType.Cruiser:
                    btnCruiser.Enabled = false;
                    btnRemoveCruiser.Enabled = true;
                    setShips++;
                    break;
                case TileType.Battleship:
                    btnBattleship.Enabled = false;
                    btnRemoveBattleship.Enabled = true;
                    setShips++;
                    break;
                case TileType.Carrier:
                    btnCarrier.Enabled = false;
                    btnRemoveCarrier.Enabled = true;
                    setShips++;
                    break;
            }
            if (setShips == 5) doneBtn.Enabled = true;
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Destroyer));
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Submarine));
        }

        private void btnCruiser_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Cruiser));
        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Battleship));
        }

        private void btnCarrier_Click(object sender, EventArgs e)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(TileType.Carrier));
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            if(selectedShip != null)
            {
                selectedShip.FlipShip();
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveDestroyer_Click(object sender, EventArgs e)
        {
            RemoveThisShip(TileType.Destroyer);
        }

        private void btnRemoveSub_Click(object sender, EventArgs e)
        {
            RemoveThisShip(TileType.Submarine);
        }

        private void btnRemoveCruiser_Click(object sender, EventArgs e)
        {
            RemoveThisShip(TileType.Cruiser);
        }

        private void btnRemoveBattleship_Click(object sender, EventArgs e)
        {
            RemoveThisShip(TileType.Battleship);
        }

        private void btnRemoveCarrier_Click(object sender, EventArgs e)
        {
            RemoveThisShip(TileType.Carrier);
        }

        private void RemoveThisShip(TileType t)
        {
            selectedShip = G.P1.Armada.Find(x => x.VesselType.Equals(t));
            G.P1.UndrawShip(selectedShip, ShipBoard1);
            setShips--;
            G.P1.RemoveShip(selectedShip);
            selectedShip = null;

            switch (t)
            {
                case TileType.Destroyer:
                    btnDestroyer.Enabled = true;
                    btnRemoveDestroyer.Enabled = false;
                    break;
                case TileType.Submarine:
                    btnSub.Enabled = true;
                    btnRemoveSub.Enabled = false;                    
                    break;
                case TileType.Cruiser:
                    btnCruiser.Enabled = true;
                    btnRemoveCruiser.Enabled = false;                  
                    break;
                case TileType.Battleship:
                    btnBattleship.Enabled = true;
                    btnRemoveBattleship.Enabled = false;               
                    break;
                case TileType.Carrier:
                    btnCarrier.Enabled = true;
                    btnRemoveCarrier.Enabled = false;
                    break;
            }
        }


    }
}