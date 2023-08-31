using Gamers.DataAccess.DataRequests.GamePlayers;
using Gamers.DataAccess.Tests.TestHelpers;

namespace Gamers.DataAccess.Tests.DataRequestTests
{
    public class InsertGamePlayerTests : DataRequestTest
    {
        [Fact]
        public async Task InsertGamePlayer_Given_ValidRequest_ShouldReturn_OneRowAffected()
        {
            var request = new InsertGamePlayer("FirstName", "LastName", "Email", "Gender", "IpAddress");

            var rowsAffected = await _dataAccess.ExecuteAsync(request);

            Assert.Equal(1, rowsAffected);
        }
    }
}
