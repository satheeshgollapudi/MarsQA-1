using MarsQA_1.Helpers;
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
using static MarsQA_1.Helpers.CommonMethods;


namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    internal class CertificationsTest
    {
        CertificationPage CP = new CertificationPage();

        [Given(@"I clicked on the Certifications tab under Profile page")]
        public void GivenIClickedOnTheCertificationsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

          
            CP.ClickCertificationTab();
        }



        [When(@"I add a new certification")]
        public void WhenIAddANewCertification()
        {
           CP.AddNewCertification();
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

