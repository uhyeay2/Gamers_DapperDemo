using System.Data;

namespace Gamers.DataAccess.Abstraction
{
    internal interface IDbConnectionFactory
    {
        public IDbConnection NewConnection();
    }
}
