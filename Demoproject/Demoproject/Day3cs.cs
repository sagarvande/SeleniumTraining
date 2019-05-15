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
    class Day3cs
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

           //First assignment
            
            //Get Page Title name and Title length

            string Tname = driver.Title;

            Console.WriteLine("Title Name ="+Tname);

            int Tlength = driver.Title.Length;

            Console.WriteLine("\n");

            Console.WriteLine("Title length = "+Tlength);

            //Get Page URL and Page Url Length

            string url = driver.Url;

            Console.WriteLine("Url of the page = " + url);

            int ulength = url.Length;

            Console.WriteLine("Length of the Url = " + ulength);

            //Page source and lenght

            string psource = driver.PageSource;

            Console.WriteLine("Page source = " + psource);

            int sourcelength = psource.Length;

            Console.WriteLine("Page source length = " + sourcelength);

        }

        [Test]
        public void test1()
        {
            //Open the specified URL in browser
            driver.Url = "https://www.guru99.com/";

            //click on Software testing course 

            IWebElement Softtest = driver.FindElement(By.XPath("//li[@class='fa fa-chevron-circle-right']//a[contains(text(),'Software Testing')]"));

            Softtest.Click();

            //Come back to Home page (Use ‘Back’ command)

            driver.Navigate().Back();

            //Again navigate on software testing course page

            driver.Navigate().Forward();

            //Refresh the page

            driver.Navigate().Refresh();
        }
        /*[TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        */
    }
}