namespace API.Tests.Tests
{
    public class PetTests : BaseApiTest
    {
        [Fact]
        public async Task TestGetEndpoint()
        {
            var response = await _apiContext.GetAsync("/v2/pet/findByStatus?status=available");
            Assert.True(response.Ok);
            var content = await response.JsonAsync();
            Assert.True(content.HasValue);
        }
    }
}
