using Gamers.DataAccess.Abstraction;
using Gamers.Domain.Models;

namespace Gamers.DataAccess.DataRequests.GamePlayers
{
    public class GetGamePlayerByEmail : IDataRequest<GamePlayer>
    {
        public GetGamePlayerByEmail(string email) => Email = email;

        public string Email { get; set; }

        public object GetParameters() => this;

        public string GetSql() => "SELECT * FROM GamePlayers WITH(NOLOCK) WHERE Email = @Email";
    }
}
