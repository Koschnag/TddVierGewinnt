namespace VierGewinntCore
{
    public interface IBoard
    {
        IList<ILine> Columns { get; set; }
        int numRows { get; set; }
        void DropChip(int colNumber, IChip chip);
        bool IsConnected(IPlayer player, int connectionLength);
    }

    public class Board : IBoard
    {
        public Board(IList<ILine> columns)
        {
            Columns = columns;
        }

        public IList<ILine> Columns { get; set; }
        public int numRows { get; set; }
        public bool IsConnected(IPlayer player, int connectionLength)
        {
            //Vertical
            foreach (var i in Columns)
            {
                int tempLength = 0;
                foreach (var j in i.Cells)
                {
                    if (j.IsFilled == true)
                    {
                        if (j.Chip.PlayerID == player.PlayerID)
                        {
                            tempLength++;
                            if (tempLength == connectionLength)
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        tempLength = 0;
                    }
                }
            }

            //Horizontal
            for (int i = 0; i < numRows; i++)
            {
                var tempLength = 0;
                foreach (var j in Columns)
                {
                    if (j.Cells[i].IsFilled)
                    {
                        if (j.Cells[i].Chip.PlayerID == player.PlayerID)
                            tempLength++;
                    }
                    if (tempLength == connectionLength)
                        return true;
                }
            }


            return false;
        }

        public void DropChip(int colNumber, IChip chip)
        {
            for (int i = 0; i < Columns[colNumber].Cells.Count; i++)
            {
                if (Columns[colNumber].Cells[i].IsFilled == false)
                {
                    Columns[colNumber].Cells[i].PlaceChip(chip);
                    return;
                }
            }
            throw new InvalidOperationException("Line is full");
        }
    }
}