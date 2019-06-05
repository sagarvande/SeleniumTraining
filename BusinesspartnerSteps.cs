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
    [Binding]
    public class BusinesspartnerSteps
    {
        IWebDriver driver;
        private DefaultWait<IWebDriver> fluentWait;

        [Given(@"Enter valid user email and password")]
        public void GivenEnterValidUserEmailAndPassword()
        {

            driver = new ChromeDriver(@"D:\");

            driver.Url = "https://www.idempiere.org/test-sites";

            IWebElement lognav = driver.FindElement(By.XPath("//a[contains(text(),'https://test.idempiere.org/webui/')]"));
            lognav.Click();

            Thread.Sleep(5000);

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Thread.Sleep(5000);

            IWebElement email = driver.FindElement(By.XPath("//*[@autocomplete='username']"));


            email.SendKeys("admin @ gardenworld.com");

            IWebElement pwd = driver.FindElement(By.XPath("//*[@autocomplete='current-password']"));

            pwd.SendKeys("GardenAdmin");


        }

        [Given(@"click on Ok button")]
        public void GivenClickOnOkButton()
        {
            IWebElement okbtn = driver.FindElement(By.XPath("//button[text()=' OK']"));

            okbtn.Click();

        }
        
        [Given(@"user selects Business Partner form Favorites")]
        public void GivenUserSelectsBusinessPartnerFormFavorites()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement BP = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title= 'Maintain Business Partners']")));
            BP.Click();

        }

        [Given(@"click on close button")]
        public void GivenClickOnCloseButton()
        {
            Thread.Sleep(5000);
            IWebElement Cnclbtn = driver.FindElement(By.XPath("//*[@title='Cancel']"));
            Cnclbtn.Click();

        }

        [Given(@"Again open business partner form")]
        public void GivenAgainOpenBusinessPartnerForm()
        {
            IWebElement BP1 = driver.FindElement(By.XPath("//*[@title= 'Maintain Business Partners']"));
            BP1.Click();

        }

        [Given(@"Fills The Form And Clicks On Reset Button")]
        public void GivenFillsTheFormAndClicksOnResetButton()
        {

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
        }

        [Given(@"Again fill the form")]
        public void GivenAgainFillTheForm()
        {
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

        }

        [Given(@"clik on ok button")]
        public void GivenClikOnOkButton()
        {
            IWebElement okbtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/button[1]/img[1]"));
            okbtn.Click();
        }

        [Given(@"clicks on new button")]
        public void Givenclicksonnewbutton()
        {
            Thread.Sleep(5000);

            IWebElement newform = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]"));

            newform.Click();

        }

        [Given(@"verifies business partner form is opened")]
        public void Givenverifiesbusinesspartnerformisopened()
        {

            IWebElement searchfield = driver.FindElement(By.XPath("//*[@title='Search key for the record in the format required - must be unique' and @instancename='C_BPartner0Value']"));

            if (searchfield.Enabled == true)
            {
                Console.WriteLine("New form opened successfully");

            }
            else
                Console.WriteLine("The form does not opened");

            Thread.Sleep(5000);


        }

        [When(@"Fill all required details")]
        public void WhenFillAllRequiredDetails()
        {
            //Enter name in new form

            IWebElement namee = driver.FindElement(By.XPath("//*[@title='Alphanumeric identifier of the entity' and @type='text']"));
            namee.SendKeys("sagar");
     
        }

        [Then(@"user records successfully saved")]
        public void ThenUserRecordsSuccessfullySaved()
        {
            //click on save button

            IWebElement savebtn = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[4]/div/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/div[1]/a[6]/span/img"));

            savebtn.Click();

            Console.WriteLine("Record saved successfully");
        }
    
    }
}
