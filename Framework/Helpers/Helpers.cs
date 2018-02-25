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
    }
}
