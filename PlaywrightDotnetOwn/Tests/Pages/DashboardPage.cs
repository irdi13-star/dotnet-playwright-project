using Microsoft.Playwright;

namespace Tests.Pages;

public class DashboardPage(IPage page) : BasePage(page)
{
    private ILocator Header => Page.Locator("h1");

    public async Task<bool> IsLoaded()
    {
        return await Header.IsVisibleAsync();
    }
}
