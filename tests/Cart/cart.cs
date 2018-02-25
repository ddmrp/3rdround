using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

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
        public void SuccessGotoHomePage()
        {
            //Arrange

            //Act
            GotoHomePage();

            //Assert
        }


        [Test]
        public void SuccessSearchForDdmrp()
        {
            //Arrange
            string searchTerm = "Demand Driven Material Requirement Plan";
            GotoHomePage();
 
            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessSearchForTyNorton()
        {
            //Arrange
            string searchTerm = "Ty Norton";
            GotoHomePage();

            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessSearchForEricFalsken()
        {
            //Arrange
            string searchTerm = "Eric Falsken";
            GotoHomePage();

            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessSearchForFrankZhang()
        {
            //Arrange
            string searchTerm = "Frank Zhang";
            GotoHomePage();

            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessSearchForMichaelDurkin()
        {
            //Arrange
            string searchTerm = "Michael Durkin";
            GotoHomePage();

            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessSearchForHermanXiao()
        {
            //Arrange
            string searchTerm = "Herman Xiao";
            GotoHomePage();

            //Act
            SearchFor(searchTerm);

            //Assert
        }

        [Test]
        public void SuccessGotoSignInPage()
        {
            //Arrange 

            //Act
            GotoSigninPage();

            //Assert
        }

        [Test]
        public void SuccessSignInWithValidUsernamePassword()
        {
            //Arrange
            string username = "ddmrp222@outlook.com";
            string password = "DemandDriven1!";

            //Act
            SignIn(username, password);

            //Assert
            Assert.NotNull(driver.FindElement(By.XPath("//img[@role='presentation']")));

        }

        [Test]   
        public void FailedSignInWithInvalidUsername()
        {
            //Arrange
            int numberOfExceptions = 0;
            string username = "ddmrp999@outlook.com";
            string password = "DemandDriven1!";

            //Act
            try
            {
                SignIn(username, password);
            }
            catch (AssertionException) { numberOfExceptions++; }

            //Assert
            Assert.AreEqual(1, numberOfExceptions);
        }
        
        [Test]
     
        public void FailedSignInWithInvalidPassword()
        {
            //Arrange
            int numberOfExceptions = 0;
            string username = "ddmrp222@outlook.com";
            string password = "DemandDriven2!";

            //Act
            try
            {
                SignIn(username, password);
            }
            catch (AssertionException) { numberOfExceptions++; }

            //Assert
            Assert.AreEqual(1, numberOfExceptions);
        }

        [TearDown]
            public void CloseBrowser()
            {
            Thread.Sleep(5000);
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
            //Type in UserName
            driver.FindElement(By.Id("i0116")).SendKeys(username);
            Thread.Sleep(1000);

            //Click Next
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(1000);

            try
            {   //UserName error
                var usernameError = driver.FindElement(By.Id("usernameError"));
                Assert.IsNull(usernameError); //make sure no username error
            }
            catch (NoSuchElementException)
            {   //Type in Password
                driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
                Thread.Sleep(1000);
                //Click on Sign in button
                driver.FindElement(By.Id("idSIButton9")).Click();
                Thread.Sleep(1000);

                try
                {   //Password error
                    var passwordError = driver.FindElement(By.Id("passwordError"));
                    Assert.IsNull(passwordError); //make sure no password error
                }
                catch (NoSuchElementException)
                {   //Logged in, make sure the user profile picture element presents
                    Assert.NotNull(driver.FindElement(By.XPath("//img[@role='presentation']")));
                }
            }
        }

        public void SearchFor(string searchTerm)
        {
            //Click on Magnifier to expand searchbox
            driver.FindElement(By.Id("search")).Click();
            //Type in search terms
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
            //Click on Magnifier to execute search
            driver.FindElement(By.Id("search")).Click();
        }

        #endregion
    }

}
