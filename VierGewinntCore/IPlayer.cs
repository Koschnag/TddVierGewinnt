namespace VierGewinntCore
{
    public interface IPlayer
    {
        int PlayerID { get; }
        string Name { get; set; }

    }

    public class Player : IPlayer
    {

        public Player(string name, int id)
        {
            Name = name;
            _playerID = id;
        }

        public string Name { get; set; }

        readonly int _playerID;
        public int PlayerID { get { return _playerID; } }
    }
}