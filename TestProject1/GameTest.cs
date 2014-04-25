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

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        /// <summary>
        ///A test for Game Constructor
        ///</summary>
        [TestMethod()]
        public void GameConstructorTest()
        {
            Game target = new Game();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Fire
        ///</summary>
        [TestMethod()]
        public void FireTest()
        {
            Game target = new Game(); // TODO: Initialize to an appropriate value
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
        public void NewGameTest()
        {
            Game target = new Game(); // TODO: Initialize to an appropriate value
            target.NewGame();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Boards
        ///</summary>
        [TestMethod()]
        public void BoardsTest()
        {
            Game target = new Game(); // TODO: Initialize to an appropriate value
            IBoard[] actual;
            actual = target.Boards;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOver
        ///</summary>
        [TestMethod()]
        public void IsOverTest()
        {
            Game target = new Game(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOver;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Turn
        ///</summary>
        [TestMethod()]
        public void TurnTest()
        {
            Game target = new Game(); // TODO: Initialize to an appropriate value
            Player actual;
            actual = target.Turn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
