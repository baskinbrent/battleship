using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bs;

namespace Battleship
{
    public partial class Battleship : Form
    {
        private IGame game;
        public Battleship()
        {
            InitializeComponent();
            game = new Game();
            gameViewer.Game = game;
        }
    }
}
