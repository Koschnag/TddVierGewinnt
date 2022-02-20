using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinntCore.Factory
{
    public interface LineFactory
    {
        ILine Create(int length);
    }

    public class DropableLineFactory : LineFactory
    {
        public ILine Create(int length)
        {
            IList<ICell> cells = new List<ICell>();   

            for(int i=0; i<length; i++)
            {
                cells.Add(new Cell());
            }

            ILine line = new DropableLine(cells);
            return line;
        }
    }
}
