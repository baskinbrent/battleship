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
            brdPlayer.AllShipsPlaced += new EventHandler(brdPlayer_AllShipsPlaced);
            brdComputer.ShotFired += new EventHandler(brdComputer_ShotFired);
        }

        void brdComputer_ShotFired(object sender, EventArgs e)
        {
            //ai logic and state checker
            Random random = new Random();
            while (!brdPlayer.Board.Fire(random.Next(brdPlayer.Board.Rows), random.Next(brdPlayer.Board.Columns))) ;
            brdPlayer.Redraw(null);
        }

        void brdPlayer_AllShipsPlaced(object sender, EventArgs e)
        {
            //place all of the ships for the ai unit
            for (int i = 0; brdComputer.Board.ShipsLeftToPlace.Length > 0; i++)
            {
                brdComputer.Board.Place(brdComputer.Board.ShipsLeftToPlace[0], i, 0, Battleship.Orientation.Horizontal);
            }
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
