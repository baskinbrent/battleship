using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board : IBoard
    {

        private IShip[] ships;
        private Cell[,] cells;
        //private Cell[][] cells = new Cell[10]; //C#
        //public Cell[][] cells = new Cell[10][10]; //java

        public int Rows
        {
            get { return 10; }
        }

        public int Columns
        {
            get { return 10; }
        }

        public IShip[] ShipsLeftToPlace
        {
            get { return ships; }
        }

        public bool Place(IShip ship, int row, int column, Orientation orientation)
        {
            throw new NotImplementedException();
        }

        public bool Fire(int row, int column)
        {
            throw new NotImplementedException();
        }

        public Cell[] Cells
        {
            get { throw new NotImplementedException(); }
        }

        public void NewGame()
        {
            ships = new IShip[] {
                new Ship() { Size = 5},
                new Ship() { Size = 4},
                new Ship() { Size = 3},
                new Ship() { Size = 3},
                new Ship() { Size = 2}
            };
            cells = new Cell[10, 10];
        }

        public Cell[] Test
        {
            get { throw new NotImplementedException(); }
        }
    }
}
