using DiscGolfWebAPI.Models;

namespace DiscGolfWebAPI.Services
{
    /// <summary>
    /// Interface for retrieving Model data. De-couples DbContext from APIControllers, and allows for Service to be tested separately.
    /// </summary>
    public interface IDataService
    {
        public IEnumerable<Player> GetPlayers();
        public Player? GetPlayerById(uint id);
    }
}
