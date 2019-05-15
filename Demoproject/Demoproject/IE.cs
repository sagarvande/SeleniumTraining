using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demoproject
{
    class IE
    { 
     IWebDriver driver;
    public string url = "http://shop.demoqa.com/";

    [SetUp]
    public void startBrowser()
    {
        driver = new InternetExplorerDriver(@"D:\");
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