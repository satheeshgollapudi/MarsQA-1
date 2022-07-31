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
    internal class Education
    {
        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")).Click();

            Thread.Sleep(1000);
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Education')]")).Click();
        }

        [When(@"I add a new Education")]
        public void WhenIAddANewEducation()
        {

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]")).Click();

            //Clickon College Name

            Driver.driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("Lincoln Uni");



            //Click on Country
            Driver.driver.FindElement(By.XPath("//select[@name='country']/option[8]")).Click();


            //Click on Title
            Driver.driver.FindElement(By.XPath("//select[@name='title']/option[8]")).Click();

            //Click on Degree
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("Masters");

            //Year of Graduation
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']/option[10]")).Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            
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

    }
}

    

