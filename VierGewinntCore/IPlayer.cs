namespace VierGewinntCore
{
    public interface IPlayer
    {
        string Name { get; set; }

    }

    public class Player : IPlayer
    {

        public Player(string name)
        {
            Name = name;

        }

        public string Name { get; set; }

    }
}