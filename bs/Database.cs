using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleship;
using System.Collections;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace bs
{
    public class Database
    {
        public static bool AddStatistics(String name, Player winner, int turns)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Battleship.accdb;";
            string strSQL = "";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            try
            {
                myConnection.Open();
                strSQL = "INSERT INTO Statistic (Name, Turns, IsWinner) " +
                     "VALUES ('" + name + "'," + turns + "," + (winner == Player.Human) + ")";
                myCommand.CommandText = strSQL;
                myCommand.CommandType = System.Data.CommandType.Text;
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            myConnection.Close();
            return false;
        }
    }
}
