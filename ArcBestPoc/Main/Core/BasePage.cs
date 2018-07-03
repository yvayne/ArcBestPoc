
using ArcBestPoc.Main.Core.WebDriver;
using OpenQA.Selenium.Support.PageObjects;

namespace ArcBestPoc.Main.Core
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverManager.GetInstance().GetWebDriver(), this);
        }

        public string getTitle()
        {
            return DriverManager.GetInstance().GetWebDriver().Title;
        }
    }
}
