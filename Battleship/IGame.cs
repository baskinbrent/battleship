using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    enum Player
    {
        Human,
        Computer
    }

    interface IGame
    {
        //get 2 boards
        IBoard[] Boards { get; }
        //get whose turn it is
        Player Turn { get; }
        //fire on the active board
        bool Fire(int row, int column);
        //restarts the boards
        void NewGame();
    }
}
