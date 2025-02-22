using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace API.Tests.Tests
{
    public abstract class BaseApiTest : IAsyncLifetime
    {
        protected IAPIRequestContext _apiContext;
        protected string _baseUrl;
        
        public BaseApiTest()
        {
            var config = ConfigSettings.LoadConfig();
            _baseUrl = config.BaseUrl;
        }

        public async Task InitializeAsync()
        {
            var playwright = await Playwright.CreateAsync();
            _apiContext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions
            {
                BaseURL = _baseUrl,
                ExtraHTTPHeaders = new Dictionary<string, string>
            {
                { "Authorization", "Bearer YOUR_TOKEN_HERE" },
                { "Accept", "application/json" }
            }
            });
        }

        public async Task DisposeAsync()
        {
            await _apiContext.DisposeAsync();
        }
    }
}
