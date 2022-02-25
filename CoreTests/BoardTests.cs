using CoreTests.Dummy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VierGewinntCore;
using VierGewinntCore.Factory;

namespace CoreTests
{
    [TestClass]
    public class BoardTests
    {

        IBoard testTarget;
        [TestMethod]
        public void CreateBoardTest()
        {           
            ILineFactory lineFactory = new DropableLineFactory();
            IBoardFactory boardFactory = new BoardFactory();
            testTarget= boardFactory.Create(lineFactory, 7,6);
            Assert.AreEqual(testTarget.Columns.Count,7);
            Assert.AreEqual(testTarget.Columns[0].Cells.Count, 6);
        }

        [TestMethod]
        public void ChipDropTest()
        {
            ILineFactory lineFactory = new DropableLineFactory();
            IBoardFactory boardFactory = new BoardFactory();
            testTarget = boardFactory.Create(lineFactory, 7, 6);
            IChip dummy = new ChipDummy();
            testTarget.DropChip(4, dummy);
            Assert.AreEqual(testTarget.Columns[4].Cells[0].Chip, dummy);
        }

        [TestMethod]
        public void CheckWinVertical()
        {
            ILineFactory lineFactory = new DropableLineFactory();
            IBoardFactory boardFactory = new BoardFactory();
            testTarget = boardFactory.Create(lineFactory, 7, 6);
            IChip chip = new ChipDummy();
            IPlayer player = new PlayerDummy();
            testTarget.DropChip(2, chip);
            testTarget.DropChip(2, chip);
            testTarget.DropChip(2, chip);
            testTarget.DropChip(2, chip);
            testTarget.DropChip(2, chip);
            Assert.AreEqual(true, testTarget.IsConnected(player,4));
        }

        [TestMethod]
        public void CheckWinHorizontal()
        {
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void CheckWinDiagonalLeft()
        {
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void CheckWinDiagonalRight()
        {
            throw new System.NotImplementedException();
        }

    }
}
