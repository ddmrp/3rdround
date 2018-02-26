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
        [Given(@"I am on the Signin page")]
        public void GivenIAmOnTheSigninPage() => driver.FindElement(By.XPath("//div[contains(., 'Sign in')]"));

        [Given(@"I am on SearchResults page for terms (.*)")]
        public void GivenIAmOnSearchResultsPageForTerms(string searchTerms) => Utils.SearchFor(driver, searchTerms);

        [Given(@"I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
        }
        #endregion

        #region When 	 
        [When(@"I click on a link (.*) from footer")]
        public void WhenIClickOnALinkFromFooter(string link)
        {
            switch (link)
            {
                case "Locale":
                    Utils.ClickLink(driver, By.Id(Footer.Locale));
                    break;
                case "SiteMap":
                    Utils.ClickLink(driver, By.LinkText(Footer.SiteMap));
                    break;
                case "ContactUs":
                    Utils.ClickLink(driver, By.LinkText(Footer.ContactUs));
                    break;
                case "Privacy":
                    Utils.ClickLink(driver, By.LinkText(Footer.Privacy));
                    break;
                case "Terms":
                    Utils.ClickLink(driver, By.LinkText(Footer.Terms));
                    break;
                case "Trademarks":
                    Utils.ClickLink(driver, By.LinkText(Footer.Trademarks));
                    break;
                case "AboutAds":
                    Utils.ClickLink(driver, By.LinkText(Footer.AboutAds));
                    break;
                default:
                    ;
                    break;
            }
                
            
        }

        [When(@"I enter username (.*) / password (.*)")]
        public void WhenIEnterUsernamePassword(string username, string password) => Utils.SignIn(driver, username, password);

        [When(@"I click on Show All results link")]
        public void WhenIClickOnShowAllResultsLink() => Utils.ClickLink(driver, By.XPath("//a[starts-with(@href,'https://www.microsoft.com/en-us/store/search')]"));

        [When(@"I search for terms (.*) in searchbox")]
        public void WhenISearchForTermsInSearchbox(string searchTerms)
        {
            Utils.SearchFor(driver, searchTerms);
        }

        #endregion

        #region Then 	
        [Then(@"the corresponding web page (.*) should render")]
        public void ThenTheCorrespondingWebPageShouldRender(string link)
        {
            switch (link)
            {
                case "Locale":
                    Assert.True(driver.Url.Contains("/locale.aspx"));
                    break;
                case "SiteMap":
                    Assert.True(driver.Url.Contains("/sitemap"));
                    break;
                case "ContactUs":
                    Assert.True(driver.Url.Contains("/contactus/"));
                    break;
                case "Privacy":
                    Assert.True(driver.Url.Contains("/privacystatement"));
                    break;
                case "Terms":
                    Assert.True(driver.Url.Contains("/legal/intellectualproperty/copyright/"));
                    break;
                case "Trademarks":
                    Assert.True(driver.Url.Contains("/legal/intellectualproperty/trademarks/"));
                    break;
                case "AboutAds":
                    Assert.True(driver.Url.Contains("/privacy/ad-settings/"));
                    break;
                default:
                    ;
                    break;
            }
        }

        [Then(@"I should be denied access to the site")]
        public void ThenIShouldBeDeniedAccessToTheSite()
        {
            Assert.True(driver.Url.StartsWith("https://login.live.com/"));
            Assert.True(Utils.ExistsElement(driver, By.Id("usernameError")) || Utils.ExistsElement(driver, By.Id("passwordError")));
        }

        [Then(@"I should be able to access the site")]
        public void ThenIShouldBeAbleToAccessTheSite()
        {
            Assert.False(driver.Url.StartsWith("https://login.live.com/"));
            Assert.True(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']")));
        }

        [Then(@"all result items relevant to search terms (.*) should appear")]
        public void ThenAllResultItemsRelevantToSearchTermsShouldAppear(string searchTerms)
        {
            Assert.True(driver.Url.ToLowerInvariant().Contains("/store/search/"));
            Assert.IsNotNull(driver.FindElement(By.Id("typeRefineMenu")));
        }

        [Then(@"result items relevant to search terms (.*) should appear")]
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
            //driver = (IWebDriver)featureContext["driver"];
            driver = new ChromeDriver(@"c:\\3rdPartyTools");
            driver.Navigate().GoToUrl("https://www.microsoft.com");
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            Thread.Sleep(1000);
            driver.Close();
        }

        [BeforeFeature()]
        public static void BeforeFeature(FeatureContext featureContext)
        {
          // var driver = new ChromeDriver(@"c:\\3rdPartyTools");
          //  driver.Navigate().GoToUrl("https://www.microsoft.com");
          //  featureContext.Add("driver", driver);
        }

        [AfterFeature()]
        public static void AfterFeature(FeatureContext featureContext)
        {
           // IWebDriver driver = (IWebDriver)featureContext["driver"];

           // Thread.Sleep(3000);
           // driver.Close();
        }
        #endregion
    }
}
