using MARS_AdvanceTask.ProfilePage;
using MARS_AdvanceTask.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions:CommonDriver
    {
        [When(@"I create a New Skill and Skill level Record")]
        public void WhenICreateANewSkillAndSkillLevelRecord()
        {
            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.Addskill(driver);
        }

        [Then(@"New Skill  and New Skill level record should be created successfully")]
        public void ThenNewSkillAndNewSkillLevelRecordShouldBeCreatedSuccessfully()
        {
            Manageskill manageskillobj = new Manageskill(driver);

            Assert.IsTrue(manageskillobj.GetSkill().Contains("Test Analyst"));

            Assert.IsTrue(manageskillobj.Getskilllevel().Contains("Beginner"));

        }

        [When(@"I edit a New Skill and Skill level Record")]
        public void WhenIEditANewSkillAndSkillLevelRecord()
        {
            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.editSkill(driver);

        }

        [Then(@"New edited Skill and Skill level record should be edited successfully")]
        public void ThenNewEditedSkillAndSkillLevelRecordShouldBeEditedSuccessfully()
        {
            Manageskill manageskillobj = new Manageskill(driver);

            Assert.IsTrue(manageskillobj.GeteditedSkill().Contains("Edited Skill"));

            Assert.IsTrue(manageskillobj.GeteditedSkillLevel().Contains("Expert"));
        }

        [When(@"I delete a Skill and Skill level Record")]
        public void WhenIDeleteASkillAndSkillLevelRecord()
        {
            Manageskill manageskillobj = new Manageskill(driver);
        }

        [Then(@"Skill record should be deleted successfully")]
        public void ThenSkillRecordShouldBeDeletedSuccessfully()
        {
            Manageskill manageskillobj = new Manageskill(driver);
        }
    }
}
