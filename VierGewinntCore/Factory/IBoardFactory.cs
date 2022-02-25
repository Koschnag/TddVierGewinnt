namespace VierGewinntCore.Factory
{
    public interface IBoardFactory
    {
        IBoard Create(ILineFactory lineFactory, int colNum, int colLength);
    }

    public class BoardFactory : IBoardFactory
    {
        public IBoard Create(ILineFactory lineFactory, int colNum, int colLength)
        {
            IList<ILine> columns = new List<ILine>();
            for (int i = 0; i < colNum; i++)
            {
                columns.Add(lineFactory.Create(colLength));
            }
            IBoard Board = new Board(columns);
            return Board;
        }
    }
}
