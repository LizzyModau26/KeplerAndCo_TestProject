using TestProject2023.Drivers;
using TestProject2023.PageObjects.Login;
using TechTalk.SpecFlow;

namespace TestProject2023.Steps.Login
{
    [Binding]
    public class IncorrectLoginStep
    {
        private readonly IncorrectLoginPageObject incorrectLoginPageObject;

        public IncorrectLoginStep(BrowserDriver browserDriver)
        {
            incorrectLoginPageObject = new IncorrectLoginPageObject(browserDriver.Current);
        }

        [Given("that the login form is loaded")]
        public void GivenThatTheLoginFormIsDisplayed()
        {
            incorrectLoginPageObject.Navigate();
            Thread.Sleep(7000);
        }

        [When("I enter the incorrect login details Login_email and Login_password.")]
        public void WhenIEnterTheIncorrectEmailAndPassword(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                    Console.WriteLine(value);
            }
            foreach (TableRow row in table.Rows)
            {
                incorrectLoginPageObject.EnterInvalidLoginDetails(row[0], row[1]);
            }
        }

        [When(@"I click on the sign in button")]
        public void WhenIClickOnTheLoginButton()
        {
            incorrectLoginPageObject.ClickLogin();
            Thread.Sleep(5000);
        }

        [Then(@"I should not be redirected to the homescreen\.")]
        public void ThenIShouldBeRedirectedToTheHomescreen_()
        {

        }

    }
}
