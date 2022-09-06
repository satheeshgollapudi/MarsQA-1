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

namespace MarsQA_1.SpecflowPages.Pages
{ 
    [Binding]
    internal class EducationTest
    { 

        EducationPage EP= new EducationPage();
    
        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
             //Wait
             Thread.Sleep(1500);

                      EP.ClickEducationTab();
        }

        [When(@"I add my education including (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIAddMyEducationIncluding(String Country,String University,String Title,String Degree, int Year)
        {
            throw new PendingStepException();
        }


        [When(@"I add a new Education")]
        public void WhenIAddANewEducation()
        {
            
            EP.AddNewEducation();
            
        }

        [Then(@"that Education should be displayed on my listings")]
        public void ThenThatEducationShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education", "Degree");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = "Masters";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Masters')]")).Text;
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

        [Then(@"I am able to see my education details including (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIAmAbleToSeeMyEducationDetailsIncluding(String Country, String University, String Title, String Degree, int Year)
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education", "Education");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedCountry = Country;

                string ActualCountry = Driver.driver.FindElement(By.XPath("//td[text()='" + Country + "']")).Text;
                Thread.Sleep(500);
                if (ExpectedCountry == ActualCountry)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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

    

