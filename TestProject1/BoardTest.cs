using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship;

namespace TestProject1
{
    [TestClass]
    public class BoardTest
    {

        static int Rows = 10;
        static int Columns = 10;



        /// <summary>
        ///A test for Fire
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void FireTest()
        {


            IBoard board = new Board();
            IShip[] ships = board.ShipsLeftToPlace;



            Assert.IsFalse(board.Fire(0, 0));
            Assert.AreEqual(Cell.Water, board.Cells[0, 0]);

            Assert.IsTrue(board.Place(ships[0], 0, 0, Orientation.Vertical));
            Assert.IsTrue(board.Place(ships[1], 0, 1, Orientation.Vertical));
            Assert.IsTrue(board.Place(ships[2], 0, 2, Orientation.Vertical));
            Assert.IsTrue(board.Place(ships[3], 0, 3, Orientation.Vertical));
            Assert.IsTrue(board.Place(ships[4], 0, 4, Orientation.Vertical));


            Assert.AreEqual(Cell.Ship, board.Cells[0, 0]);
            board.Fire(0, 0);
            Assert.AreEqual(Cell.Hit, board.Cells[0, 0]);

            Assert.AreEqual(Cell.Water, board.Cells[9, 9]);
            board.Fire(9, 9);
            Assert.AreEqual(Cell.Miss, board.Cells[9, 9]);

            Assert.IsFalse(board.Fire(10, 10));


        }

        /// <summary>
        ///A test for NewGame
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void NewGameTest()
        {
            List<IShip> ships = new List<IShip>(new IShip[]{
                new Ship() { Size = 5},
                new Ship() { Size = 4},
                new Ship() { Size = 3},
                new Ship() { Size = 3},
                new Ship() { Size = 2}
            });
            Cell[,] cells = new Cell[Rows, Columns];


            Assert.IsNotNull(ships);
            Assert.AreEqual(5, ships.Count);
            Assert.AreEqual(5, ships[0].Size);
            Assert.AreEqual(4, ships[1].Size);
            Assert.AreEqual(3, ships[2].Size);
            Assert.AreEqual(3, ships[3].Size);
            Assert.AreEqual(2, ships[4].Size);


            Assert.IsNotNull(cells);
            Assert.AreEqual(Rows, cells.GetLength(0));
            Assert.AreEqual(Columns, cells.GetLength(0));
        }

        /// <summary>
        ///A test for Place
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void PlaceTest()
        {


            IBoard board = new Board();
            IShip[] ships = board.ShipsLeftToPlace;

               Assert.IsTrue(board.Place(ships[0], 0, 0, Orientation.Vertical));
               Assert.IsFalse(board.Place(ships[0], 0, 0, Orientation.Vertical)); //Should be false because ship is already placed
               Assert.IsFalse(board.Place(ships[1], 0, 0, Orientation.Vertical)); // Should be false because ship does not fit there
               Assert.IsFalse(board.Place(ships[1], 9, 9, Orientation.Vertical)); // Should be false because ship does not fit there
               Assert.IsTrue(board.Place(ships[1], 0, 1, Orientation.Vertical));
               Assert.IsTrue(board.Place(ships[2], 0, 2, Orientation.Vertical));
               Assert.IsTrue(board.Place(ships[3], 0, 3, Orientation.Vertical));
               Assert.IsTrue(board.Place(ships[4], 0, 4, Orientation.Vertical));
               Assert.IsFalse(board.Place(ships[0], 0, 0, Orientation.Vertical)); // Placing ship after all ships are place should be false.


               board = new Board();
               ships = board.ShipsLeftToPlace;
          
            Assert.IsTrue(board.Place(ships[0], 0, 0, Orientation.Horizontal));
            Assert.IsFalse(board.Place(ships[0], 0, 0, Orientation.Horizontal)); //Should be false because ship is already placed
            Assert.IsFalse(board.Place(ships[1], 0, 0, Orientation.Horizontal)); // Should be false because ship does not fit there
            Assert.IsFalse(board.Place(ships[1], 9, 9, Orientation.Horizontal)); // Should be false because ship does not fit there
            Assert.IsTrue(board.Place(ships[1], 1, 0, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[2], 2, 0, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[3], 3, 0, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[4], 4, 0, Orientation.Horizontal));
            Assert.IsFalse(board.Place(ships[0], 0, 0, Orientation.Horizontal)); // Placing ship after all ships are place should be false.


        }

