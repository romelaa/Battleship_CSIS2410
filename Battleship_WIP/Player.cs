using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public class Player
    {
        public bool IsTurn { get; set; }
        public List<Ship> Armada = new List<Ship>();
        private int TurnNumber = 1;
        public string Name { get; set; }
        public WaterTile[,] PlayerBoard = new WaterTile[10,10];
        public short Hits = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public Player()
        {
            Armada.Add(new Ship(TileType.Destroyer, this));
            Armada.Add(new Ship(TileType.Submarine, this));
            Armada.Add(new Ship(TileType.Cruiser, this));
            Armada.Add(new Ship(TileType.Battleship, this));
            Armada.Add(new Ship(TileType.Carrier, this));
            SetUpNewBoard();
        }

        /// <summary>
        /// Sets up an empty WaterTiel[,] to represent the player's board.
        /// </summary>
        public void SetUpNewBoard()
        {
            for(int y = 0; y < 10; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    Coordinate c = new Coordinate(x, y);
                    PlayerBoard[x, y] = new WaterTile()
                    {
                        coordinate = c,
                        TileType = TileType.Empty
                    };
                }
            }
        }

        /// <summary>
        /// Checks for hits at coordinates (x, y)
        /// </summary>
        /// <param name="column">Column number (starts at 0)</param>
        /// <param name="row">Row number (starts at 0) </param>
        public void CheckHit(int column, int row)
        {
            Ship ship = WhichShip(PlayerBoard[column, row]);
            if (PlayerBoard[column, row].BeenShot == false)
            {
                PlayerBoard[column, row].BeenShot = true;
                if (PlayerBoard[column, row].HasShip)
                {
                    ship.Health--;
                    Hits++;
                    PlayerBoard[column, row].TileType = TileType.Hit;
                    if (ship.Health == 0)
                    {
                        Console.Write($"You sunk {this.Name}'s {ship.ToString()}\n");
                        Armada.Remove(ship);
                    }
                }
                else
                {
                    PlayerBoard[column, row].TileType = TileType.Miss;
                }
            }
            TurnNumber++;   
        }

        /// <summary>
        /// Checks if there is already a ship where new ship wants to be placed.
        /// </summary>
        /// <param name="s">New ship to place</param>
        /// <param name="row">Origin column of new ship</param>
        /// <param name="column">Origin row of new ship</param>
        /// <returns></returns>
        public bool ClearPlacement(Ship s, int column, int row)
        {
            if (s.HorizontalShip)
            {
                for (int i = 0; i < s.Health; i++)
                {
                    if (PlayerBoard[column+i, row].HasShip) return false;
                }
            }
            else
            {
                for (int i = 0; i < s.Health; i++)
                {
                    if (PlayerBoard[column, row+i].HasShip) return false; 
                }
            }

            return true;
        }

        /// <summary>
        /// Sets a new ship on the PlayerBoard
        /// </summary>
        /// <param name="s">Ship to place</param>
        /// <param name="column">Column</param>
        /// <param name="row">Row</param>
        public void SetShip(Ship s, int column, int row)
        {
            if (s.HorizontalShip)
            {
                try
                {
                    if (ClearPlacement(s, column, row))
                    {
                        for (int i = 0; i < s.Health; i++)
                        {
                            Coordinate c = new Coordinate(column + i, row);
                            WaterTile tile = PlayerBoard[column + i, row];
                            tile.coordinate = c;
                            PlayerBoard[column+i, row].HasShip = true;
                            PlayerBoard[column+i, row].TileType = s.VesselType;
                            s.OccupiedSlots.Add(tile);
                        }
                    }
                    else
                    {
                        Display.PlacementError(true);
                    }
                }
                catch (Exception e)
                {
                    Display.PlacementError(false);
                }
            }
            else
            {
                try
                {
                    if (ClearPlacement(s, column, row))
                    {
                        for (int i = 0; i < s.Health; i++)
                        {
                            Coordinate c = new Coordinate(column, row + i);
                            WaterTile tile = PlayerBoard[column, row + i];
                            tile.coordinate = c;
                            PlayerBoard[column, row+i].HasShip = true;
                            PlayerBoard[column, row+i].TileType = s.VesselType;
                            s.OccupiedSlots.Add(tile);
                        }
                    }
                    else
                    {
                        Display.PlacementError(true);
                    }
                }
                catch (Exception e)
                {
                    Display.PlacementError(false);
                }
            }
        }

        public void RemoveShip(Ship s)
        {
            if (s.HorizontalShip)
            {
                foreach(WaterTile tile in s.OccupiedSlots)
                {
                    PlayerBoard[tile.coordinate.Column, tile.coordinate.Row].HasShip = false;
                    PlayerBoard[tile.coordinate.Column, tile.coordinate.Row].TileType = TileType.Empty;
                }
                s.OccupiedSlots.RemoveRange(0, s.Health);
            }
            else
            {
                foreach (WaterTile tile in s.OccupiedSlots)
                {
                    PlayerBoard[tile.coordinate.Column, tile.coordinate.Row].HasShip = false;
                    PlayerBoard[tile.coordinate.Column, tile.coordinate.Row].TileType = TileType.Empty;
                    
                }
                s.OccupiedSlots.RemoveRange(0, s.Health);
            }
        }


        /// <summary>
        /// Returns which ship occupies a entered WaterTile
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        public Ship WhichShip(WaterTile tile)
        {
             return Armada.Find(x => x.VesselType.Equals(tile.TileType));
        }


    }
}
