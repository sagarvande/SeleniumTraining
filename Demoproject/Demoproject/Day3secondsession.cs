using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;

/*Radio Button assignment:

Identify the selected radio button and display the name and value of the button

Select an unselected radio button and display the name and value of newly selected button*/

namespace Demoproject
{
    class Day3secondsession
    {
        IWebDriver driver;

        //public string url = "http://shop.demoqa.com/";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"D:\");

            //Open the specified URL in browser
            driver.Url = "https://www.toolsqa.com/automation-practice-form/";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {

          
            

            IList<IWebElement> RButton = driver.FindElements(By.Name("sex"));
             RButton.ElementAt(0);

            bool b = false;

            b = RButton.ElementAt(0).Selected;

            if (b == true)

            {
                RButton.ElementAt(1).Click();
                
                Console.WriteLine("Selected gender is " + RButton.ElementAt(1).GetAttribute("Value"));
            }
            else
                RButton.ElementAt(0).Click();
                Console.WriteLine("Selected gender is " + RButton.ElementAt(0).GetAttribute("Value"));




        }
        
 /*Checkbox assignment :

Identify the selected checkbox and display the name and value of the checkbox

Identify the unselected checkbox and check the unselected one and display the name and value of newly selected button*/

        [Test]

public void checkbox()
        {

            IList<IWebElement> CButton = driver.FindElements(By.Name("profession"));
            CButton.ElementAt(0);

            bool b = false;

            b = CButton.ElementAt(0).Selected;

            if (b == true)

            {
                CButton.ElementAt(1).Click();

                Console.WriteLine("Selected profession is " + CButton.ElementAt(1).GetAttribute("Value"));
            }
            else
                CButton.ElementAt(0).Click();
            Console.WriteLine("Selected profession is " + CButton.ElementAt(0).GetAttribute("Value"));


        }

        [TearDown]
        public void closeBrowser()
        {;;

            Thread.Sleep(5000);
            driver.Close();
        }
    }
}