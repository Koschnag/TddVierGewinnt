using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VierGewinntCore;
using CoreTests.Dummy;

namespace CoreTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void CreateCell()
        {
            ICell cell = new Cell(0);
            Assert.AreEqual(cell.X, 0);
            Assert.AreEqual(cell.Y, 0);
        }

        [TestMethod]
        public void PlaceChipInCell()
        {
            IChip chip= new ChipDummy();
            ICell cell = new Cell(0);
            cell.PlaceChip(chip);
            Assert.AreEqual(cell.Chip.PlayerID,2);
        }
    }
}
