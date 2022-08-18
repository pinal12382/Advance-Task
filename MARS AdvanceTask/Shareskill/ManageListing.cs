using MARS_AdvanceTask.ProfilePage;
using MARS_AdvanceTask.Utilities;

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_AdvanceTask.Shareskill
{

    public class ManageListings
    {
        //public IWebDriver driver;
        public ManageListings()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//div/section[1]/div/a[3]")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        ////Delete the listing
        //[FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        //private IWebElement delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]
        private IWebElement delete { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesBtn { get; set; }


        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        // Assertion for add skill
        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")]
        private IWebElement Gettitle { get; set; }

        [FindsBy(How = How.XPath,Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]")]
        private IWebElement Getdescription { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]")]
        private IWebElement GetCategory { get; set; }   

        // Assertion for Edit Share Skill

        [FindsBy(How = How.XPath,Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")]
         private IWebElement GetEditedTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]")]
        private IWebElement GetEditedDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]")]
        private IWebElement GetEditedCategory { get; set; }
        public void Listings(IWebDriver driver)
        {
            manageListingsLink.Click();
            // Wait.WaitToBeVisible(driver,"XPath", "//div/section[1]/div/a[3]",5);
            //*[@id="account-profile-section"]/div/section[1]/div/a[3]
            Thread.Sleep(3000);
            view.Click();
            Thread.Sleep(3000);
            //Wait.WaitToBeVisible(driver,"XPath", "(//i[@class='eye icon'])[1]",5);


        }
        // Assertion
        public string gettitle()
        {
            Thread.Sleep(2000);
            string title = Gettitle.Text;
            return title;
        }

        public string getDesc()
        {
            Thread.Sleep(2000);
            string desc = Getdescription.Text;
            return desc;
        }
        public string getCat()
        {
            Thread.Sleep(2000);
            string cat = GetCategory.Text;
            return cat;
        }

        public void EditSkill(IWebDriver driver)
        {
            manageListingsLink.Click();
            Thread.Sleep(3000);
            // Wait.WaitToBeVisible(driver, "LinkText", "Manage Listings", 3);
            edit.Click();
            ManageShareSkill s = new ManageShareSkill(driver);
            s.EditShareSkill(driver);
        }
        public string getEditedTitle()
        {
            Thread.Sleep(3000);
            string editedTitle = GetEditedTitle.Text;
            return editedTitle;
        }
        public string getEditedDesc()
        {
            Thread.Sleep(2000);
            string editeddesc = GetEditedDescription.Text;
            return editeddesc;
        }
        public string getEditedCat()
        {
            Thread.Sleep(2000);
            string editedcat = GetEditedCategory.Text;
            return editedcat;
        }
        public void DeleteSkill(IWebDriver driver)
        {
            manageListingsLink.Click();
            Thread.Sleep(3000);
            //Wait.WaitbyClick(driver, "LinkText", "Manage Listings", 5);
            delete.Click();
            Thread.Sleep(2000);
            // Wait.WaitbyClick(driver, "XPath", "//div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i", 2);
            YesBtn.Click();
            Thread.Sleep(2000);
            //Wait.WaitbyClick(driver, "XPath", "/html/body/div[2]/div/div[3]/button[2]", 2);
        }

    }
}
