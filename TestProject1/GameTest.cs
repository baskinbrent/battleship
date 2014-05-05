using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bs;
using Battleship;

namespace TestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class GameTest
    {
        public GameTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        /// <summary>
        ///A test for Fire
        ///</summary>
        [TestMethod()]
        public void FireTest()
        {
            IGame target = new Game();
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);
            Assert.IsTrue(target.Fire(0, 0));
            Assert.IsTrue(target.Fire(0, 0));
            Assert.IsTrue(target.Fire(9, 9));
            Assert.IsTrue(target.Fire(9, 9));


        }

        /// <summary>
        ///A test for NewGame
        ///</summary>
        [TestMethod()]
        public void NewGameTest()
        {
            Game target = new Game();
            Assert.AreEqual(target.Turn, Player.Human);
            Assert.AreEqual(target.Turns, 0);
        }

        /// <summary>
        ///A test for IsOver
        ///</summary>
        [TestMethod()]
        public void IsOverTest()
        {
            Game target = new Game();
            bool actual;

            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);
            actual = target.IsOver;
            Assert.IsFalse(actual);

            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);
            
            target.Fire(0, 0); target.Fire(0, 0);
            target.Fire(0, 1); target.Fire(0, 1);
            target.Fire(0, 2); target.Fire(0, 2);
            target.Fire(0, 3); target.Fire(0, 3);
            target.Fire(0, 4); target.Fire(0, 4);

            target.Fire(1, 0); target.Fire(1, 0);
            target.Fire(1, 1); target.Fire(1, 1);
            target.Fire(1, 2); target.Fire(1, 2);
            target.Fire(1, 3); target.Fire(1, 3);

            target.Fire(2, 0); target.Fire(2, 0);
            target.Fire(2, 1); target.Fire(2, 1);
            target.Fire(2, 2); target.Fire(2, 2);

            target.Fire(3, 0); target.Fire(3, 0);
            target.Fire(3, 1); target.Fire(3, 1);
            target.Fire(3, 2); target.Fire(3, 2);

            target.Fire(4, 0); target.Fire(4, 0);
            target.Fire(4, 1); target.Fire(4, 1);


            actual = target.IsOver;
            Assert.IsTrue(actual);

        }

        /// <summary>
        ///A test for Turn
        ///</summary>
        [TestMethod()]
        public void TurnTest()
        {
            Game target = new Game();
            Assert.AreEqual(target.Turn, Player.Human);

            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 0, 0, Orientation.Horizontal);

            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 1, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 2, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 3, 0, Orientation.Horizontal);
            target.Boards[0].Place(target.Boards[0].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);
            target.Boards[1].Place(target.Boards[1].ShipsLeftToPlace[0], 4, 0, Orientation.Horizontal);

            target.Fire(0, 0);
            Assert.AreEqual(target.Turn, Player.Computer);
            target.Fire(0, 1); 
            Assert.AreEqual(target.Turn, Player.Human);
            target.Fire(0, 2);
            Assert.AreEqual(target.Turn, Player.Computer);
            target.Fire(0, 3);
            Assert.AreEqual(target.Turn, Player.Human);
            target.Fire(0, 4);
            Assert.AreEqual(target.Turn, Player.Computer);


        }
    }
}
