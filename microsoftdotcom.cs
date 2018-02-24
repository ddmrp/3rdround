using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ddmrp
{
    class MicrosoftDotCom
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(@"c:\\3rdPartyTools");
        }

        [Test]
        public void GotoHomepage()
        {
            driver.Url = "http://www.microsoft.com";
        }


        [Test]
        public void SearchForDdmrp()
        {
            driver.Url = "http://www.microsoft.com";

            string searchTerm = "Demand Driven Material Requirement Planning";
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
            driver.FindElement(By.Id("search")).Click();
        }

        [TearDown]
            public void CloseBrowser()
            {
                driver.Close();
            }
 
        #region Helpers
        public void SearchFor(string searchTerm)
        {
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
        }

        #endregion
    }

}
