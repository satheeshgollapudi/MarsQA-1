﻿using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    internal class LanguageTest
    {

        LanguagePage LP = new LanguagePage();



        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);


            // Click on Profile tab
            LP.ClickLanguageTab();
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            LP.AddNewLanguage();
        }



        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add language", "launguage");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = "English";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }



        }

        [When(@"I add new Languages (.*) and (.*)")]
        public void WhenIAddNewLanguagesAnd(string language, string level)
        {

                   LP.AddNewLanguage(language, level);

        }

        [Then(@"All (.*) should be displayed as (.*) on my listings")]
        public void ThenAllShouldBeDisplayedAsOnMyListings(string Language, string Expected)
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add language", "launguage");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = Expected;

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='"+ Language+"']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }




        }

        [Then(@"there should be a pop up Please enter language and level")]
        public void ThenThereShouldBeAPopUpPleaseEnterLanguageAndLevel()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Pop up-Please enter language and level");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = "Please enter language and level";

                string ActualValue = Driver.driver.FindElement(By.XPath("//body/div/div[contains(text(),'Please enter language and level')]")).Text;
                Console.WriteLine("Actual value is" + ActualValue);
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "PopUp came Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "PopUp came Successfully");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }
        }



    }
}