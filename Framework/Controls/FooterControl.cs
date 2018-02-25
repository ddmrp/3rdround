//HomePageObject.cs
using Ddmrp.Framework.Enums;
using Ddmrp.Framework.Helpers;
using OpenQA.Selenium;

namespace Ddmrp.Framework.Controls
{
    public static class FooterControl
    {
        public static void ClickLocale(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Footer.Locale));
        }

        public static void ClickSitemap(IWebDriver driver) => Utils.ClickLink(driver, By.XPath("//a[@ms.title='" + Footer.Sitemap + "']"));
        public static void ClickContactus(IWebDriver driver) => Utils.ClickLink(driver, By.XPath("//a[@ms.title='" + Footer.ContactUs + "']"));
        public static void ClickPrivacy(IWebDriver driver) => Utils.ClickLink(driver, By.XPath("//a[@ms.title='" + Footer.Privacy + "']"));
        public static void ClickTermsofuse(IWebDriver driver) => Utils.ClickLink(driver, By.XPath("//a[@ms.title='" + Footer.TermsOfUse + "']"));
        public static void ClickTrademarks(IWebDriver driver) => Utils.ClickLink(driver, By.XPath("//a[@ms.title='" + Footer.Trademarks + "']"));
        public static void ClickAboutads(IWebDriver driver) => Utils.ClickLink(driver, By.LinkText(Footer.Copyright));

    }
}
