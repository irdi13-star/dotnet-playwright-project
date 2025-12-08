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
        var data = TestDataLoader.LoadJson<LoginTestData>("Tests/Resources/testData.json");
        var user = data.validUser;
        var login = new LoginPage(Page);
        await login.GotoAsync(TestConfig.LoginPage);
        await login.LoginAs(user.username, user.password);

        var dashboard = new DashboardPage(Page);
        Assert.That(await dashboard.IsLoaded(), Is.True);
        await dashboard.LogOutIsVisible();
    }
}
