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

        public Player Player { get; set; }
        public IBoard Board { get; set; }
        private int x, y;
        private Orientation orientation;
        private Bitmap water;

        public BoardControl()
        {
            InitializeComponent();
            water = new Bitmap("images/water.jpg");
            Redraw();
        }

        private void picView_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Redraw(null);
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            Redraw(e.Button);
        }

        public void Redraw(MouseButtons? click)
        {
            //CLICK
            Graphics g = picView.CreateGraphics();
            int width = picView.Width / Board.Columns,
                height = picView.Height / Board.Rows;
            for (int i = 0; i < Board.Columns; i++)
            {
                for (int j = 0; j < Board.Rows; j++)
                {
                    g.DrawImage(water, new Rectangle(i * width, j * height, width, height));
                }
            }
            if (Board.ShipsLeftToPlace.Length == 0) //all of the ships have been placed
            {
                if (Player == Player.Human) //show ships and markers
                {

                }
                else //show markers only
                {

                }
            } //MOVE
            else //not all of the ships have been placed
            {
                if (Player == Player.Human) //show the ship to be placed
                {
                    if (click == MouseButtons.Right) //change orientation 
                    {
                        orientation = orientation == Orientation.Horizontal ? Orientation.Vertical : Orientation.Horizontal;
                    }
                    else if (click == MouseButtons.Left) //place boat
                    {
                        Board.Place(Board.ShipsLeftToPlace[0], x / (picView.Width / Board.Columns), y / (picView.Height / Board.Rows), orientation);
                    }
                }
            }
        }
    }
}
