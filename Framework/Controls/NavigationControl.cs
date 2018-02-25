//NavigationControl.cs
using Ddmrp.Framework.Enums;
using Ddmrp.Framework.Helpers;
using OpenQA.Selenium;

namespace Ddmrp.Framework.Controls
{
    public static class NavigationControl
    {
        public static void ClickOffice(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Office);
        }

        public static void ClickWindows(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Windows);
        }

        public static void ClickSurface(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Surface);
        }

        public static void ClickXbox(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Xbox);
        }

        public static void ClickDeals(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Deals);
        }

        public static void ClickSupport(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.Support);
        }

        public static void ClickMore(IWebDriver driver)
        {
            Utils.ClickLink(driver, Navigation.More);
        }
    }
}
