using Microsoft.Playwright.NUnit;
using Tests.Pages;
using Tests.Utils;


namespace Tests.Tests;

[TestFixture]

public class LoginTests : PageTest
{
    private LoginTestData _testData;

    [OneTimeSetUp]
    public void LoadTestData()
    {
        _testData = TestDataLoader.LoadJson<LoginTestData>("Tests/Resources/testData.json");
    }

    private static LabelsAndStrings _labels = LabelsLoader.Load("Tests/Resources/labels_and_strings.json");


    [Test]
    public async Task ValidLogin_ShouldRedirectToDashboard()
    {
        var login = new LoginPage(Page);
        await login.GotoAsync(TestConfig.LoginPage);
        await login.LoginAs(_testData.validUser.username, _testData.validUser.password);

        var common = new CommonPage(Page);
        await common.PageUrlAsExpected(TestConfig.LoggedInPage);

        var dashboard = new DashboardPage(Page);
        await dashboard.LogOutIsVisible();
    }

    [Test]
    public async Task InvalidLogin_ShouldShowError()
    {
        var login = new LoginPage(Page);
        await login.GotoAsync(TestConfig.LoginPage);
        await login.LoginAs(_testData.invalidUser.username, _testData.invalidUser.password);
        await login.ErrorMessageAsExpected(_labels.loginPage.invalidUsernameError);

        var common = new CommonPage(Page);
        await common.PageUrlAsExpected(TestConfig.LoginPage);
    }
}
