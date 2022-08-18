using MARS_AdvanceTask.Pages;
using MARS_AdvanceTask.ProfilePage;
using MARS_AdvanceTask.Utilities;

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_AdvanceTask.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ProfileTest : CommonDriver
    {
        [Test, Order(1)]
        public void ManageDescription()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.addDesc(driver);
        }
        [Test,Order(2)]
        public void EditDescription()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.editDesc(driver);
        }

        [Test, Order(3)]
        public void Addlanguage()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.addLanguage(driver);
        }
        [Test, Order(4)]
        public void Editlanguage()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.editLanguage(driver);
        }
        [Test,Order(5)]
        public void Deletelanguage()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.deleteLanguage(driver);
        }
        [Test, Order(6)]
        public void Addskill()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.Addskill(driver);

        }
        [Test, Order(7)]
        public void Editskill()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.editSkill(driver);

        }
        [Test, Order(8)]
        public void Deleteskill()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.delSkill(driver);

        }
    }
}
