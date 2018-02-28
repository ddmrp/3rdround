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
            Utils.ClickLink(driver, By.Id(Navigation.Office));
        }

        public                                                                                                                                                                                static void ClickWindows(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.Windows));
        }

        public static void ClickSurface(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.Surface));
        }

        public static void ClickXbox(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.Xbox));
        }

        public static void ClickDeals(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.Deals));
        }

        public static void ClickSupport(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.Support));
        }

        public static void ClickMore(IWebDriver driver)
        {
            Utils.ClickLink(driver, By.Id(Navigation.More));
        }
    }
}
