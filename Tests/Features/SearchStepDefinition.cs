using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Ddmrp.Framework.Helpers;
using System.Threading;
using Ddmrp.Framework.Controls;
using Ddmrp.Framework.Pages;
using TechTalk.SpecFlow;

namespace Ddmrp.FeatureFiles
{
    [Binding]
    public sealed class StepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        IWebDriver driver;

        [Given("I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
        }

        [When(@"I search for terms (.*) in searchbox")]
        public void WhenISearchForTermsInSearchbox(string searchTerms)
        {
            Utils.SearchFor(driver, searchTerms);
        }

         [Then("result items relevant to search terms (.*) should appear")]
        public void ThenResultItemsRelevantToSearchTermsShouldAppear(string searchTerms)
        {
            Assert.True(driver.Url.ToLowerInvariant().Contains("result.aspx"));
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[@data-grid='container']")));
        }

        [BeforeScenario()]
        public void BeforeScenario(FeatureContext featureContext)
        {
            driver = (IWebDriver)featureContext["driver"];
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            Thread.Sleep(1000);
            //driver.Close();
        }

        [BeforeFeature()]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            var driver = new ChromeDriver(@"c:\\3rdPartyTools");
            driver.Navigate().GoToUrl("https://www.microsoft.com");
            featureContext.Add("driver", driver);
        }

        [AfterFeature()]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Thread.Sleep(5000);
            IWebDriver driver = (IWebDriver)featureContext["driver"];
            driver.Close();

        }

    }
}
