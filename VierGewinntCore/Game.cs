namespace VierGewinntCore
{
    public class Game : IGame
    {
        IList<IPlayer> players;

        IBoard Board;

        public int RoundCounter { get; set; }
        public int TurnNumber { get; set; }

        public IPlayer CurrentPlayer
        {
            get { return players[TurnNumber-1]; }
        }
        public IList<IPlayer> Players
        {
            get { return players; }
        }

        public Game(IList<IPlayer> players, IBoard board)
        {
            this.players = players;
            this.Board = board;
            RoundCounter = 1;
            TurnNumber = 1;
        }

        public void TakeTurn(int colNumber)
        {
            Board.DropChip(colNumber);
            TurnNumber++;
        }
    }

    public interface IGame
    {
        void TakeTurn(int colNumber);
        IList<IPlayer> Players { get; }
        IPlayer CurrentPlayer { get; }
    }
}