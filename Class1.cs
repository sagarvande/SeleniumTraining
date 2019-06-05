using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Specflow_Business_partner
{
    public class Class1
    {
        IWebDriver driver;
        private DefaultWait<IWebDriver> fluentWait;

        [OneTimeSetUp]

        public void initbrowser()
        { 
        driver = new ChromeDriver(@"D:\");

        driver.Url = "https://www.idempiere.org/test-sites";
        }

        [Test, Order(1)]

        public void login()
        {
            IWebElement lognav = driver.FindElement(By.XPath("//a[contains(text(),'https://test.idempiere.org/webui/')]"));
            lognav.Click();

            Thread.Sleep(5000);

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Thread.Sleep(5000);

            IWebElement email = driver.FindElement(By.XPath("//*[@autocomplete='username']"));


            email.SendKeys("admin @ gardenworld.com");

            IWebElement pwd = driver.FindElement(By.XPath("//*[@autocomplete='current-password']"));

            pwd.SendKeys("GardenAdmin");

            IWebElement okbtn = driver.FindElement(By.XPath("//button[text()=' OK']"));

            okbtn.Click();

        }
        [Test, Order(2)]

        public void fillandresetform()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BP = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title= 'Maintain Business Partners']")));

            BP.Click();

            Thread.Sleep(5000);

            IWebElement Cnclbtn = driver.FindElement(By.XPath("//*[@title='Cancel']"));

            Cnclbtn.Click();


            IWebElement BP1 = driver.FindElement(By.XPath("//*[@title= 'Maintain Business Partners']"));
            BP1.Click();

            Thread.Sleep(5000);

            IWebElement skey = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));

            skey.SendKeys("Placeholder text");

            //Enter Name

            //Thread.Sleep(5000);

            IWebElement name = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));

            name.SendKeys("sagar");

            //Enter Name 2

            IWebElement name2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            name2.SendKeys("vande");

            //Enter Description

            IWebElement desc = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            desc.SendKeys("A/P:Bhilwadi");

            Thread.Sleep(2000);

            IWebElement rstbtn = driver.FindElement(By.XPath("//*[@title= 'Reset']"));
            rstbtn.Click();

            //verify each text field is empty

            string skeytxt = skey.GetAttribute("value");
            string nametext = name.GetAttribute("value");
            string name2text = name2.GetAttribute("value");
            string desctext = desc.GetAttribute("value");

            if ((skeytxt.Equals("") && name2text.Equals("")) && (nametext.Equals("") && desctext.Equals("")))
            {
                Console.WriteLine("All values are resetted");

            }

            else

                Console.WriteLine("Values are not resetted");

            IWebElement skey1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));

            skey1.SendKeys("Placeholder text");

            //Enter Name

            IWebElement name1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            name1.SendKeys("sagar");

            //Enter Name 2

            IWebElement name3 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            name3.SendKeys("vande");

            //Enter Description

            IWebElement desc1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            desc1.SendKeys("A/P:Bhilwadi");


            IWebElement okbtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/button[1]/img[1]"));
            okbtn.Click();
        }
    [Test, Order(3)]

public void newform()
        {
            Thread.Sleep(5000);

            IWebElement newform = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]"));

            newform.Click();

            //Enter name in new form

            Thread.Sleep(5000);

            IWebElement namee = driver.FindElement(By.XPath("//*[@title='Alphanumeric identifier of the entity' and @type='text']"));
            namee.SendKeys("sagar");
        }
[Test, Order(4)]

public void savebtn()
        {
            //click on save button

            IWebElement savebtn = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[4]/div/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/div[1]/a[6]/span/img"));

            savebtn.Click();

            Console.WriteLine("Record saved successfully");
        }


    }





        }
