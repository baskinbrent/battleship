using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;
using System.Collections;
using System.Data.OleDb;
using System.IO;

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
        /*  Need To finish
        public bool WriteStatisticsToDB()
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=;";
            string strSQL = "";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();

                foreach (Player players in Players)
                {
                    strSQL = "INSERT INTO High_Scores (PlayerName, LeastNumTurns, NumWins, NumLosses) " +
                         "VALUES ('" + players.PlayerName + "','" + players.LeastNumTurns + "','" + players.NumWins + "','" + players.LeastNumLosses + "')";

                    myCommand.CommandText = strSQL;
                    myCommand.CommandType = System.Data.CommandType.Text;
                    myCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                myConnection.Close();
            } */
    }
}
