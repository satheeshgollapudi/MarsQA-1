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
    internal class Skills
    {

        [Given(@"I clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            Thread.Sleep(1000);
            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
           

            Thread.Sleep(3000);
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            //Add Skill
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Manual");

            //Click on Skill Level
            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();

            //Choose the Skill level
            IWebElement skill = Driver.driver.FindElement(By.XPath("//select[@name='level']/option[3]"));
            skill.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();

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
