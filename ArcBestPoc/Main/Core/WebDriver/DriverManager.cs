using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace ArcBestPoc.Main.Core.WebDriver
{
    public class DriverManager
    {
        private static DriverManager instance;
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;

        private DriverManager()
        {

        }
        public static DriverManager GetInstance()
        {
            if (instance is null)
            {
                instance = new DriverManager();
            }
            return instance;
        }

        public void InitializeDriver()
        {
            DriverTypes driverType = (DriverTypes)System.Enum.Parse(typeof(DriverTypes), ConfigurationManager.AppSettings["Browser"].ToString());
            int implicitWait = int.Parse(ConfigurationManager.AppSettings["ImplicitTime"].ToString());
            int explicitWait = int.Parse(ConfigurationManager.AppSettings["ExplicitTime"].ToString());

            webDriver = DriverFactory.GetDriver(driverType);
            webDriver.Manage().Window.Maximize();
            
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(explicitWait));
        }

        public void QuitWebDriver()
        {
            webDriver.Close();
            webDriver.Quit();
            webDriver = null;
        }

        public IWebDriver GetWebDriver()
        {
            return webDriver;
        }

        public WebDriverWait GetWebDriverWait()
        {
            return webDriverWait;
        }
    }
}
