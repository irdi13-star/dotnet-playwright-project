using Microsoft.Playwright;
using Tests.Utils;

namespace Tests.Pages;

[TestFixture]
public class LoginPage(IPage page) : CommonPage(page)
{
    private static LabelsAndStrings _labels = LabelsLoader.Load("Tests/Resources/labels_and_strings.json");

    // Locatori
    private ILocator UsernameInput => Page.Locator("#username");
    private ILocator PasswordInput => Page.Locator("#password");
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

    public async Task<string> GetErrorMessage()
    {
        return await ErrorMessage.InnerTextAsync();
    }

    // Workflow complet folosit des
    public async Task LoginAs(string username, string password)
    {
        await EnterUsername(username);
        await EnterPassword(password);
        await ClickButtonByName(_labels.loginPage.loginButton);
    }

    public async Task ErrorMessageAsExpected(string errorMessage)
    {
        await Assertions.Expect(ErrorMessage).ToContainTextAsync(errorMessage);
    }
}
