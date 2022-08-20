using MarsQA_1.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    internal class SkillsTest
    {

        SkillsPage ST = new SkillsPage();

    [Given(@"I clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            ST.ClickSkillsTab();

                 }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
           

            Thread.Sleep(3000);
           ST.AddANewSkill();

        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Manual";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Manual')]")).Text;

                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
    }
}
