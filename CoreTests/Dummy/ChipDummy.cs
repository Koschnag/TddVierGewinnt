using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinntCore;

namespace CoreTests.Dummy
{
    public class ChipDummy : IChip
    {
        int _playerID = 2;
        public int PlayerID { get { return _playerID; } }
    }
}
