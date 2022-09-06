using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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

    internal class EducationPage
    {

        public EducationPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")]
        private IWebElement Profiletab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Education')]")]
        private IWebElement ClickEducationtab { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr[1]/th[6]/div[1]")]
        private IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement CollegeName { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='country']/option[8]")]
        private IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='title']/option[8]")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement DegreeName { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']/option[10]")]
        private IWebElement YearOfGraduation { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddButton { get; set; }




        public void ClickEducationTab()
        {

            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Profiletab.Click();

            Thread.Sleep(1000);
            //Click on Education Tab
            ClickEducationtab.Click();
        }

        public void AddNewEducation()

        {


            //Click on Add New button
            AddNewButton.Click();

            //Clickon College Name
            CollegeName.SendKeys("Lincoln Uni");



            //Click on Country
            Country.Click();


            //Click on Title
            Title.Click();

            //Click on Degree
            DegreeName.SendKeys("Masters");

            //Year of Graduation
            YearOfGraduation.Click();


            //Click on Add button
            AddButton.Click();

        }


        public void AddNewEducation(String Country, String University, String Title, String Degree, int Year)
        {
            //Click on Add New button
            AddNewButton.Click();




            //Click on Country
            //Click on Title
            SelectElement CountryName = new SelectElement(Driver.driver.FindElement(By.Name("//select[@name='country']")));
            CountryName.SelectByText(Country);

            //University
            CollegeName.SendKeys(University);



            //Click on Title
            SelectElement TitleName = new SelectElement(Driver.driver.FindElement(By.Name("//select[@name='title']")));
            TitleName.SelectByText(Title);

            //Click on Degree
            DegreeName.SendKeys("Masters");

            //Year of Graduation
            YearOfGraduation.Click();


            //Click on Add button
            AddButton.Click();



        }

    }
}





#endregion