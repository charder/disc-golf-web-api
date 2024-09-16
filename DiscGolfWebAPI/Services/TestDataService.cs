using DiscGolfWebAPI.Models;

namespace DiscGolfWebAPI.Services
{
    public class TestDataService : IDataService
    {
        public TestDataService() { }

        public IEnumerable<Player> GetPlayers()
        {
            return [
                new () { Id = 0, Name = "Caleb" },
                new () { Id = 1, Name = "Jeremy"}
            ];
        }

        public Player? GetPlayerById(uint id)
        {
            switch (id)
            {
                case 0: return new() { Id = 0, Name = "Caleb" };
                case 1: return new() { Id = 1, Name = "Jeremy" };
                default:
                    return null;
            }
        }
    }

}
