using BoDi;
using TestProject2023.Drivers;
using TechTalk.SpecFlow;


namespace TestProject2023.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        [BeforeTestRun]

        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
