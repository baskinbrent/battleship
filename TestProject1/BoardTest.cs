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
            


          Assert.IsFalse(board.Fire(0,0));
          Assert.AreEqual(Cell.Water, board.Cells[0, 0]);

          Assert.IsTrue(board.Place(ships[0], 0, 0, Orientation.Vertical));
          Assert.IsTrue(board.Place(ships[1], 0, 1, Orientation.Vertical));
          Assert.IsTrue(board.Place(ships[2], 0, 2, Orientation.Vertical));
          Assert.IsTrue(board.Place(ships[3], 0, 3, Orientation.Vertical));
          Assert.IsTrue(board.Place(ships[4], 0, 4, Orientation.Vertical));


          Assert.AreEqual(Cell.Ship, board.Cells[0, 0]);
          board.Fire(0, 0);
          Assert.AreEqual(Cell.Hit, board.Cells[0,0]);

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


            board.NewGame();

            Assert.IsTrue(board.Place(ships[0], 0, 0, Orientation.Horizontal));
            Assert.IsFalse(board.Place(ships[0], 0, 0, Orientation.Horizontal)); //Should be false because ship is already placed
            Assert.IsFalse(board.Place(ships[1], 0, 0, Orientation.Horizontal)); // Should be false because ship does not fit there
            Assert.IsFalse(board.Place(ships[1], 9, 9, Orientation.Horizontal)); // Should be false because ship does not fit there
            Assert.IsTrue(board.Place(ships[1], 0, 1, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[2], 0, 2, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[3], 0, 3, Orientation.Horizontal));
            Assert.IsTrue(board.Place(ships[4], 0, 4, Orientation.Horizontal));
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


           Assert.IsTrue(board.ShipFits(ships[0], 0 , 0 , Orientation.Vertical));
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
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            Cell[,] actual;
            actual = target.Cells;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Columns
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ColumnsTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Columns;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOver
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void IsOverTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOver;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void RowsTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Rows;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShipsLeftToPlace
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ShipsLeftToPlaceTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            IShip[] actual;
            actual = target.ShipsLeftToPlace;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
