using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ArcBestPoc.Main.Core.WebDriver
{
    class Firefox : IDriver
    {
        public IWebDriver InitDriver()
        {
            string driverPath = AppDomain.CurrentDomain.BaseDirectory;
            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", driverPath + "\\geckodriver.exe");
            FirefoxOptions options = new FirefoxOptions(); 
            return new FirefoxDriver(driverPath, options);
        }
    }
}
