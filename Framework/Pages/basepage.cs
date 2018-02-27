//HomePageObject.cs
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Ddmrp.Framework.Pages
{
    public class BasePage
    {

        public string Url = "http://www.microsoft.com";
        public IWebDriver Driver;

        public void StartBrowser()
        {
            Driver = new ChromeDriver(@"c:\\3rdPartyTools");
            Driver.Navigate().GoToUrl("http://www.microsoft.com");
        }

        public void GotoPage()
        {
             Driver.Navigate().GoToUrl(Url);
       }

        public void ClickLogo()
        {
            Driver.FindElement(By.Id("uhfLogo")).Click();
        }

      }
}
