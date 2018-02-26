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
    }
}
