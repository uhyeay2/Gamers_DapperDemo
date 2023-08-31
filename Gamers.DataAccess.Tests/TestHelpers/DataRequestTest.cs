using Gamers.DataAccess.Abstraction;
using Gamers.DataAccess.Implementation;

namespace Gamers.DataAccess.Tests.TestHelpers
{
    public abstract class DataRequestTest
    {
        protected IDataAccess _dataAccess;

        public DataRequestTest()
        {
            _dataAccess = new Implementation.DataAccess(new DbConnectionFactory(Hidden.DbConnectionString));
        }
    }
}
