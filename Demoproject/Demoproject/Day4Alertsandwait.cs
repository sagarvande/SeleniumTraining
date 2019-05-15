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
    class Day4Alertsandwait
    {

        IWebDriver driver;

        //public string url = "http://shop.demoqa.com/";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"D:\");

            //Open the specified URL in browser
            driver.Url = "http://demo.guru99.com/test/delete_customer.php";
            driver.Manage().Window.Maximize();
        }

        //Alert handling

        [Test]
        public void alerttest()
        {
            //ImplicitWait

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement Custid = driver.FindElement(By.Name("cusid"));

            Custid.SendKeys("422");

            IWebElement Subbutton = driver.FindElement(By.Name("submit"));

            Subbutton.Click();

            IAlert alert = driver.SwitchTo().Alert();

            String alertMsg = alert.Text;

            Console.WriteLine("Alert message is = " + alertMsg);
            
            alert.Accept();

        }

       
        [TearDown]
        public void closeBrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }

}

