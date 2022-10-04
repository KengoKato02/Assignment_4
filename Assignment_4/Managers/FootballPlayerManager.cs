using MandaAssig_1;

namespace Assignment_4.Managers
{
    public class FootballPlayerManager
    {
        private static int _nextId = 1;
        private int Id = 0;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextId++, Name = "Ronaldo", Age = 32, shirtNumber = 7},
            new FottballPlayer {Id = _nextId++, Name = "Messi", Age = 28, shirtNumber = 10},
            new FottballPlayer {Id = _nextId++, Name = "Kacper", Age = 20, shirtNumber = 99},
            new FottballPlayer {Id = _nextId++, Name = "Pawel", Age = 90, shirtNumber = 69}
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }
        public FootballPlayer GetByID(int id)
        {
            return Data.Find(player => player.Id == id);
        }
        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Id = _nextId++;
            Data.Add(newPlayer);
            return newPlayer;
        }
        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer player = Data.Find(player1 => player1.Id == id);
            if (player == null)
            {
                return null;
            }
            else
            {
                Data.Remove(player);
                return player;
            }

        }
        public FootballPlayer Delete(int id)
        {
            FootballPlayer book = Data.Find(player1 => player1.Id == id);
            if (book == null)
            {
                return null;
            }
            else
            {
                Data.Remove(book);
                return book;
            }
        }
    }
}