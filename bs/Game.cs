using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;

namespace bs
{
    public class Game : IGame
    {
        public Game()
        {
            boards = new List<IBoard>(new IBoard[] { new Board(), new Board() });
            NewGame();
        }

        private List<IBoard> boards;
        public IBoard[] Boards
        {
            get { return boards.ToArray(); }
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
            for (int i = 0; i < boards.Count; i++)
            {
                boards[i].NewGame();
            }
        }

        public bool IsOver
        {
            get { throw new NotImplementedException(); }
        }
    }
}
