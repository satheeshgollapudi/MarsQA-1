using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace MarsQA_1.SpecflowTests.Bind_Steps
namespace MarsQA_1.SpecflowPages.Pages
{
    internal class CertificationPage
    {

        public CertificationPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")]
        private IWebElement Profiletab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Certifications')]")]
        private IWebElement Certificationtab { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Certificate')]/following-sibling::th[3]/div[contains(text(),'Add New')]")]
        private IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement CertificationName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        private IWebElement CertifiedFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']/option[4]")]
        private IWebElement Year { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement ClickAddButton { get; set; }

        

        #endregion

        public void ClickCertificationTab()

        {

            //Wait
            Driver.TurnOnWait();

            // Click on Profile tab
            Profiletab.Click();

            
            //Click on Certifications Tab
            Certificationtab.Click();
        }

        public void AddNewCertification()
        {
            //Wait
            Driver.TurnOnWait();

            //Click on Add New button
            AddNewButton.Click();


            //Add Certificate Name
            CertificationName.SendKeys("Networking");

            //Add Certified from
            CertifiedFrom.SendKeys("Microsoft");


            //Year
            Year.Click();

            //Click on Add button
            ClickAddButton.Click();

        }
    }
}