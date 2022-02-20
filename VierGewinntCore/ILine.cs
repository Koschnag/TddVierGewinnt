namespace VierGewinntCore
{
    public interface ILine
    {
        IList<ICell> Cells { get; }
    }

    public class DropableLine : ILine
    {
        IList<ICell> cells;
        public IList<ICell> Cells { get { return cells; } }
        public DropableLine(IList<ICell> cells)
        {
            this.cells = cells;
        }
        public void DropChip(IChip chip)
        {
            foreach (ICell cell in cells)
            {
                if (cell.IsFilled==false)
                {
                    cell.PlaceChip(chip);
                    return;
                }
            }
            throw new InvalidOperationException("Line is already full.");
        }

    }

}