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
        public static Dictionary<string, Dictionary<string, object>> GetStatistics()
        {
            Dictionary<string, Dictionary<string, object>> list = new Dictionary<string, Dictionary<string, object>>();

            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Battleship.accdb;";
            string strSQL = "";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            try
            {
                myConnection.Open();
                strSQL = "SELECT Name, Min(Turns), Count(*) FROM Statistic WHERE IsWinner GROUP BY Name ORDER BY Name";
                myCommand.CommandText = strSQL;
                myCommand.CommandType = System.Data.CommandType.Text;
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, object> fields = new Dictionary<string, object>();
                    fields["Turns"] = reader.GetInt32(1).ToString();
                    fields["Wins"] = reader.GetInt32(2).ToString();
                    fields["Loses"] = 0;
                    list[reader.GetString(0)] = fields;
                }
                reader.Close();

                strSQL = "SELECT Name, Count(*) FROM Statistic WHERE NOT IsWinner GROUP BY Name ORDER BY Name";
                myCommand.CommandText = strSQL;
                myCommand.CommandType = System.Data.CommandType.Text;
                reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (!list.ContainsKey(reader.GetString(0)))
                    {
                        Dictionary<string, object> fields = new Dictionary<string, object>();
                        fields["Turns"] = "DNA";
                        fields["Wins"] = 0;
                        list[reader.GetString(0)] = fields;
                    }
                    list[reader.GetString(0)]["Loses"] = reader.GetInt32(1).ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            myConnection.Close();
            return list;
        }

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
