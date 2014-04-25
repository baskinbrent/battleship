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
        private int turns;
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
                    brdComputer.Game = game;
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
            while (!game.Fire(random.Next(game.Rows), random.Next(game.Columns))) ;
            brdPlayer.Redraw(null);
            turns++;
            if (game.IsOver)
            {
                Player? winner = game.Winner;
                if (winner == null) //tie
                {
                    MessageBox.Show("You tied!");
                }
                else if (winner == Player.Computer) //computer won
                {
                    MessageBox.Show("You lost!");
                }
                else if (winner == Player.Human) //player won
                {
                    MessageBox.Show("You won!");
                }
                Database.AddStatistics(winner, turns);
                game.NewGame();
                Redraw();
                turns = 0;
            }
        }

        void brdPlayer_AllShipsPlaced(object sender, EventArgs e)
        {
            //place all of the ships for the ai unit
            Random random = new Random();
            while (brdComputer.Board.ShipsLeftToPlace.Length > 0)
            {
                brdComputer.Board.Place(brdComputer.Board.ShipsLeftToPlace[0], random.Next(brdComputer.Board.Rows), random.Next(brdComputer.Board.Columns), random.Next(2) == 1 ? Battleship.Orientation.Horizontal : Battleship.Orientation.Vertical);
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
