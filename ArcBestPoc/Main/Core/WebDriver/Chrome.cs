using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ArcBestPoc.Main.Core.WebDriver
{
    class Chrome : IDriver
    {
        public IWebDriver InitDriver()
        {
            string driverPath = AppDomain.CurrentDomain.BaseDirectory;
            ChromeOptions options = new ChromeOptions();
            return new ChromeDriver(driverPath, options);
        }
    }
}
