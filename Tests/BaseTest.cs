using Microsoft.Playwright;
using System.Text.Json;

namespace PlaywrightCSharp.Tests
{
    public abstract class BaseTest : IAsyncLifetime
    {
        protected IPlaywright? _playwright;
        protected IBrowser? _browser;
        protected IPage? _page;
        protected string? _baseUrl;

        public async Task InitializeAsync()
        {
            var config = ConfigSettings.LoadConfig();
            _baseUrl = config.BaseUrl;
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright[config.Browser.ToLower()].LaunchAsync(new BrowserTypeLaunchOptions { Headless = config.Headless });
            _page = await _browser.NewPageAsync();
        }

        public async Task DisposeAsync()
        {
            await _browser.CloseAsync();
            _playwright?.Dispose();
        }
    }
}
