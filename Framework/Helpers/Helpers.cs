//Helpers.cs
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Ddmrp.Framework.Helpers
{
    public static class Utils
    {
        public static void ClickLink(IWebDriver driver, By by)
        {
            driver.FindElement(by).Click();
        }

        public static void SearchFor(IWebDriver driver, string searchTerm)
        {
            //Click on Magnifier to expand searchbox
            driver.FindElement(By.Id("search")).Click();
            //Type in search terms
            var searchBox = driver.FindElement(By.Id("cli_shellHeaderSearchInput"));
            searchBox.Clear();
            searchBox.SendKeys(searchTerm);
            //Click on Magnifier to execute search
            driver.FindElement(By.Id("search")).Click();
        }

        public static void SignIn(IWebDriver driver, string username, string password)
        {
            //make sure we are signed out
            SignOut(driver);
            Thread.Sleep(1000);

            //Click on the SignIn link
            driver.FindElement(By.Id("meControl")).Click();
            Thread.Sleep(1000);

            //Type in UserName
            driver.FindElement(By.Id("i0116")).SendKeys(username);
            Thread.Sleep(1000);

            //Click Next
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(1000);


            if (!(ExistsElement(driver, By.Id("usernameError"))))
            { //no usernameError
                driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
                Thread.Sleep(1000);
                //Click on Sign in button
                driver.FindElement(By.Id("idSIButton9")).Click();
                Thread.Sleep(1000);

                if (!(ExistsElement(driver, By.Id("passwordError"))))
                { //no passwordError, Logged in, make sure the user profile picture element presents
                    Assert.True(ExistsElement(driver, By.XPath("//img[@role='presentation']")));
                }
            }
        }

        public static void SignOut(IWebDriver driver)
        {
            //Check whether already signed in
            if (ExistsElement(driver, By.XPath("//img[@role='presentation']")))
            {   //Click on the picture to flyout menu
                driver.FindElement(By.XPath("//img[@role='presentation']")).Click();
                //Click on Sign Out link
                driver.FindElement(By.XPath("//div[@id='msame_si1']/a")).Click();
            }

            // already Signed outo, do nothing
        }

        public static bool ExistsElement(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

