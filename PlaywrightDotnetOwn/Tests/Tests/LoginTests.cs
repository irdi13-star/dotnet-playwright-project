using Microsoft.Playwright.NUnit;
using Tests.Pages;
using Tests.Utils;


namespace Tests.Tests;

[TestFixture]
public class LoginTests : PageTest
{
    [Test]
    public async Task ValidLogin_ShouldRedirectToDashboard()
    {
        var data = TestDataLoader.LoadJson<LoginTestData>("Tests/Resources/testData.json");
        var user = data.validUser;

        var login = new LoginPage(Page);
        await login.GotoAsync(TestConfig.LoginPage);
        await login.LoginAs(user.username, user.password);

        var dashboard = new DashboardPage(Page);
        Assert.That(await dashboard.IsLoaded(), Is.True);
        Assert.That(Page.Url, Is.EqualTo(TestConfig.LoggedInPage));
        await dashboard.LogOutIsVisible();
    }

    [Test]
    public async Task InvalidLogin_ShouldShowError()
    {
        var data = TestDataLoader.LoadJson<LoginTestData>("Tests/Resources/testData.json");
        var user = data.invalidUser;
        var login = new LoginPage(Page);

        await login.GotoAsync(TestConfig.LoginPage);
        await login.LoginAs(user.username, user.password);

        Assert.That(await login.GetErrorMessage(), Is.EqualTo("Your username is invalid!"));
        Assert.That(Page.Url, Is.EqualTo(TestConfig.LoginPage));
    }
}
