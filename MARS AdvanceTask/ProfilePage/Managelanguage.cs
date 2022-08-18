
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
    public class Managelanguage
    {
        public IWebDriver driver;

        // Add Language

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        public IWebElement languageTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        public IWebElement addNewbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        public IWebElement langTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        public IWebElement langlevelDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        public IWebElement addButton { get; set; }

        // Edit language


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        public IWebElement editlanguageTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        public IWebElement editlanguageBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input")]
        public IWebElement editlangtxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")]
        public IWebElement editlanglvlDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        public IWebElement updateButton { get; set; }

        // Delete Language

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        public IWebElement dellanTab { get; set; }


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")]
        public IWebElement Removelang { get; set; }


        public Managelanguage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        public void addLanguage(IWebDriver driver) 
        {

            languageTab.Click();
            Thread.Sleep(1000);
            addNewbutton.Click();
            langTextbox.Click();
            langTextbox.Clear();
            langTextbox.SendKeys("English");
            Thread.Sleep(1000);

            // choose Level

            langlevelDropdown.Click();
            langlevelDropdown.SendKeys("Fluent");
            addButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 5);
            //Thread.Sleep(2000);
        }

        public void editLanguage(IWebDriver driver)
        {
            editlanguageTab.Click();
            editlanguageBtn.Click();

            editlangtxt.Click();
            editlangtxt.Clear();
            editlangtxt.SendKeys("Hindi");

            editlanglvlDropdown.Click();
            editlanglvlDropdown.SendKeys("Native");

            updateButton.Click();
            Thread.Sleep(1000);
        }
        public void deleteLanguage(IWebDriver driver)
        {
            dellanTab.Click();
            Removelang.Click();
            Thread.Sleep(1000);

        }
        public string GetLanguage()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

        }
        public string GetLanguagelevel() 
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
                   
        }
        public string GeteditedLanguage()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            
        }
        public string GeteditedLanguagelevel()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            
        }
        public string deletelang()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            
        }


    }
}
