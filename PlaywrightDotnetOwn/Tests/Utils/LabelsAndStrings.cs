namespace Tests.Utils;

public class LabelsAndStrings
{
    public HomePageLabels homePgae { get; set; } = new();
    public LoginPageLabels loginPage { get; set; } = new();
    public LoggedInPageLabels successfullyLoggedInPage { get; set; } = new();
    public CommonStrings commonStrings { get; set; } = new();
}

public class HomePageLabels
{
    public string headerTitle { get; set; } = "";
    public WelcomeSection welcomeSection { get; set; } = new();
    public ExperienceSection experienceSection { get; set; } = new();
    public BeyondSection beyondSection { get; set; } = new();
    public CoursesSection coursesSection { get; set; } = new();
    public ResourcesSection resourcesSection { get; set; } = new();
    public LookingAheadSection lookingAheadSection { get; set; } = new();
    public ExploreAndLearnSection exploreAndLearnSection { get; set; } = new();
    public MenuListLabels menuListLabels { get; set; } = new();
}

public class WelcomeSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
}

public class ExperienceSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
}

public class BeyondSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
}

public class CoursesSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
    public string nineCoursesLinkedLabel { get; set; } = "";
    public string bestSellerLinkedLabel { get; set; } = "";
    public string highestRatedLinkedLabel { get; set; } = "";
}

public class ResourcesSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
    public string articlesLinkedLabel { get; set; } = "";
    public string practicalPlatformLinkedLabel { get; set; } = "";
}

public class LookingAheadSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
}

public class ExploreAndLearnSection
{
    public string header { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
    public string blogLinkedLabel { get; set; } = "";
    public string coursesLinkedLabel { get; set; } = "";
}

public class MenuListLabels
{
    public string home { get; set; } = "";
    public string practice { get; set; } = "";
    public string courses { get; set; } = "";
    public string blog { get; set; } = "";
    public string contact { get; set; } = "";
}

public class LoginPageLabels
{
    public string headerTitle { get; set; } = "";
    public string invalidUsernameError { get; set; } = "";
    public string invalidPasswordError { get; set; } = "";
    public string loginButton { get; set; } = "";
}

public class LoggedInPageLabels
{
    public string headerTitle { get; set; } = "";
    public string descriptionLabel { get; set; } = "";
    public string logoutButton { get; set; } = "";
}

public class CommonStrings
{
    public string submitButtonTitle { get; set; } = "";
}
