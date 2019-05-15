using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework;


namespace Demoproject
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
        }

    [TearDown]
    public void closeBrowser()
    {
       driver.Close();
    }

}
}
