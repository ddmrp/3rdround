﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ddmrp.Tests.Features.Search
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search")]
    [NUnit.Framework.CategoryAttribute("Search")]
    public partial class SearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Search.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search", "\tIn order to find out information from the site\r\n\tAs a normal user\r\n\tI want to be" +
                    " able to type in search terms into searchbox", ProgrammingLanguage.CSharp, new string[] {
                        "Search"});
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
        [NUnit.Framework.DescriptionAttribute("Success Search from Searchbox")]
        [NUnit.Framework.CategoryAttribute("UI")]
        [NUnit.Framework.CategoryAttribute("Success")]
        [NUnit.Framework.CategoryAttribute("SearchBox")]
        [NUnit.Framework.TestCaseAttribute("Demand Driven Material Requirement Plan", null)]
        [NUnit.Framework.TestCaseAttribute("DDMRP", null)]
        [NUnit.Framework.TestCaseAttribute("Demand Driven", null)]
        [NUnit.Framework.TestCaseAttribute("Material Requirement Plan", null)]
        [NUnit.Framework.TestCaseAttribute("MRP", null)]
        [NUnit.Framework.TestCaseAttribute("DemandDrivenTech", null)]
        public virtual void SuccessSearchFromSearchbox(string searchTerms, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UI",
                    "Success",
                    "SearchBox"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Success Search from Searchbox", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I am on HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("I search for terms {0} in searchbox", searchTerms), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("result items relevant to search terms {0} should appear", searchTerms), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Success Search Results Show All")]
        [NUnit.Framework.CategoryAttribute("UI")]
        [NUnit.Framework.CategoryAttribute("Success")]
        [NUnit.Framework.CategoryAttribute("SearchResults")]
        [NUnit.Framework.CategoryAttribute("ShowAll")]
        [NUnit.Framework.TestCaseAttribute("Stephen King", null)]
        [NUnit.Framework.TestCaseAttribute("Eric Falsken", null)]
        [NUnit.Framework.TestCaseAttribute("Frank Zhang", null)]
        [NUnit.Framework.TestCaseAttribute("Michael Durkin", null)]
        [NUnit.Framework.TestCaseAttribute("Herman Xiao", null)]
        public virtual void SuccessSearchResultsShowAll(string searchTerms, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UI",
                    "Success",
                    "SearchResults",
                    "ShowAll"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Success Search Results Show All", @__tags);
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given(string.Format("I am on SearchResults page for terms {0}", searchTerms), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When("I click on Show All results link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then(string.Format("all result items relevant to search terms {0} should appear", searchTerms), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
