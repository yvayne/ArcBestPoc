using ArcBestPoc.Main.Core.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArcBestPoc.Main.Core
{
    class CommonActions
    {
        private static IJavaScriptExecutor javaScriptExecutor;

        static CommonActions()
        {
            javaScriptExecutor = DriverManager.GetInstance().GetWebDriver() as IJavaScriptExecutor;
        }
        public static string GetValueFromWebElement(IWebElement webElement, string value)
        {
            return webElement.GetAttribute(value);
        }

        public static void WaitUntilElementIsDisplayed(IWebElement webElement)
        {
            DriverManager.GetInstance().GetWebDriverWait().Until(elementToWait => webElement.Displayed);
        }

        public static void ClickElementByJavaScript(IWebElement webElement)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].click()", webElement);
        }
        public static void ClickElement(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            webElement.Click();
        }

        public static void SetInputField(IWebElement webElement, string value)
        {
            WaitUntilElementIsDisplayed(webElement);
            webElement.Clear();
            webElement.SendKeys(value);
        }

        public static void WaitFixedTime(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public static string GetText(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            return webElement.Text;
        }
    }
}
