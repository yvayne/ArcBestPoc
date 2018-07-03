using ArcBestPoc.Main.Core.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcBestPoc.Main.Utils
{
    class Alert
    {
        public static void ClickAcceptButton()
        {
            IAlert alert = DriverManager.GetInstance().GetWebDriver().SwitchTo().Alert();
            alert.Accept();
        }
    }
}
