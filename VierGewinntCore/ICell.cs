namespace VierGewinntCore
{
    public interface ICell
    {
        int X { get; set; }
        int Y { get; set; } 
        IChip Chip { get;}
        bool IsFilled { get;}
        void PlaceChip(IChip chip);
    }

    public class Cell : ICell
    {
        public int X { get; set; }
        public int Y { get; set; }
        IChip _chip;
        public IChip Chip { get { return _chip; } }

        bool _isFilled;

        public Cell(int y)
        {
            Y = y;
            _isFilled = false;
        }

        public bool IsFilled { get { return _isFilled; } }

        public void PlaceChip(IChip chip) {
            _chip = chip;
            _isFilled= true;
        }
    }

}