        /// <summary>
        ///A test for ShipFits
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ShipFitsTest()
        {


            IBoard board = new Board();
            IShip[] ships = board.ShipsLeftToPlace;


            Assert.IsTrue(board.ShipFits(ships[0], 0, 0, Orientation.Vertical));
            Assert.IsTrue(board.ShipFits(ships[1], 0, 1, Orientation.Vertical));
            Assert.IsTrue(board.ShipFits(ships[2], 0, 2, Orientation.Vertical));
            Assert.IsTrue(board.ShipFits(ships[3], 0, 3, Orientation.Vertical));
            Assert.IsTrue(board.ShipFits(ships[4], 0, 4, Orientation.Vertical));

            Assert.IsTrue(board.ShipFits(ships[0], 0, 0, Orientation.Horizontal));
            Assert.IsTrue(board.ShipFits(ships[1], 0, 1, Orientation.Horizontal));
            Assert.IsTrue(board.ShipFits(ships[2], 0, 2, Orientation.Horizontal));
            Assert.IsTrue(board.ShipFits(ships[3], 0, 3, Orientation.Horizontal));
            Assert.IsTrue(board.ShipFits(ships[4], 0, 4, Orientation.Horizontal));

            board.Place(ships[0], 0, 0, Orientation.Vertical);
            board.Place(ships[1], 0, 1, Orientation.Vertical);
            board.Place(ships[2], 0, 2, Orientation.Vertical);
            board.Place(ships[3], 0, 3, Orientation.Vertical);
            board.Place(ships[4], 0, 4, Orientation.Vertical);

            Assert.IsFalse(board.ShipFits(ships[0], 0, 0, Orientation.Vertical));
            Assert.IsFalse(board.ShipFits(ships[1], 0, 1, Orientation.Vertical));
            Assert.IsFalse(board.ShipFits(ships[2], 0, 2, Orientation.Vertical));
            Assert.IsFalse(board.ShipFits(ships[3], 0, 3, Orientation.Vertical));
            Assert.IsFalse(board.ShipFits(ships[4], 0, 4, Orientation.Vertical));

            Assert.IsFalse(board.ShipFits(ships[0], 0, 0, Orientation.Horizontal));
            Assert.IsFalse(board.ShipFits(ships[1], 1, 0, Orientation.Horizontal));
            Assert.IsFalse(board.ShipFits(ships[2], 2, 0, Orientation.Horizontal));
            Assert.IsFalse(board.ShipFits(ships[3], 3, 0, Orientation.Horizontal));
            Assert.IsFalse(board.ShipFits(ships[4], 4, 0, Orientation.Horizontal));

        }

        /// <summary>
        ///A test for Cells
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void CellsTest()
        {
            IBoard board = new Board(); 
            Cell[,] actual;
            actual = board.Cells;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(actual[i,j], Cell.Water);
                }
            }

            Assert.AreEqual(actual.GetLength(0), 10);
            Assert.AreEqual(actual.GetLength(1), 10);

        }

        /// <summary>
        ///A test for Columns
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ColumnsTest()
        {
            IBoard board = new Board();
            Assert.AreEqual(board.Columns, 10);
            
        }

        /// <summary>
        ///A test for IsOver
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void IsOverTest()
        {

            IBoard board = new Board();
            IShip[] ships = board.ShipsLeftToPlace;


            board.Place(ships[0], 0, 0, Orientation.Vertical);
            board.Place(ships[1], 0, 1, Orientation.Vertical);
            board.Place(ships[2], 0, 2, Orientation.Vertical);
            board.Place(ships[3], 0, 3, Orientation.Vertical);
            board.Place(ships[4], 0, 4, Orientation.Vertical);

            Assert.IsFalse(board.IsOver);

            board.Fire(0, 0); board.Fire(1, 0); board.Fire(2, 0); board.Fire(3, 0); board.Fire(4, 0);
            board.Fire(0, 1); board.Fire(1, 1); board.Fire(2, 1); board.Fire(3, 1);
            board.Fire(0, 2); board.Fire(1, 2); board.Fire(2, 2);
            board.Fire(0, 3); board.Fire(1, 3); board.Fire(2, 3);
            board.Fire(0, 4); board.Fire(1, 4); 

            Assert.IsTrue(board.IsOver);

        }

        /// <summary>
        ///A test for Rows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void RowsTest()
        {
            IBoard board = new Board();
            Assert.AreEqual(board.Rows, 10);
        }

        /// <summary>
        ///A test for ShipsLeftToPlace
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ShipsLeftToPlaceTest()
        {
            IBoard board = new Board();
            IShip[] ships = board.ShipsLeftToPlace;

            Assert.AreEqual(board.ShipsLeftToPlace.Length, ships.Length);
            board.Place(ships[0], 0, 0, Orientation.Vertical);
            Assert.AreEqual(board.ShipsLeftToPlace.Length, (ships.Length - 1));
            board.Place(ships[1], 0, 1, Orientation.Vertical);
            Assert.AreEqual(board.ShipsLeftToPlace.Length, (ships.Length - 2));
            board.Place(ships[2], 0, 2, Orientation.Vertical);
            Assert.AreEqual(board.ShipsLeftToPlace.Length, (ships.Length - 3));
            board.Place(ships[3], 0, 3, Orientation.Vertical);
            Assert.AreEqual(board.ShipsLeftToPlace.Length, (ships.Length - 4));
            board.Place(ships[4], 0, 4, Orientation.Vertical);
            Assert.AreEqual(board.ShipsLeftToPlace.Length, (ships.Length - 5));


        }
    }
}
