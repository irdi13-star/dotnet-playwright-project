using Microsoft.Playwright;

namespace Tests.Pages;

public class DashboardPage(IPage page) : BasePage(page)
{
    private ILocator Header => Page.Locator("h1");
    private ILocator LogoutButton => Page.GetByRole(AriaRole.Link, new() { Name = "Log out" });

    public async Task<bool> IsLoaded()
    {
        return await Header.IsVisibleAsync();
    }

    public async Task<bool> LogOutIsVisible()
    {
        return await LogoutButton.IsVisibleAsync();
    }
}
