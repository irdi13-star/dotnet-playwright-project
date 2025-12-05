using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Tests.Pages;
using Tests.Utils;

namespace Tests.Tests;

[TestFixture]
public class LoginTests : PageTest
{
    [Test]
    public async Task ValidLogin_ShouldRedirectToDashboard()
    {
        var login = new LoginPage(Page);

        await login.GotoAsync(TestConfig.BaseUrl + "/practice-test-login/");
        await login.LoginAs("student", "Password123");

        var dashboard = new DashboardPage(Page);
        Assert.That(await dashboard.IsLoaded(), Is.True);
    }

    [Test]
    public async Task InvalidLogin_ShouldShowError()
    {
        var login = new LoginPage(Page);

        await login.GotoAsync(TestConfig.BaseUrl + "/practice-test-login/");
        await login.LoginAs("testuser", "gresit");

        Assert.That(await login.GetErrorMessage(), Is.EqualTo("Your username is invalid!"));
    }
}
