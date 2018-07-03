using ArcBestPoc.Main.Core;
using ArcBestPoc.Main.Core.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ArcBestPoc.Main.Pages
{
    class TestOne : BasePage
    {
        [FindsBy(How = How.Id, Using = "StartDate")]
        private IWebElement startDateTextField;

        [FindsBy(How = How.Id, Using = "EndDate")]
        private IWebElement endDateTextField;

        [FindsBy(How = How.CssSelector, Using = "input[value='Validate Date']")]
        private IWebElement validateButton;

        [FindsBy(How = How.Id, Using = "aFormletShowHideLinkFormletThree")]
        private IWebElement hideLinkThree;

        [FindsBy(How = How.Id, Using = "spanSummaryFormletThree")]
        private IWebElement labelSummaryThree;

        public TestOne()
        { }

        public void SetStartDateTextField(string value)
        {
            CommonActions.SetInputField(startDateTextField, value);
        }

        public void SetEndDateTextField(string value)
        {
            CommonActions.SetInputField(endDateTextField, value);
        }

        public string GetValueStartDate()
        {
            return CommonActions.GetValueFromWebElement(startDateTextField, "value");
        }
        public string GetValueEndDate()
        {
            return CommonActions.GetValueFromWebElement(endDateTextField, "value");
        }

        public void ClickValidateButton()
        {
            CommonActions.ClickElementByJavaScript(validateButton);
        }

        public void ClickHideLinkThree()
        {
            CommonActions.ClickElement(hideLinkThree);
        }
        public string GetValueLabelThree()
        {
            return CommonActions.GetText(labelSummaryThree);
        }
    }
}
