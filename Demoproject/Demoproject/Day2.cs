using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Demoproject
{
    class Day2
    {
        [TestFixture]
        class Chromedriver
        {
            IWebDriver driver;

            //public string url = "http://shop.demoqa.com/";

            [SetUp]
            public void startBrowser()
            {
                driver = new ChromeDriver(@"D:\");
            }

            [Test]
            public void test()
            {
                //Open the specified URL in browser
                driver.Url = "http://shop.demoqa.com/";

                driver.Manage().Window.Maximize();

                //Basic Xpath

                IWebElement search = driver.FindElement(By.XPath("//*[@class='noo-search']"));

                  search.Click();

                IWebElement search1 = driver.FindElement(By.XPath("//a[@href='#']"));

                search1.Click();

                // Xpath Using contains ()

                IWebElement myact = driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]"));

                Thread.Sleep(15);
                myact.Click();

                IWebElement search2 = driver.FindElement(By.XPath("//*[contains(@class, 'noo-search')]"));
                search2.Click();  

            }


            [TearDown]
            public void closeBrowser()
            {

                Thread.Sleep(5000);
            driver.Close();
            }
            
        }
    }
}