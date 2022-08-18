using Mars_AdvanceTask.pages;
using MARS_AdvanceTask.Utilities;
using MARS_AdvanceTask.Shareskill;
using MARS_AdvanceTask.ProfilePage;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using MARS_AdvanceTask.Pages;

namespace MARS_AdvanceTask
{
    [TestFixture]
    [Parallelizable]

    public class ManageSkillTests : CommonDriver
    {


        [Test]
        public void HomepageTest()
        {

            Homepage Homepageobj = new Homepage(driver);
            Homepageobj.JoinInpage(driver);

        }

        [Test]
        public void SignInTest1()
        {

            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

        }
        
        [Test]
        public void ShareskillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageShareSkill manageshareskillobj = new ManageShareSkill(driver);
            manageshareskillobj.AddShareSkill(driver);


        }
        [Test]
        public void CancleSkillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageShareSkill manageshareskillobj = new ManageShareSkill(driver);
            manageshareskillobj.CancleShareskill(driver);
        }


        [Test]
        public void ViewTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.Listings(driver);


        }
        [Test]
        public void EditSkillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.EditSkill(driver);

        }
        [Test]
        public void DeleteTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.DeleteSkill(driver);


        }
    }
}