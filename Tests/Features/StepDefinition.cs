using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Ddmrp.Framework.Helpers;
using System.Threading;
using Ddmrp.Framework.Controls;
using Ddmrp.Framework.Enums;
using Ddmrp.Framework.Pages;
using TechTalk.SpecFlow;

namespace Ddmrp.FeatureFiles
{
    [Binding]
    public sealed class StepDefinition
    {
        #region Global settings
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        IWebDriver driver;
        #endregion

        #region Given
        [Given("I am on the Signin page")]
        public void GivenIAmOnTheSigninPage() => driver.FindElement(By.XPath("//div[contains(., 'Sign in')]"));

        [Given("I am on SearchResults page for terms (.*)")]
        public void GivenIAmOnSearchResultsPageForTerms(string searchTerms) => Utils.SearchFor(driver, searchTerms);

        [Given("I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
        }
        #endregion

        #region When
        [When(@"I enter valid username (.*) / password (.*)")]
        public void WhenIEnterValidUsernamePassword(string username, string password) => Utils.SignIn(driver, username, password);

        [When(@"I click on Show All results link")]
        public void WhenIClickOnShowAllResultsLink() => Utils.ClickLink(driver, By.XPath("//a[starts-with(@href,'https://www.microsoft.com/en-us/store/search')]"));

        [When(@"I search for terms (.*) in searchbox")]
        public void WhenISearchForTermsInSearchbox(string searchTerms)
        {
            Utils.SearchFor(driver, searchTerms);
        }

        #endregion

        #region Then
        [Then("Then I should be able to sign in the site")]
        public void ThenIShouldBeAbleToSignInTheSite() => Assert.NotNull(driver.FindElement(By.XPath("//img[@role='presentation']")));

        [Then("all result items relevant to search terms (.*) should appear")]
        public void ThenAllResultItemsRelevantToSearchTermsShouldAppear(string searchTerms)
        {
            Assert.True(driver.Url.ToLowerInvariant().Contains("/store/search/"));
            Assert.IsNotNull(driver.FindElement(By.Id("typeRefineMenu")));
        }

        [Then("result items relevant to search terms (.*) should appear")]
        public void ThenResultItemsRelevantToSearchTermsShouldAppear(string searchTerms)
        {
            Assert.True(driver.Url.ToLowerInvariant().Contains("result.aspx"));
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[@data-grid='container']")));
        }

        #endregion

        #region Test Setup and Tear down
        [BeforeScenario()]
        public void BeforeScenario(FeatureContext featureContext)
        {
            driver = (IWebDriver)featureContext["driver"];
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            //Thread.Sleep(1000);
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
            IWebDriver driver = (IWebDriver)featureContext["driver"];

            Thread.Sleep(10000);
            driver.Close();
        }
        #endregion
    }
}
