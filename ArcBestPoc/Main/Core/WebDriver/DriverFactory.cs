using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcBestPoc.Main.Core.WebDriver
{
    class DriverFactory
    {
        public static IWebDriver GetDriver(DriverTypes driver)
        {
            Dictionary<DriverTypes, IDriver> drivers = new Dictionary<DriverTypes, IDriver>();
            drivers.Add(DriverTypes.CHROME, new Chrome());
            drivers.Add(DriverTypes.FIREFOX, new Firefox());
            return drivers[driver].InitDriver();
        }
    }
}
