using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum Cell : int
    {
        Water = 0,
        Ship = 1,
        Hit = 2,
        Miss = 3
    }

    public enum Orientation
    {
        Horizontal,
        Vertical
    }

    public interface IBoard
    {
        //the number of rows the board has
        int Rows { get; }
        //the number of columns the board has
        int Columns { get; }
        //returns an array of ships that have no yet been placed on the board. 
        IShip[] ShipsLeftToPlace { get; }
        //places a ship starting at the specified (row, column) with the specified orientation. 
        //Returns true if the boat is available and can be placed at the specified location.
        bool Place(IShip ship, int row, int column, Orientation orientation);
        //Fires a missile at the specified (row, column).
        //only able to do if the game is started
        //returns true if it hit
        bool Fire(int row, int column);
        //get the contents of all the game cells
        //where you attacked
        Cell[] Cells { get; }
        //restarts the game (should be called in the constructor)
        void Reset();
        //peek at the real board
        Cell[] Test { get; }
        //checks if game is over
        bool IsOver { get; }
       
    }
}