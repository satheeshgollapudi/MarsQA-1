using MarsQA_1.Helpers;
using NUnit.Framework;
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
            Driver.TurnOnWait();

            EP.ClickEducationTab();
        }

        [When(@"I add my education including (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIAddMyEducationIncluding(String Country,String University,String Title,String Degree, int Year)
        {
            EP.AddNewEducation(Country, University, Title, Degree, Year);
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
                Driver.TurnOnWait();
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education", "Degree");
                //Start the Reports


                string ExpectedValue = "Masters";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Masters')]")).Text;
                Driver.TurnOnWait();
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.That(ActualValue, Is.EqualTo(ExpectedValue));

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
                Driver.TurnOnWait();
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education", "Education");
                //Start the Reports

                string ExpectedCountry = Country;

                //string ActualCountry = Driver.driver.FindElement(By.XPath("//td[text()='" + Country + "']")).Text;
                String ActualCountry=EP.GetText(Country);


                if (ExpectedCountry == ActualCountry)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.That(ActualCountry, Is.EqualTo(ExpectedCountry));

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }


        }


    }
}

    

