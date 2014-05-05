using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bs
{
    public partial class frmGameStatistics : Form
    {
        public frmGameStatistics()
        {
            InitializeComponent();
        }

        private void frmGameStatistics_Load(object sender, EventArgs e)
        {
            var statistics = Database.GetStatistics();
            var names = statistics.Keys;
            foreach (var name in names)
            {
                var statistic = statistics[name];
                lstGameStats.Items.Add(name);
                var item = lstGameStats.Items[lstGameStats.Items.Count - 1];
                item.SubItems.Add(statistic["Turns"].ToString());
                item.SubItems.Add(statistic["Wins"].ToString());
                item.SubItems.Add(statistic["Loses"].ToString());
            }
        }
    }
}
