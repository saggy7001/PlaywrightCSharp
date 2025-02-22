using PlaywrightCSharp.PageObjects;

namespace PlaywrightCSharp.Tests
{
    public class AlertTests : BaseTest
    {
        [Fact]
        public async Task OpenAlertPage()
        {
            var homePage = new HomePage(_page, _baseUrl);
            await homePage.NavigateAsync();
            await homePage.OpenAlertPage();
            await homePage.IsSimpleAlertBtnDisplayedAsync();
        }
    }
}
