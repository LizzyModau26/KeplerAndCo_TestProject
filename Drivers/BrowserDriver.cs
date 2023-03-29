using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2023.Drivers
{
    /// <summary>
    ///   Manages browser instance utilizing Selenium
    /// </summary>
    public class BrowserDriver : IDisposable
    {
        private readonly Lazy<IWebDriver> _currentWebDriver;
        private bool _disposed;

        public BrowserDriver()
        {
            _currentWebDriver = new Lazy<IWebDriver>(CreateWebDriver);
            
        }

        /// <summary>
        ///   Selenium web driver instance.
        /// </summary>
        public IWebDriver Current => _currentWebDriver.Value;

        /// <summary>
        ///   Method used to open web driver.
        /// </summary>
        /// <returns></returns>
        public IWebDriver CreateWebDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);

            return chromeDriver;
        }

        /// <summary>
        ///   Method used to close the web driver
        /// </summary>
        public void Dispose()
        {
            if( _disposed)
            {
                return;
            }
            if(_currentWebDriver.IsValueCreated)
            {
                Current.Quit();
            }
            _disposed = true;
                
        }
    }
}
