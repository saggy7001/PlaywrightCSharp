using Microsoft.Playwright;
using Xunit;

namespace PlaywrightCSharp.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IPage page, string baseUrl) : base(page, baseUrl) { }

        public async Task NavigateAsync() => await Page.GotoAsync(BaseUrl);
        public async Task OpenAlertPage()
        {
            await Page.ClickAsync("xpath=//button[@onclick=\"openTab(event, 'Alert')\"]");
        }

        public async Task<bool> IsSimpleAlertBtnDisplayedAsync()
        {
            return await IsElementVisibleAsync("xpath=//button[@onclick='clickSimpleAlert()']");
        }
    }
}
