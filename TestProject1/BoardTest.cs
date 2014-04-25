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
        [TestMethod]
        public void TestMethod1()
        {
        }

        /// <summary>
        ///A test for Board Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void BoardConstructorTest()
        {
            Board_Accessor target = new Board_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Fire
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void FireTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Fire(row, column);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NewGame
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void NewGameTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            target.NewGame();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Place
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void PlaceTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            IShip ship = null; // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            Orientation orientation = new Orientation(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Place(ship, row, column, orientation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShipFits
        ///</summary>
        [TestMethod()]
        [DeploymentItem("bs.exe")]
        public void ShipFitsTest()
        {
            Board_Accessor target = new Board_Accessor(); // TODO: Initialize to an appropriate value
            IShip ship = null; // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            Orientation orientation = new Orientation(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShipFits(ship, row, column, orientation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
