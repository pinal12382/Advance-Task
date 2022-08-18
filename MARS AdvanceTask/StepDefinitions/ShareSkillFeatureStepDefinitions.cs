using MARS_AdvanceTask.Pages;
using MARS_AdvanceTask.ProfilePage;
using MARS_AdvanceTask.Shareskill;
using MARS_AdvanceTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MARS_AdvanceTask.StepDefinitions
{
    [Binding]
    public class ShareSkillFeatureStepDefinitions:CommonDriver
    {
        [Given(@"\[I logged in to localhost  Sucessfully]")]
        public void GivenILoggedInToLocalhostSucessfully()
        {
            // open chrome browser

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            //signInpage object initilization and definition



            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);
        }

        [When(@"\[I added new skill record ]")]
        public void WhenIAddedNewSkillRecord()
        {
            ManageShareSkill manageshareskillobj = new ManageShareSkill(driver);
            manageshareskillobj.AddShareSkill(driver);
        }

        [Then(@"\[New skill record should be created Sucessfully]")]
        public void ThenNewSkillRecordShouldBeCreatedSucessfully()
        {
            ManageListings manageListingobj = new ManageListings();
            manageListingobj.Listings(driver);

            string Title = manageListingobj.gettitle();
            string Description = manageListingobj.getDesc();
            string Category = manageListingobj.getCat();

            Assert.That(Title == ExcelHelper.ReadData(2, "Title"), "Title not added sucessfully Test Failed");
            Assert.That(Description == ExcelHelper.ReadData(2, "Description"), "Description not added sucessfully Test Failed");
            Assert.That(Category == ExcelHelper.ReadData(2, "Category"), "Category not added sucesssfully Test Failed");
        }

        [Then(@"\[Close thr Browser]")]
        public void ThenCloseThrBrowser()
        {
            driver.Quit();
        }
        [When(@"\[I Edited new skill record ]")]
        public void WhenIEditedNewSkillRecord()
        {
            ManageListings manageListingobj = new ManageListings();
            manageListingobj.EditSkill(driver);
        }

        [Then(@"\[Edited skill record should be created Sucessfully]")]
        public void ThenEditedSkillRecordShouldBeCreatedSucessfully()
        {
            ManageListings manageListingobj = new ManageListings();
            manageListingobj.Listings(driver);

            string EditedTitle = manageListingobj.getEditedTitle();
            string EditedDescription = manageListingobj.getEditedDesc();
            string EditedCategory = manageListingobj.getEditedCat();

            Assert.That(EditedTitle == ExcelHelper.ReadData(3, "Title"), "Title not added sucessfully Test Failed");
            Assert.That(EditedDescription == ExcelHelper.ReadData(3, "Description"), "Description not added sucessfully Test Failed");
            Assert.That(EditedCategory == ExcelHelper.ReadData(3, "Category"), "Category not added sucesssfully Test Failed");

        }

        [When(@"\[I Delete new skill record ]")]
        public void WhenIDeleteNewSkillRecord()
        {
            ManageListings manageListingobj = new ManageListings();
            manageListingobj.DeleteSkill(driver);

        }

        [Then(@"\[New skill record should be deleted Sucessfully]")]
        public void ThenNewSkillRecordShouldBeDeletedSucessfully()
        {
            
        }

    }
}
