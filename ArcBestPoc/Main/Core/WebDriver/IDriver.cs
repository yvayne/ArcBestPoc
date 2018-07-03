using OpenQA.Selenium;

namespace ArcBestPoc.Main.Core.WebDriver
{
    interface IDriver
    {
       
        /// <summary>
        /// Initialize the selenium driver
        /// </summary>
        /// <returns>IWebDriver</returns>
        IWebDriver InitDriver();
    }
}
