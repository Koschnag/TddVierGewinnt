namespace VierGewinntCore
{
    public interface ICell
    {
        int X { get; set; }
        int Y { get; set; } 
        IChip Chip { get;}
        void PlaceChip(IChip chip);
    }

    public class Cell : ICell
    {
        public int X { get; set; }
        public int Y { get; set; }
        IChip _chip;
        public IChip Chip { get { return _chip; } }

        public void PlaceChip(IChip chip) {
            _chip = chip;
        }
    }

}