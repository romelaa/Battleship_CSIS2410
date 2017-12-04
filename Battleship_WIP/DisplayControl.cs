using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Battleship_WIP
{
    /// <summary>
    /// Controls aspects of the GUI such as colors and printing either player or enemy board.
    /// </summary>
    public static class Display
    {

        public static void PrintMyBoard(this Player p, TableLayoutPanel table)
        {
            WaterTile[,] board = p.PlayerBoard;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(0); j++)
                {
                    switch(board[i, j].TileType)
                    {
                        case (TileType.Empty):
                            break;
                        case (TileType.Destroyer):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Blue;
                            break;
                        case (TileType.Submarine):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Violet;
                            break;
                        case (TileType.Cruiser):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Brown;
                            break;
                        case (TileType.Battleship):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Orange;
                            break;
                        case (TileType.Carrier):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.DarkKhaki;
                            break;
                        case (TileType.Hit):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Red;
                            break;
                        case (TileType.Miss):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.GhostWhite;
                            break;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public static void PrintEnemyBoard(this Player p, TableLayoutPanel table)
        {
            WaterTile[,] board = p.PlayerBoard;
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(0); j++)
                {
                    switch (board[i, j].TileType)
                    {
                        case (TileType.Hit):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Red;
                            break;
                        case (TileType.Miss):
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.GhostWhite;
                            break;
                        default:
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Transparent;
                            break;

                    }
                }
            }
        }

        public static void HideShips(this Player p, TableLayoutPanel table)
        {
            foreach (Ship s in p.Armada)
            {
                foreach(WaterTile tile in s.OccupiedSlots)
                {
                    SingleTileUpdate(p, table, tile.coordinate.Column, tile.coordinate.Row);
                }
            }
        }

        public static void ShowShips(this Player p, TableLayoutPanel table)
        {
            foreach (Ship s in p.Armada)
            {
                foreach (WaterTile tile in s.OccupiedSlots)
                {

                    table.GetControlFromPosition(tile.coordinate.Column, tile.coordinate.Row).BackColor = tile.TileColor();


                    Console.WriteLine($"{s.VesselType}:  {tile.coordinate.Column} {tile.coordinate.Row}");
                }
                
            }
            Console.WriteLine();
        }

        public static void SingleTileUpdate(this Player p, TableLayoutPanel table, int column, int row)
        {
            switch (p.PlayerBoard[column, row].TileType)
            {
                case (TileType.Hit):
                    table.GetControlFromPosition(column, row).BackgroundImage = global::Battleship_WIP.Properties.Resources.hitOcean;
                    table.GetControlFromPosition(column, row).BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case (TileType.Miss):
                    table.GetControlFromPosition(column, row).BackgroundImage = global::Battleship_WIP.Properties.Resources.missOcean;
                    table.GetControlFromPosition(column, row).BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                default:
                    table.GetControlFromPosition(column, row).BackColor = Color.Transparent;
                    break;
            }
        }

        public static void UndrawShip(this Player p, Ship s, TableLayoutPanel table)
        {
            foreach (WaterTile t in s.OccupiedSlots)
            {
                p.SingleTileUpdate(table, t.coordinate.Column, t.coordinate.Row);
            }
        }

        public static void FormHeader(this Form form, Player p)
        {
            form.Text = $"{p.Name}'s Turn";
        }

        public static Color TileColor(this WaterTile t)
        {
            switch (t.TileType)
            {
                //case (TileType.Miss):
                //    return Color.NavajoWhite;
                //case (TileType.Hit):
                //    return Color.Red;
                case (TileType.Destroyer):
                    return Color.Yellow;
                case (TileType.Submarine):
                    return Color.OrangeRed;
                case (TileType.Cruiser):
                    return Color.Green;
                case (TileType.Battleship):
                    return Color.Blue;
                case (TileType.Carrier):
                    return Color.Purple;
                default:
                    return Color.Transparent;
            }
        }

        public static Color ShipOnlyColor(this Ship s)
        {
            switch (s.VesselType)
            {
                case (TileType.Destroyer):
                    return Color.Yellow;
                case (TileType.Submarine):
                    return Color.OrangeRed;
                case (TileType.Cruiser):
                    return Color.Green;
                case (TileType.Battleship):
                    return Color.Blue;
                case (TileType.Carrier):
                    return Color.DarkViolet;
                default:
                    return Color.Transparent;
            }
        }

        public static void NoShipError()
        {
            MessageBox.Show("Select a ship to place!");
        }

        public static void PlacementError(bool inBounds)
        {
            if (inBounds)
            {
                MessageBox.Show("Ship cannot overlap another ship!");
            }
            else
            {
                MessageBox.Show("Must place ship in bounds!");
            }
        }
    }
}
