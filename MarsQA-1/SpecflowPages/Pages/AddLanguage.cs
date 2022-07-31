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
//using static MarsQA_1.Helpe

namespace MarsQA_1.SpecflowPages.Pages
{
    
    [Binding]
    internal class AddLanguage
    {
                
            [Given(@"I clicked on the Language tab under Profile page")]
            public void GivenIClickedOnTheLanguageTabUnderProfilePage()
            {
                //Wait
                Thread.Sleep(1500);

                // Click on Profile tab
                Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")).Click();
                Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();

        }

        [When(@"I add a new language")]
            public void WhenIAddANewLanguage()
            {
                //Click on Add New button
                Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')]")).Click();

                //Add Language

                Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("English");



            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'Basic')]"));
                Lang.Click();


                //Click on Add button
                Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
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
        
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')]")).Click();

            //Add Language

            Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(language);

            //Using Select method
            IWebElement element = Driver.driver.FindElement(By.Name("level"));
            //SelectElement selectElement = new SelectElement(element);
            // selectElement.SelectByText("Basic");

            //Click on Language Level
            //Driver.driver.FindElement(By.XPath("//select[@name='" + level + "']")).Click();
            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'Basic')]"));
            Lang.Click();

            


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        [Then(@"All (.*) should be displayed on my listings")]
        public void ThenAllLanguageShouldBeDisplayedOnMyListings(String Language)
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add language", "launguage");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = Language;

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='"+ Language + "']")).Text;
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

        [When(@"I add a new language by not entering one of the fields (.*) and (.*)")]
        public void WhenIAddANewLanguageByNotEnteringOneOfTheFieldsLanguageAndLevel(String Language, String Level)
        {
          

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')]")).Click();

            //Add Language

            Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(Language);

            //Using Select method
            // IWebElement element = Driver.driver.FindElement(By.Name("level"));
            //SelectElement selectElement = new SelectElement(element);
            // selectElement.SelectByText("Basic");

            //Click on Language Level
            //Driver.driver.FindElement(By.XPath("//select[@name='" + Level + "']")).Click();
            //Choose the language level
            
            Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'" + Level + "')]")).Click();

                
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();



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



