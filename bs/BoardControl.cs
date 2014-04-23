using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Battleship
{
    public partial class BoardControl : UserControl
    {

        private Player player;
        public Player Player { get { return player; } set { player = value; Redraw(null); } }
        private IBoard board;
        public IBoard Board { get { return board; } set { board = value; Redraw(null); } }
        private int x, y;
        private Orientation orientation;

        public BoardControl()
        {
            InitializeComponent();
        }

        private void picView_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            //TODO : make it redraw less
            Redraw(null);
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            Redraw(e.Button);
        }

        public void Redraw(MouseButtons? click)
        {
            //CLICK           
            if (board != null)
            {
                Bitmap bmp = new Bitmap(picView.Width, picView.Height);
                Graphics g = Graphics.FromImage(bmp);
                int width = picView.Width / Board.Columns,
                    height = picView.Height / Board.Rows,
                    column = x / width,
                    row = y / height;
                for (int i = 0; i < Board.Columns; i++)
                {
                    for (int j = 0; j < Board.Rows; j++)
                    {
                        g.FillRectangle(Brushes.Blue, i * width, j * height, width, height);
                        g.DrawRectangle(Pens.Black, i * width, j * height, width, height);
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
                            Board.Place(Board.ShipsLeftToPlace[0], column, row, orientation);
                        }
                        IShip ship = board.ShipsLeftToPlace[0];
                        if (board.ShipFits(ship, row, column, orientation))
                        {
                            for (int i = 0; i < ship.Size; i++)
                            {
                                g.FillRectangle(Brushes.Gray,
                                    ((orientation == Orientation.Horizontal ? i : 0) + column) * width,
                                    ((orientation == Orientation.Vertical ? i : 0) + row) * height,
                                    width, 
                                    height);
                                g.DrawRectangle(Pens.Black,
                                    ((orientation == Orientation.Horizontal ? i : 0) + column) * width,
                                    ((orientation == Orientation.Vertical ? i : 0) + row) * height,
                                    width,
                                    height);
                            }
                        }
                    }
                }
                picView.Image = bmp;
            }
        }
    }
}
