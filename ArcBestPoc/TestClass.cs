using ArcBestPoc.Main.Core.WebDriver;
using NUnit.Framework;
using System.Configuration;

namespace ArcBestPoc
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            
            DriverManager.GetInstance().InitializeDriver();
            DriverManager.GetInstance().GetWebDriver().Navigate().GoToUrl("http://testmy.dtc.corp/dtctrg/patchtest/testone.asp");
        }
    }
}
