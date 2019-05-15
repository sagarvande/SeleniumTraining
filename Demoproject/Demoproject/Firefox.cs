using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace Demoproject
{
    [TestFixture]
    class Firefox
    {
      
        IWebDriver driver;
        public string url = "http://shop.demoqa.com/";

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver(@"D:\");
        }

        [Test]
        public void test()
        {
            //Open the specified URL in browser
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}