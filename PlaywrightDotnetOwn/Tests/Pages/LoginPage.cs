using Microsoft.Playwright;

namespace Tests.Pages;

public class LoginPage(IPage page) : BasePage(page)
{

    // Locatori
    private ILocator UsernameInput => Page.Locator("#username");
    private ILocator PasswordInput => Page.Locator("#password");
    private ILocator LoginButton  => Page.Locator("#submit");
    private ILocator ErrorMessage => Page.Locator("#error");

    // Acțiuni
    public async Task EnterUsername(string username)
    {
        await UsernameInput.FillAsync(username);
    }

    public async Task EnterPassword(string password)
    {
        await PasswordInput.FillAsync(password);
    }

    public async Task ClickLogin()
    {
        await LoginButton.ClickAsync();
    }

    public async Task<string> GetErrorMessage()
    {
        return await ErrorMessage.InnerTextAsync();
    }

    // Workflow complet folosit des
    public async Task LoginAs(string username, string password)
    {
        await EnterUsername(username);
        await EnterPassword(password);
        await ClickLogin();
    }
}
