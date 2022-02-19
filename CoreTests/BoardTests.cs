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
            Board.Columns.Count;
        }
        [TestMethod]
        public void CheckWinVertical()
        {

        }
        [TestMethod]
        public void CheckWinHorizontal()
        {

        }
        [TestMethod]
        public void CheckWinDiagonalLeft()
        {

        }
        [TestMethod]
        public void CheckWinDiagonalRight()
        {

        }

    }
}
