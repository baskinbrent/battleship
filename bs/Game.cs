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
        private int turns;
        public int Turns { get { return turns; } }

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
            if (!IsOver)
            {
                if (player == Player.Computer)
                {
                    if (boards[0].Fire(row, column))
                    {
                        player = Player.Human;
                        return true;
                    }
                }
                else if (player == Player.Human)
                {
                    if (boards[1].Fire(row, column))
                    {
                        player = Player.Computer;
                        turns++;
                        return true;
                    }
                }
            }
            return false;
        }

        public void NewGame()
        {
            player = Player.Human;
            boards[0].NewGame();
            boards[1].NewGame();
            turns = 0;
        }

        public bool IsOver
        {
            get { return boards[0].IsOver || boards[1].IsOver; }
        }


        public int Rows
        {
            get { return 10; }
        }

        public int Columns
        {
            get { return 10; }
        }


        public Player? Winner
        {
            get
            {
                if (boards[0].IsOver && boards[1].IsOver)
                {
                    return null;
                }
                else if (boards[0].IsOver)
                {
                    return Player.Computer;
                }
                else if (boards[1].IsOver)
                {
                    return Player.Human;
                }
                return null;
            }
        }
    }
}
