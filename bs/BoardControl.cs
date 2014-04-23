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

        public event EventHandler AllShipsPlaced;
        public event EventHandler ShotFired;

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
                Cell[,] cells = board.Cells;
                int width = picView.Width / board.Rows,
                    height = picView.Height / board.Columns,
                    column = x / width,
                    row = y / height;
                for (int i = 0; i < board.Rows; i++)
                {
                    for (int j = 0; j < board.Columns; j++)
                    {
                        Brush fill = Brushes.Yellow;
                        if (Player == Player.Human && cells[i, j] == Cell.Ship)
                        {
                            fill = Brushes.Gray;
                        }
                        else if (Player == Player.Computer && cells[i, j] == Cell.Ship)
                        {
                            fill = Brushes.Blue;
                        }
                        else
                        {
                            if (cells[i, j] == Cell.Hit)
                            {
                                fill = Brushes.Red;
                            }
                            else if (cells[i, j] == Cell.Miss)
                            {
                                fill = Brushes.White;
                            }
                            else if (cells[i, j] == Cell.Water)
                            {
                                fill = Brushes.Blue;
                            }
                        }
                        g.FillRectangle(fill, j * width, i * height, width, height);
                        g.DrawRectangle(Pens.Black, j * width, i * height, width, height);
                    }
                }
                if (board.ShipsLeftToPlace.Length == 0) //all of the ships have been placed
                {
                    if (Player == Player.Computer && click == MouseButtons.Left)
                    {
                        if (board.Fire(row, column) && ShotFired != null)
                        {
                            ShotFired(this, EventArgs.Empty);
                        }
                    }
                } //MOVE
                else //not all of the ships have been placed
                {
                    if (Player == Player.Human) //show the ship to be placed
                    {
                        IShip ship = board.ShipsLeftToPlace[0];
                        if (click == MouseButtons.Right) //change orientation 
                        {
                            orientation = orientation == Orientation.Horizontal ? Orientation.Vertical : Orientation.Horizontal;
                        }
                        else if (click == MouseButtons.Left) //place boat
                        {
                            board.Place(board.ShipsLeftToPlace[0], row, column, orientation);
                            if (board.ShipsLeftToPlace.Length == 0 && AllShipsPlaced != null)
                            {
                                AllShipsPlaced(this, EventArgs.Empty);
                            }
                        }
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
