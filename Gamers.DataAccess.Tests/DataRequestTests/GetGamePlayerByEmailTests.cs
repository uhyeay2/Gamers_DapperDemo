using Gamers.DataAccess.DataRequests.GamePlayers;
using Gamers.DataAccess.Tests.TestHelpers;

namespace Gamers.DataAccess.Tests.DataRequestTests
{
    public class GetGamePlayerByEmailTests : DataRequestTest
    {
        [Fact]
        public async Task GetGamePlayerByEmail_Given_Email_ShouldReturn_Player()
        {
            var request = new GetGamePlayerByEmail("Email");

            var result = await _dataAccess.FetchAsync(request);

            Assert.NotNull(result);
        }
    }
}
