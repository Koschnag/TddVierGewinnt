using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VierGewinntCore;
using CoreTests.Dummy;

namespace CoreTests
{
    [TestClass]
    public class GameTests
    {
        static List<IPlayer> players = new List<IPlayer>
        {               
            new Player("Alice",0),
            new Player("Bob",1)
        };
        Game testTarget = new Game(players, new BoardMock());

        [TestMethod]
        public void CreateMultiplayerGame()
        {
            Assert.AreEqual(testTarget.RoundCounter, 1);
            Assert.AreEqual(testTarget.TurnNumber, 1);
        }

        [TestMethod]
        public void CheckPlayerNames()
        {
            var testTarget = this.testTarget.Players;
            Assert.AreEqual(testTarget[0].Name,"Alice");
            Assert.AreEqual(testTarget[1].Name, "Bob");
        }

        [TestMethod]
        public void CheckTurnSchedule()
        {
            IChip chip = new ChipDummy();
            testTarget.TakeTurn(0, chip);
            Assert.AreEqual(testTarget.TurnNumber, 2);
        }
    }
}