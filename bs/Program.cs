using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using bs;

namespace Battleship
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.AddStatistics("Logan", Player.Human, 25);
            Database.AddStatistics("John", Player.Human, 50);
            Database.AddStatistics("Brent", Player.Human, 35);
            Database.AddStatistics("Logan", Player.Computer, 20);
            Database.AddStatistics("John", Player.Computer, 40);
            Database.AddStatistics("Brent", Player.Computer, 50);
            Database.AddStatistics("Chris", Player.Computer, 25);
            Database.AddStatistics("Mathew", Player.Human, 30);

            Dictionary<string, Dictionary<string, object>> data = Database.GetStatistics();
            var names = data.Keys;
            foreach (var name in names)
            {
                Dictionary<string, object> d = data[name];
                var keys = d.Keys;
                Console.Write("name = " + name + ", ");
                foreach (var key in keys)
                {
                    Console.Write(key + " = " + d[key] + ", ");
                }
                Console.WriteLine();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Battleship());
        }
    }
}
