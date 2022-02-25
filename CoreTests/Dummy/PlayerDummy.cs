using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinntCore;

namespace CoreTests.Dummy
{
    public class PlayerDummy : IPlayer
    {
        public int PlayerID => 2;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
