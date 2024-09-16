using Microsoft.AspNetCore.Mvc;
using DiscGolfWebAPI.Models;
using DiscGolfWebAPI.Services;

namespace DiscGolfWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscGolfController : ControllerBase
    {

        private readonly ILogger<DiscGolfController> _logger;
        private IDataService _dataService;

        public DiscGolfController(ILogger<DiscGolfController> logger, IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        [HttpGet("GetPlayers")]
        public IEnumerable<Player> Get()
        {
            return _dataService.GetPlayers();
        }

        [HttpGet("GetPlayer/{id}")]
        public Player? Get(uint id)
        {
            return _dataService.GetPlayerById(id);
        }
    }
}
