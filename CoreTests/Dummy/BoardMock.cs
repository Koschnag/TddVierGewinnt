using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinntCore;

namespace CoreTests.Dummy
{
    public class BoardMock : IBoard
    {
        public IList<ILine> Columns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DropChip(int colNumber)
        {
            
        }
    }
}
