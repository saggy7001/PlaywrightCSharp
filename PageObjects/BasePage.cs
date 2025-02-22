using Microsoft.Playwright;

public abstract class BasePage
{
    protected IPage Page;
    protected string BaseUrl;

    public BasePage(IPage page, string baseUrl)
    {
        Page = page;
        BaseUrl = baseUrl;
    }

    public async Task<bool> IsElementVisibleAsync(string selector)
    {
        return await Page.IsVisibleAsync(selector);
    }
}
