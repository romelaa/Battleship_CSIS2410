using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int column, int row)
        {
            this.Column = column;
            this.Row = row;
        }
    }
}
