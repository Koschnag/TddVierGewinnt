using CoreTests.Dummy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VierGewinntCore;
using VierGewinntCore.Factory;

namespace CoreTests
{
    [TestClass]
    public class LineTests
    {
        [TestMethod]
        public void CreateLine()
        {
            ILineFactory lineFactory = new DropableLineFactory();
            var testTarget = lineFactory.Create(7);
            Assert.AreEqual(testTarget.Cells.Count, 7);
        }

        [TestMethod]
        public void DropChipIntoColumn()
        {
            ILineFactory lineFactory = new DropableLineFactory();
            var testTarget = (DropableLine)lineFactory.Create(7);
            testTarget.DropChip(new ChipDummy());
            Assert.IsNotNull(testTarget.Cells[0].Chip);
        }

        [TestMethod]
        public void CheckIfColumnIsFull()
        {

            ILineFactory lineFactory = new DropableLineFactory();
            var testTarget = (DropableLine)lineFactory.Create(7);
            for (int i = 0; i < 7; i++)
            {
                testTarget.DropChip(new ChipDummy());
            }
            Assert.ThrowsException<InvalidOperationException>(() => testTarget.DropChip(new ChipDummy()));
        }
    }
}
