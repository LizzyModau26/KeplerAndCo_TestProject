using OpenQA.Selenium;

namespace TestProject2023.PageObjects.Register
{
    public class RegisterPageObject
    {
        private string RegisterURL = "https://lizzy.keplerqa.xyz/account/register";

        private readonly IWebDriver driver;

        public RegisterPageObject(IWebDriver driver)
        {

            this.driver = driver;
        }

        private IWebElement NewEmail => driver.FindElement(By.Id("email"));
        private IWebElement NewPassword => driver.FindElement(By.Id("password"));
        private IWebElement ConfirmPassword => driver.FindElement(By.Id("confirmPassword"));
        private IWebElement RegisterButton => driver.FindElement(By.ClassName("buttonWrapper"));


        public void Navigate()
        {
            driver.Navigate().GoToUrl(RegisterURL);
            Thread.Sleep(7000);
        }

        public void EnterNewDetails(string newEmail, string newPassword, string confirmPassword)
        {
            NewEmail.Clear();
            NewEmail.SendKeys(newEmail);
            NewPassword.Clear();
            NewPassword.SendKeys(newPassword);
            ConfirmPassword.Clear();
            ConfirmPassword.SendKeys(confirmPassword);

        }

        public void ClickRegister()
        {
            RegisterButton.Click();
            
        }

        public void EnsureRegisterPageIsOpenAndReset()
        {
            if (driver.Url != RegisterURL)
            {
                driver.Navigate().GoToUrl(this.RegisterURL);
            }
            else
            {
                driver.Close();
            }
        }
    }
}
