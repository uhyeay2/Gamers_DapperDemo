using Gamers.DataAccess.Abstraction;
using System.Data;
using System.Data.SqlClient;

namespace Gamers.DataAccess.Implementation
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString) => _connectionString = connectionString;

        public IDbConnection NewConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
