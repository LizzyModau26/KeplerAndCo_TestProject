

using OpenQA.Selenium;

namespace TestProject2023.PageObjects.Login
{
    public class IncorrectLoginPageObject
    {
        private string CompanyURL = "https://lizzy.keplerqa.xyz/";

        private readonly IWebDriver driver;

        public IncorrectLoginPageObject(IWebDriver driver)
        {

            this.driver = driver;
        }

        private IWebElement InvalidLoginEmail => driver.FindElement(By.Id("email"));
        private IWebElement InvalidLoginPassword => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.ClassName("buttonWrapper"));


        public void Navigate()
        {
            driver.Navigate().GoToUrl(CompanyURL);
        }

        public void EnterInvalidLoginDetails(string invalidLoginEmail, string invalidLoginPassword)
        {
            InvalidLoginEmail.Clear();
            InvalidLoginEmail.SendKeys(invalidLoginEmail);
            InvalidLoginPassword.Clear();
            InvalidLoginPassword.SendKeys(invalidLoginPassword);

        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public void EnsureLoginPageIsOpenAndReset()
        {
            if (driver.Url != CompanyURL)
            {
                driver.Navigate().GoToUrl(this.CompanyURL);
            }
            else
            {
                driver.Close();
            }
        }
    }
}
