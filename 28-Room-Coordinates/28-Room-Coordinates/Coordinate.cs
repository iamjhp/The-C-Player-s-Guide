using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Room_Coordinates {
    public struct Coordinate {

        public int Row { get; }
        public int Col { get; }

        public Coordinate(int row, int col) {
            Row = row;
            Col = col;
        }

        public static Boolean IsAdjacent(Coordinate a, Coordinate b) {
            return a.Row == b.Row || a.Col == b.Col;
        }

    }
}
