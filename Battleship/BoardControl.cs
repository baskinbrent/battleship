using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class BoardControl : UserControl
    {
        public BoardControl()
        {
            InitializeComponent();
        }

        public bool IsPlayer { get; set; }
        public IBoard Board { get; set; }
        private int x, y;

        private void BoardControl_Click(object sender, EventArgs e)
        {
            Redraw(true);
        }

        private void picView_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Redraw(false);
        }

        public void Redraw(bool click)
        {
            if (Board.ShipsLeftToPlace.Length == 0)
            {
            }
            else
            {
            }
        }
    }
}
