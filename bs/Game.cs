using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;

namespace bs
{
    class Game : IGame
    {
        public IBoard[] Boards
        {
            get { throw new NotImplementedException(); }
        }

        public Player Turn
        {
            get { throw new NotImplementedException(); }
        }

        public bool Fire(int row, int column)
        {
            throw new NotImplementedException();
        }

        public void NewGame()
        {
            throw new NotImplementedException();
        }

        public bool IsOver
        {
            get { throw new NotImplementedException(); }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
