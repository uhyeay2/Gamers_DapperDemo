using Gamers.DataAccess.Abstraction;
using Gamers.DataAccess.DataRequests.GamePlayers;
using Microsoft.AspNetCore.Mvc;

namespace Gamers.Api.Controllers
{
    public class GamePlayerController
    {
        private readonly IDataAccess _dataAccess;

        public GamePlayerController(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpPost("InsertGamePlayer")]
        public async Task<int> InsertGamePlayer(InsertGamePlayer request)
        {
            return await _dataAccess.ExecuteAsync(request);
        }
    }
}
