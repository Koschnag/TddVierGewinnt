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
            new Player("Alice"),
            new Player("Bob")
        };
        Game game = new Game(players, new BoardMock());

        [TestMethod]
        public void CreateMultiplayerGame()
        {
            Assert.AreEqual(game.RoundCounter, 1);
            Assert.AreEqual(game.TurnNumber, 1);
        }

        [TestMethod]
        public void CheckPlayerNames()
        {
            var testTarget = game.Players;
            Assert.AreEqual(testTarget[0].Name,"Alice");
            Assert.AreEqual(testTarget[1].Name, "Bob");
        }

        [TestMethod]
        public void CheckTurnSchedule()
        {
            game.TakeTurn(0);
            Assert.AreEqual(game.TurnNumber, 2);
        }
    }
}