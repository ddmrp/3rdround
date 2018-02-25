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
    public class Homepage: BasePage
    {
        public void OpenPage(string homepage, IWebDriver driver)
        {
            //driver.Navigate().GoToUrl("http://google.co.uk");
            driver.Navigate().GoToUrl(homepage);
            //Console.WriteLine(homepage);
            // driver.Navigate();
        }
         public void ClickSearch(IWebDriver driver)
        {
            //Selenese goes here
            driver.FindElement(By.Id("gbqfba")).Click();
        }
        public void clickFeelingLucky(IWebDriver driver)
        {
            //Selenese
            driver.FindElement(By.Id("gbqfbb")).Click();
        }
    }
}
