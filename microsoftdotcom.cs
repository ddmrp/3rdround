using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ddmrp
{
    class MicrosoftDotCom
    {
            IWebDriver driver;

            [SetUp]
            public void StartBrowser()
            {
                driver = new ChromeDriver(@"c:\\3rdPartyTools");
            }

            [Test]
            public void Test()
            {
                driver.Url = "http://www.microsoft.com";
            }

            [TearDown]
            public void CloseBrowser()
            {
                driver.Close();
            }

        }
    }
