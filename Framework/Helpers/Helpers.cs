//Helpers.cs

using OpenQA.Selenium;

namespace Ddmrp.Framework.Helpers
{
    public static class Utils
    {
        public static void ClickLink(IWebDriver driver, string link)
        {
            driver.FindElement(By.Id(link)).Click();
        }
    }
}
