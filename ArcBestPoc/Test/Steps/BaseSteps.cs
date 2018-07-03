using ArcBestPoc.Main.Core.WebDriver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ArcBestPoc.Test.Steps
{
    [Binding]
    public class BaseSteps
    {
        [StepDefinition(@"I go to testone page")]
        public void GivenIGoToTestonePage()
        {
            DriverManager.GetInstance().InitializeDriver();
            DriverManager.GetInstance().GetWebDriver().Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseUrl"].ToString());
        }
    }
}
