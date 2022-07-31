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
    internal class Certifications
    {

        [Given(@"I clicked on the Certifications tab under Profile page")]
        public void GivenIClickedOnTheCertificationsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")).Click();

            Thread.Sleep(1000);
            //Click on Certifications Tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]")).Click();
        }



        [When(@"I add a new certification")]
        public void WhenIAddANewCertification()
        {
            Thread.Sleep(3000);
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//th[contains(text(),'Certificate')]/following-sibling::th[3]/div[contains(text(),'Add New')]")).Click();
            

            //Add Certificate Name
            Driver.driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys("Networking");

            //Add Certified from
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys("Networking");


            //Year
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']/option[4]")).Click();


        }

        [Then(@"that certification should be displayed on my listings")]
        public void ThenThatCertificationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "Networking";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Networking')]")).Text;

                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Added");
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

