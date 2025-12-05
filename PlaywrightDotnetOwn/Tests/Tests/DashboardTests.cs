using Microsoft.Playwright.NUnit;
using Tests.Pages;
using Tests.Utils;

namespace Tests.Tests;

[TestFixture]
public class DashboardTests : PageTest
{
    [Test]
    public async Task Dashboard_Should_Load_After_Login()
    {
        var login = new LoginPage(Page);
        await login.GotoAsync(TestConfig.BaseUrl + "/login");
        await login.LoginAs("testuser", "Password123!");

        var dashboard = new DashboardPage(Page);
        Assert.That(await dashboard.IsLoaded(), Is.True);
    }
}
