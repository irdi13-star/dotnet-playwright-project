using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo.Tests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTests : PageTest
{
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLink()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        // Create a locator
        var getStarted = Page.GetByRole(AriaRole.Link, new() { Name = "Get started" });

        // Expect an attribute "to be strictly equal" to the value.
        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        // Click the get started link.
        await getStarted.ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
    }

    [Test]
    public async Task SearchFunctionality()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Click on search button
        await Page.GetByRole(AriaRole.Button, new() { Name = "Search" }).ClickAsync();

        // Type in search box
        await Page.GetByPlaceholder("Search docs").FillAsync("getting started");

        // Verify search results appear
        await Expect(Page.GetByRole(AriaRole.Link, new() { NameRegex = new Regex("Getting started", RegexOptions.IgnoreCase) }).First).ToBeVisibleAsync();
    }
}