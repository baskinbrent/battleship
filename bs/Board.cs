using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
   public class Board : IBoard
    {

        private List<IShip> ships;
        private Cell[,] cells;

        public Board()
        {
            NewGame();
        }

        public int Columns
        {
            get { return 10; }
        }

        public int Rows
        {
            get { return 10; }
        }

        public IShip[] ShipsLeftToPlace
        {
            get { return ships.ToArray(); }
        }

        public bool Place(IShip ship, int row, int column, Orientation orientation)
        {
            if (ShipsLeftToPlace.Contains(ship))
            {
                if (ShipFits(ship, row, column, orientation))
                {
                    if (orientation == Orientation.Vertical)
                    {
                        for (int i = 0; i < ship.Size; i++)
                        {
                            cells[row + i, column] = Cell.Ship;

                        }
                    }
                    if (ShipFits(ship, row, column, orientation))
                    {
                        if (orientation == Orientation.Horizontal)
                        {

                            for (int i = 0; i < ship.Size; i++)
                            {
                                cells[row, column + i] = Cell.Ship;

                            }
                        }
                    }
                    return ships.Remove(ship);
                }
            }
            return false;

        }

        public bool ShipFits(IShip ship, int row, int column, Orientation orientation)
        {
            if (orientation == Orientation.Vertical)
            {
                if (row + ship.Size > Columns)
                {
                    return false;
                }

                for (int i = 0; i < ship.Size; i++)
                {
                    if (cells[row + i, column] == Cell.Ship)
                    {
                        return false;
                    }

                }
            }
            if (orientation == Orientation.Horizontal)
            {

                if (column + ship.Size > Rows)
                {
                    return false;
                }

                for (int i = 0; i < ship.Size; i++)
                {
                    if (cells[row, column + i] == Cell.Ship)
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public bool Fire(int row, int column)
        {
            if (row < 10 && column < 10 && row >= 0 && column >= 0)
            {
                if (ShipsLeftToPlace.Length == 0)
                {
                    if (cells[row, column] != Cell.Hit)
                    {
                        if (cells[row, column] == Cell.Ship)
                        {
                            cells[row, column] = Cell.Hit;

                            return true;
                        }
                        if (cells[row, column] == Cell.Water)
                        {
                            cells[row, column] = Cell.Miss;

                            return true;
                        }
                    }

                }
            }
            return false;
        }

        public Cell[,] Cells
        {
            get
            {
                Cell[,] copy = new Cell[Rows, Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        copy[i, j] = cells[i, j];
                    }
                }
                return copy;
            }
        }

        public void NewGame()
        {
            ships = new List<IShip>(new IShip[] {
                new Ship() { Size = 5},
                new Ship() { Size = 4},
                new Ship() { Size = 3},
                new Ship() { Size = 3},
                new Ship() { Size = 2}
            });
            cells = new Cell[Rows, Columns];
        }


        public bool IsOver
        {
            get
            {

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (cells[i, j] == Cell.Ship)
                        {
                            return false;
                        }
                    }

                }
                return true;
            }
        }
    }
}
