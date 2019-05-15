using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demoproject
{
    class Edge
    { 
    IWebDriver driver;
    public string url = "http://shop.demoqa.com/";

    [SetUp]
    public void startBrowser()
    {
        driver = new EdgeDriver(@"D:\");
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