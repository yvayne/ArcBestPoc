﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ArcBestPoc.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FormletOne")]
    public partial class FormletOneFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FormletOne.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FormletOne", "\tIn order to verify functionalty of formlet one\r\n\tAs an user\r\n\tI want to verify t" +
                    "he formlet is working as expected.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that is possible to set the start and end date manually")]
        [NUnit.Framework.CategoryAttribute("FormletOne")]
        public virtual void VerifyThatIsPossibleToSetTheStartAndEndDateManually()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that is possible to set the start and end date manually", new string[] {
                        "FormletOne"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I go to testone page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I set the startDate field with the following \"03/06/1998\" value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I set the endDate field with the following \"03/06/2000\" value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("the value of the startDate field should be \"03/06/1998\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
  testRunner.And("the value of the endDate field should be \"03/06/2000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that is not possible to set the start date with invalid date")]
        [NUnit.Framework.CategoryAttribute("FormletOne")]
        public virtual void VerifyThatIsNotPossibleToSetTheStartDateWithInvalidDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that is not possible to set the start date with invalid date", new string[] {
                        "FormletOne"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("I go to testone page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I set the startDate field with the following \"131313\" value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.And("I set the endDate field with the following \"03/06/2000\" value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.And("I press validate button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("I press ok button from alert window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that is possible to collapse the formlet three")]
        [NUnit.Framework.CategoryAttribute("FormletThree")]
        public virtual void VerifyThatIsPossibleToCollapseTheFormletThree()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that is possible to collapse the formlet three", new string[] {
                        "FormletThree"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
testRunner.Given("I go to testone page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
testRunner.When("I click hide button from formlet three", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.Then("It should be displayed the following \"This formlet has been collapsed with a summ" +
                    "ary!\" message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
