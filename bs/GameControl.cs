using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Battleship;

namespace bs
{
    public partial class GameControl : UserControl
    {
        private IGame game;
        public IGame Game
        {
            get
            {
                return game;
            }
            set
            {
                if ((game = value) != null)
                {
                    brdPlayer.Board = game.Boards[0];
                    brdComputer.Board = game.Boards[1];
                }
                Redraw();
            }
        }

        public GameControl()
        {
            InitializeComponent();
        }

        public void Redraw()
        {
            if (game != null)
            {
                brdPlayer.Redraw(null);
                brdComputer.Redraw(null);
            }
        }
    }
}
