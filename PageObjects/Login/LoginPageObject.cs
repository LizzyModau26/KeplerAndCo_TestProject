using OpenQA.Selenium;

namespace TestProject2023.PageObjects.Login
{
    public class LoginPageObject
    {
        private string CompanyURL = "https://lizzy.keplerqa.xyz/";

        private readonly IWebDriver driver;

        public LoginPageObject(IWebDriver driver)
        {
           
            this.driver = driver;
        }

        private IWebElement LoginEmail => driver.FindElement(By.Id("email"));
        private IWebElement LoginPassword => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.ClassName("buttonWrapper"));


        public void Navigate()
        {
            driver.Navigate().GoToUrl(CompanyURL);
        }

        public void EnterLoginDetails(string loginEmail, string loginPassword)
        {
            LoginEmail.Clear();
            LoginEmail.SendKeys(loginEmail);
            LoginPassword.Clear();
            LoginPassword.SendKeys(loginPassword);
            
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public void EnsureLoginPageIsOpenAndReset()
        {
            if(driver.Url != CompanyURL)
            {
                driver.Navigate().GoToUrl(this.CompanyURL);
            }
            else
            {
                driver.Close ();
            }
        }
    }
}
