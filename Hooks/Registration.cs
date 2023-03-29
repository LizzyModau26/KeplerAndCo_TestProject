using TestProject2023.Drivers;
using TestProject2023.PageObjects.Register;
using TechTalk.SpecFlow;

namespace TestProject2023.Hooks
{
    [Binding]
    public class RegistrationHook
    {
        [BeforeScenario("Register")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var registerPageObject = new RegisterPageObject(browserDriver.Current);
            registerPageObject.EnsureRegisterPageIsOpenAndReset();
        }
    }
}