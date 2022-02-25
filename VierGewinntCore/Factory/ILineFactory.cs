using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinntCore.Factory
{
    public interface ILineFactory
    {
        ILine Create(int length);
    }

    public class DropableLineFactory : ILineFactory
    {
        public ILine Create(int length)
        {
            IList<ICell> cells = new List<ICell>();   

            for(int i=0; i<length; i++)
            {
                cells.Add(new Cell(i));
            }

            ILine line = new DropableLine(cells);
            return line;
        }
    }
}
