using TestProject2023.Drivers;
using TestProject2023.PageObjects.Register;
using TechTalk.SpecFlow;

namespace TestProject2023.Steps.Register
{
    [Binding]
    public class RegisterStep
    {

        private readonly RegisterPageObject registerPageObject;

        public RegisterStep(BrowserDriver browserDriver)
        {
            registerPageObject = new RegisterPageObject(browserDriver.Current);
        }

        [Given("that the account registration page is dislayed.")]
        public void GivenThatTheAccountRegistrationPageIsDislayed()
        {
            registerPageObject.Navigate();
            Thread.Sleep(9000);
        }

        [When("I enter my correct credentials Reg_email , Reg_password and Confirm_password")]
        public void WhenIEnterTheNewEmail_PaswordAndConfirmPassword(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                    Console.WriteLine(value);
            }
            foreach (TableRow row in table.Rows)
            {
                registerPageObject.EnterNewDetails(row[0], row[1], row[2]);
            }
        }

        [When(@"I click the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            registerPageObject.ClickRegister();
            Thread.Sleep(7000);
        }

        [Then(@"I Should be redirected to a email verification page")]
        public void ThenIShouldBeRedirectedToTheEmailVerificationScreen()
        {

        }

    }
}
