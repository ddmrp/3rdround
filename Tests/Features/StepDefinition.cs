﻿using Ddmrp.Framework.Controls;
using Ddmrp.Framework.Enums;
using Ddmrp.Framework.Helpers;
using Ddmrp.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
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
        [Given(@"I am in my shopping cart")]
        public void GivenIAmInMyShoppingCart()
        {
            if (!(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']"))))
            {   //not signed in, sign in
                Utils.SignIn(driver, "ddmrp222@outlook.com", "DemandDriven1!");
            }
            //we are guaranteed signed in 
            Assert.True(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']")));

            if (Utils.ExistsElement(driver, By.Id(Navigation.Cart)))
            {   //Click on it
                Utils.ClickLink(driver, By.Id(Navigation.Cart));
            }
            Thread.Sleep(1000);
            Assert.True(driver.Url.Contains("/store/buy"),driver.Url.ToString());
        }

        [Given(@"I am signed in to the site with username (.*) password (.*)")]
        public void GivenIAmSignedInToTheSiteWithUsernamePassword(string username, string password)
        {
            if (!(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']"))))
            {
                Utils.SignIn(driver, username, password);
            }
            Assert.True(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']")));
        }

        [Given(@"I am on the Signin page")]
        public void GivenIAmOnTheSigninPage() => driver.FindElement(By.XPath("//div[contains(., 'Sign in')]"));

        [Given(@"I am on SearchResults page for terms (.*)")]
        public void GivenIAmOnSearchResultsPageForTerms(string searchTerms) => Utils.SearchFor(driver, searchTerms);

        [Given(@"I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
        }
        #endregion

        #region 	When  
        [When(@"I click on Remove item link")]
        public void WhenIClickOnRemoveItemLink()
        {   //Check to see link exists
            if (Utils.ExistsElement(driver, By.XPath("//*[text()='Remove']")))
            {   //Click on it
                Utils.ClickLink(driver, By.XPath("//*[text()='Remove']"));
            }
        }

        [When(@"I click on Add to cart link")]
        public void WhenIClickOnAddToCartLink()
        {   //Check to see link exists
            if (Utils.ExistsElement(driver, By.XPath("//*[text()='Add to cart']")))
            {   //Click on it
                Utils.ClickLink(driver, By.XPath("//*[text()='Add to cart']"));
            }
        }

        [When(@"I click on shopping cart link")]
        public void WhenIClickOnShoppingCartLink()
        {   //Check to see link exists
            if(Utils.ExistsElement(driver, By.Id(Navigation.Cart)))
            {   //Click on it
                Utils.ClickLink(driver, By.Id(Navigation.Cart));
            }
        }

        [When(@"I save updated firstname (.*) lastname (.*)")]
        public void WhenISaveUpdatedFirstnameLastname(string firstname, string lastname)
        {   //Check to see whether signed in yet
            if (!(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']"))))
            {   //not signed in, sign in
                Utils.SignIn(driver, "ddmrp222@outlook.com", "DemandDriven1!");
            }
            //we are guaranteed signed in 
            Assert.True(Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']")), driver.Url);

            //Click on the profile picture
            driver.FindElement(By.XPath("//img[@role='presentation']")).Click();
            //Click on View Microsoft account link
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("View Microsoft account")).Click();

            Assert.True(driver.Url.StartsWith("https://account.microsoft.com/?ref=MeControl"), driver.Url);

            Thread.Sleep(1000);
            if (Utils.ExistsElement(driver, By.Id("basics-module-edit-name")))
            {
                driver.FindElement(By.Id("basics-module-edit-name")).Click();
            }
            Assert.True(driver.Url.StartsWith("https://account.microsoft.com/profile/edit-name"), driver.Url);

            var firstName = (Utils.ExistsElement(driver, By.Id("edit-name-first")))? driver.FindElement(By.Id("edit-name-first")) : null;
            var lastName = (Utils.ExistsElement(driver, By.Id("edit-name-last"))) ? driver.FindElement(By.Id("edit-name-last")) : null;
            var editSave = (Utils.ExistsElement(driver, By.Id("edit-name-save"))) ? driver.FindElement(By.Id("edit-name-save")) : null;
            
            firstname = firstname + Guid.NewGuid();
            
            firstName.Clear();
            lastName.Clear();

            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);

            Thread.Sleep(2000);

            if (editSave.Enabled)
            {
                editSave.Click();
            }

            Assert.True(driver.Url.StartsWith("https://account.microsoft.com/"), driver.Url);
        }


        [When(@"I click on View Microsoft Account link")]
        public void WhenIClickOnViewMicrosoftAccountLink()
        {
            Thread.Sleep(1000);
            if (Utils.ExistsElement(driver, By.XPath("//img[@role='presentation']")))
            {
                driver.FindElement(By.XPath("//img[@role='presentation']")).Click();
            }
            Thread.Sleep(1000);
            if (Utils.ExistsElement(driver, By.LinkText("View Microsoft account")))
            {
                driver.FindElement(By.LinkText("View Microsoft account")).Click();
            }

        }

        [When(@"I click on a link (.*) from top navigation")]
        public void WhenIClickOnALinkFromTopNavigation(string link)
        {
            switch (link)
            {
                case "Logo":
                    Utils.ClickLink(driver, By.Id(Navigation.Logo));
                    break;
                case "Office":
                    Utils.ClickLink(driver, By.Id(Navigation.Office));
                    break;
                case "Windows":
                    Utils.ClickLink(driver, By.Id(Navigation.Windows));
                    break;
                case "Surface":
                    Utils.ClickLink(driver, By.Id(Navigation.Surface));
                    break;
                case "Xbox":
                    Utils.ClickLink(driver, By.Id(Navigation.Xbox));
                    break;
                case "Deals":
                    Utils.ClickLink(driver, By.Id(Navigation.Deals));
                    break;
                case "Support":
                    Utils.ClickLink(driver, By.Id(Navigation.Support));
                    break;
                case "More":
                    Utils.ClickLink(driver, By.Id(Navigation.More));
                    break;
                case "Search":
                    Utils.ClickLink(driver, By.Id(Navigation.Search));
                    break;
                case "Cart":
                    Utils.ClickLink(driver, By.Id(Navigation.Cart));
                    break;
                default:
                    ;
                    break;
            }
        }

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
                    Utils.ClickLink(driver, By.LinkText(link));
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
        [Then(@"The item should be removed from cart")]
        public void ThenTheItemShouldBeRemovedFromCart()
        {
            Assert.True(driver.Url.Contains("/store/buy"), driver.Url);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        }

        [Then(@"The item should be added to cart")]
        public void ThenTheItemShouldBeAddedToCart()
        {
            Assert.True(driver.Url.Contains("/store/buy"), driver.Url);
        }

        [Then(@"I should land on my shopping cart")]
        public void ThenIShouldLandOnMyShoppingCart()
        {
            Thread.Sleep(1000);
            Assert.True(driver.Url.Contains("/store/buy/"),driver.Url);
        }

        [Then(@"The new firstname (.*) lastname (.*) should show")]
        public void ThenTheNewFirstnameLastnameShouldShow(string firstname, string lastname)
        {
            //Assert.True(driver.Url.StartsWith("https://account.microsoft.com/"));
            Assert.NotNull(driver.FindElement(By.XPath("//span[text()='Account']")), driver.Url);
        }


        [Then(@"I should land on my profile page")]
        public void ThenIShouldLandOnMyProfilePage()
        {
            Assert.True(driver.Url.StartsWith("https://account.microsoft.com/?ref=MeControl"), driver.Url);
        }

        [Then(@"correct top navigation web page (.*) should render")]
        public void ThenCorrectTopNavigationWebPageShouldRender(string link)
        {
            switch (link)
            {
                case "Logo":
                    Assert.True(driver.Url.Contains("/en-us/"), driver.Url);
                    break;
                case "Office":
                    Assert.True(driver.Url.Contains("/en-us/home"), driver.Url);
                    break;
                case "Windows":
                    Assert.True(driver.Url.Contains("/windows/"), driver.Url);
                    break;
                case "Surface":
                    Assert.True(driver.Url.Contains("/surface"), driver.Url);
                    break;
                case "Xbox":
                    Assert.True(driver.Url.Contains("/www.xbox.com/"), driver.Url);
                    break;
                case "Deals":
                    Assert.True(driver.Url.Contains("/store/"), driver.Url);
                    break;
                case "Support":
                    Assert.True(driver.Url.Contains("/support.microsoft.com/"), driver.Url);
                    break;
                case "More":
                    Assert.True(Utils.ExistsElement(driver, By.Id("More-navigation")), driver.Url);
                    break;
                case "Search":
                    Assert.True(Utils.ExistsElement(driver, By.Id("cli_shellHeaderSearchInput")), driver.Url);
                    break;
                case "Cart":
                    Thread.Sleep(1000);
                    Assert.True(driver.Url.Contains("/store/buy/"), driver.Url);
                    break;
                default:
                    ;
                    break;
            }
        }

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
            driver = new ChromeDriver(@"c:\\webdrivers");
            driver.Navigate().GoToUrl("https://www.microsoft.com");
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            driver.Close();
        }

        [BeforeFeature()]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //var driver = new ChromeDriver(@"c:\\3rdPartyTools");
            //driver.Navigate().GoToUrl("https://www.microsoft.com");
            //featureContext.Add("driver", driver);
        }

        [AfterFeature()]
        public static void AfterFeature(FeatureContext featureContext)
        {
            //IWebDriver driver = (IWebDriver)featureContext["driver"];

            //Thread.Sleep(1000);
            //driver.Close();
        }
        #endregion
    }
}
