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
        public String PlayerName
        {
            get
            {
                return txtPlayerName.Text;
            }
        }

        public bool PlayerNameEnabled
        {
            get
            {
                return txtPlayerName.Enabled;
            }
            set
            {
                txtPlayerName.Enabled = value;
            }
        }

        private IGame game;
        public Battleship()
        {
            InitializeComponent();
            game = new Game();
            gameViewer.Game = game;
        }

        private void btnGameStatistics_Click(object sender, EventArgs e)
        {
            frmGameStatistics GameStats = new frmGameStatistics();
            GameStats.ShowDialog();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            frmHowToPlay HowToPlay = new frmHowToPlay();
            HowToPlay.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (GiveUp())
            {
                game.NewGame();
                PlayerNameEnabled = true;
                gameViewer.Redraw();
            }
        }

        //returns a value indicating if it was ok to quit the game
        private bool GiveUp()
        {
            if (game.Turns > 0)
            {
                if (MessageBox.Show("You are in the middle of a game. If you quit you will lose. Press OK to close the game and accept this loss or Cancel to keep playing.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Database.AddStatistics(txtPlayerName.Text, Player.Computer, game.Turns);
                    return true;
                }
                return false;
            }
            return true;
        }

        private void Battleship_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !GiveUp();
        }
    }
}
