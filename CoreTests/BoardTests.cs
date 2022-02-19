using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VierGewinntCore;
using CoreTests.Dummy;

namespace CoreTests
{
    [TestClass]
    public class BoardTests
    {
        IBoard Board= new Board();

        [TestMethod]
        public void ChipDropTest()
        {
            Board.DropChip(0);
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void CheckWinVertical()
        {
            throw new System.NotImplementedException();
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
