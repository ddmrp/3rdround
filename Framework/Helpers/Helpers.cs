//Helpers.cs

using OpenQA.Selenium;

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
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(searchTerm);
            //Click on Magnifier to execute search
            driver.FindElement(By.Id("search")).Click();
        }

    }
}
