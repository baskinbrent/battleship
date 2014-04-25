using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;

namespace bs
{
    public class Game : IGame
    {
        private Player player;

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
            get { return player; }
        }

        //fire to the proper board
        public bool Fire(int row, int column)
        {
            throw new NotImplementedException();
        }

        public void NewGame()
        {
            player = Player.Human;
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
