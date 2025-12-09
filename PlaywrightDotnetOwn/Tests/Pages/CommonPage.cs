using Microsoft.Playwright;

namespace Tests.Pages;

public class CommonPage(IPage page) : BasePage(page)
{
    //Locators
    private ILocator HeaderByName(string header) => Page.GetByRole(AriaRole.Heading, new() { Name = header });
    private ILocator ButtonByName(string buttonTitle) => Page.GetByRole(AriaRole.Button, new() { Name = buttonTitle });


    //Methods
    public async Task<bool> HeaderByNameIsVisible(string header)
    {
        return await HeaderByName(header).IsVisibleAsync();
    }

    public async Task<bool> ButtonByNameIsVisible(string buttonTitle)
    {
        return await ButtonByName(buttonTitle).IsVisibleAsync();
    }

    public async Task ClickButtonByName(string buttonTitle)
    {
        await ButtonByName(buttonTitle).ClickAsync();
    }

    public async Task PageUrlAsExpected(string expectedUrl)
    {
        await Page.WaitForLoadStateAsync(LoadState.Load);
        Assert.That(Page.Url, Is.EqualTo(expectedUrl));
    }
}
