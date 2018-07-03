using ArcBestPoc.Main.Core;
using ArcBestPoc.Main.Core.WebDriver;
using ArcBestPoc.Main.Pages;
using ArcBestPoc.Main.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ArcBestPoc.Test.Steps
{
    [Binding]
    class FormletOneSteps
    {
        public TestOne testOne;

        public FormletOneSteps()
        {
            testOne = new TestOne();
        }
        [When(@"I set the startDate field with the following ""(.*)"" value")]
        public void WhenISetTheStartDateFieldWithTheFollowingValue(string startDate)
        {
            testOne.SetStartDateTextField(startDate);
        }

        [When(@"I set the endDate field with the following ""(.*)"" value")]
        public void WhenISetTheEndDateFieldWithTheFollowingValue(string endDate)
        {
            testOne.SetEndDateTextField(endDate);
        }

        [Then(@"the value of the startDate field should be ""(.*)""")]
        public void ThenTheValueOfTheStartDateFieldShouldBe(string expectedDate)
        {
            Assert.AreEqual(expectedDate, testOne.GetValueStartDate());
        }

        [Then(@"the value of the endDate field should be ""(.*)""")]
        public void ThenTheValueOfTheEndDateFieldShouldBe(string expectedDate)
        {
            Assert.AreEqual(expectedDate, testOne.GetValueEndDate());
        }

        [When(@"I press validate button")]
        public void WhenIPressValidateButton()
        {
            testOne.ClickValidateButton();
        }

        [When(@"I press ok button from alert window")]
        public void WhenIPressOkButtonFromAlertWindow()
        {
            CommonActions.WaitFixedTime(2);
            Alert.ClickAcceptButton();
        }

        [When(@"I click hide button from formlet three")]
        public void WhenIClickHideButtonFromFormletThree()
        {
            testOne.ClickHideLinkThree();
        }

        [Then(@"It should be displayed the following ""(.*)"" message")]
        public void ThenItShouldBeDisplayedTheFollowingMessage(string expectedMessage)
        {
            Assert.AreEqual(expectedMessage, testOne.GetValueLabelThree());
        }

        [AfterScenario]
        public static void TearDown()
        {
            DriverManager.GetInstance().QuitWebDriver();
        }

    }
}
