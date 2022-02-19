namespace VierGewinntCore
{
    public interface IBoard
    {
        IList<ILine> Columns { get; set; }
        void DropChip(int colNumber);
    }

    public class Board : IBoard
    {
        public IList<ILine> Columns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DropChip(int colNumber)
        {
            throw new NotImplementedException();
        }
    }
}