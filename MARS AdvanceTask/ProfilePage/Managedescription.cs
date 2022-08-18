using MARS_AdvanceTask.Utilities;

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_AdvanceTask.ProfilePage
{
    public class Managedescription
    {
       public IWebDriver driver;
        // Add Description

        [FindsBy(How = How.XPath,Using= "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        public IWebElement descriptionButton { get; set; }

        [FindsBy(How =How.XPath,Using= "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        public IWebElement descriptionTextbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        public IWebElement saveBtn { get; set; }
        
        //Edit Description
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        public IWebElement editDescbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
       public IWebElement editDescTextbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        public IWebElement saveButton { get; set; }

        //Delete Description
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        public IWebElement deldescbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        public IWebElement delDescTextbox { get; set; } 
        
        public Managedescription(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);


        }
        public void addDesc(IWebDriver driver)
        {
            descriptionButton.Click();
            Thread.Sleep(1000);
            descriptionTextbox.Click();
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Hi I am Pinal");
            saveBtn.Click();
           // Thread.Sleep(2000);
            Wait.WaitToBeVisible(driver, "XPath","//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button",5);
        }
        public void editDesc(IWebDriver driver)
        {
            
            editDescbtn.Click();
            editDescTextbox.Click();
            editDescTextbox.Clear();
            editDescTextbox.SendKeys("Edited Description");
            saveButton.Click();

        }

        public void delDesc(IWebDriver driver)
        {
            Thread.Sleep(2000);
            deldescbtn.Click();
            delDescTextbox.Click();
            delDescTextbox.Clear();
            
        }

        public string GetDescription()
        {

            Thread.Sleep(2000);
                 
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;

        }
        public string GeteditedDescription()
        {

            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
            
        }









    }
}
