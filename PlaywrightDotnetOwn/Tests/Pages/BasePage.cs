using Microsoft.Playwright;

namespace Tests.Pages;

public abstract class BasePage(IPage page)
{
    protected readonly IPage Page = page;

    public virtual async Task GotoAsync(string url)
    {
        await Page.GotoAsync(url);
    }
}
