using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;

namespace bs
{
    class Database
    {
        //? means it can be null (in the case of a tie)
        public static bool AddStatistics(Player? winner, int turns)
        {
            return false;
        }

        public static int LeastTurnsToWin
        {
            get { return 100; }
        }

        public static int Wins
        {
            get { return 0; }
        }

        public static int Losses
        {
            get { return 0; }
        }
    }
}
