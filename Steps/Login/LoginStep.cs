using TestProject2023.Drivers;
using TestProject2023.PageObjects.Login;
using TechTalk.SpecFlow;

namespace TestProject2023.Steps.Login
{
    [Binding]
    public class LoginStep
    {
        private readonly LoginPageObject loginPageObject;

        public LoginStep(BrowserDriver browserDriver)
        {
            loginPageObject = new LoginPageObject(browserDriver.Current);
        }

        [Given("that the login form is displayed")]
        public void GivenThatTheLoginFormIsDisplayed()
        {
            loginPageObject.Navigate();
            Thread.Sleep(7000);
        }

        [When("I enter the correct login details Login_email and Login_password.")]
        public void WhenIEnterTheCorrectEmailAndPassword(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                    Console.WriteLine(value);
            }
            foreach (TableRow row in table.Rows)
            {
                loginPageObject.EnterLoginDetails(row[0], row[1]);
            }
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPageObject.ClickLogin();
            Thread.Sleep(5000);
        }

        [Then(@"I should be redirected to the homescreen\.")]
        public void ThenIShouldBeRedirectedToTheHomescreen_()
        {

        }

    }
}
