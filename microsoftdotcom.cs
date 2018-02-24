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
        public void ValidateHomePage()
        {
            GotoHomePage();
        }


        [Test]
        public void ValidateSearchForDdmrp()
        {
            driver.Url = "http://www.microsoft.com";

            string searchTerm = "Demand Driven Material Requirement Planning";
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
            driver.FindElement(By.Id("search")).Click();
        }

        [Test]
        public void ValidateSignInPage()
        {
            driver.Url = "http://www.microsoft.com";
            driver.FindElement(By.ClassName("msame_Header_name")).Click();

        }

        [Test]
        public void ValidateSignInWithValidUsernamePasswordSuccessful()
        {
            driver.Url = "http://www.microsoft.com";
            driver.FindElement(By.ClassName("msame_Header_name")).Click();

            string username = "ddmrp222@outlook.com";
            string password = "DemandDriven1!";
            SignIn(username, password);
        }

        [Test]
        public void ValidateSignInWithInvalidUsernameFailed()
        {
            driver.Url = "http://www.microsoft.com";
            driver.FindElement(By.ClassName("msame_Header_name")).Click();

            string username = "ddmrp999@outlook.com";
            string password = "DemandDriven1!";
            SignIn(username, password);
        }

        [Test]
        public void ValidateSignInWithInvalidPasswordFailed()
        {
            driver.Url = "http://www.microsoft.com";
            driver.FindElement(By.ClassName("msame_Header_name")).Click();

            string username = "ddmrp222@outlook.com";
            string password = "DemandDriven9!";
            SignIn(username, password);
        }

        [TearDown]
            public void CloseBrowser()
            {
                driver.Close();
            }

        #region Helpers
        public void GotoHomePage()
        {
            driver.Url = "http://www.microsoft.com";
        }

        public void GotoSigninPage()
        {
            GotoHomePage();
            driver.FindElement(By.ClassName("msame_Header_name")).Click();
        }

        public void SignIn(string username, string password)
        {
            GotoSigninPage();

            driver.FindElement(By.Id("i0116")).SendKeys(username);
            driver.FindElement(By.Id("idSIButton9")).Click();

            Assert.IsFalse(driver.FindElement(By.Id("usernameError")).Displayed);

            //StringAssert.AreEqualIgnoringCase(username, driver.FindElement(By.Id("displayName")).Text);
            //StringAssert.AreEqualIgnoringCase("Enter password", driver.FindElement(By.Id("loginHeader")).Text);
            //           driver.FindElement(By.Id("i0118")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
            driver.SwitchTo().ActiveElement().SendKeys("Keys.Tab");
            driver.SwitchTo().ActiveElement().SendKeys("Keys.Tab");
            driver.SwitchTo().ActiveElement().SendKeys("Keys.Space");

            Assert.IsFalse(driver.FindElement(By.Id("passwordError")).Displayed);

        }

        public void SearchFor(string searchTerm)
        {
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
        }

        #endregion
    }

}
