//BaseTest.cs
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Ddmrp.Tests
{
    public class BaseTest
    {

        public string url = "https://www.microsoft.com";
        public IWebDriver driver;

        public void StartBrowser()
        {
            driver = new ChromeDriver(@"c:\\3rdPartyTools");
        }

        public void GotoPage()
        {
             driver.Navigate().GoToUrl(url);
       }

        public void ClickLogo()
        {
            driver.FindElement(By.Id("uhfLogo")).Click();
        }

      }
}
