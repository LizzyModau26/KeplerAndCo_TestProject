using TestProject2023.Drivers;
using TestProject2023.PageObjects.Login;
using TechTalk.SpecFlow;

namespace TestProject2023.Hooks
{
    [Binding]
    public class LoginHook
    {
        [BeforeScenario("Login")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var loginPageObject = new LoginPageObject(browserDriver.Current);
            loginPageObject.EnsureLoginPageIsOpenAndReset();
        }

        [BeforeScenario("IncorrectLogin")]
        public static void BeforeNegativeScenario(BrowserDriver browserDriver)
        {
            var incorrectLoginPageObject = new IncorrectLoginPageObject(browserDriver.Current);
            incorrectLoginPageObject.EnsureLoginPageIsOpenAndReset();
        }
    }
}
