using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages
{
    internal class ramlang
    {
        public ramlang()
        {

            PageFactory.InitElements(Driver.driver, this);
        
    }
        //12345

        //12345

        //12345

        //12345

        //12345


        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")]
        private IWebElement Profiletab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        private IWebElement Languagetab { get; set; }

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Add New')]")]
        private IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//select/option[contains(text(),'Basic')]")]
        private IWebElement LanguageLevel { get; set; }

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddLanguage { get; set; }



        public void clicklanguage()
        {

            // Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")).Click();
            Profiletab.Click();
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();
            Languagetab.Click();

        }

        public void addlanguage()
        {
            //Click on Add New button
            AddNewButton.Click();

            //Add Language
            AddLanguage.SendKeys("English");

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//select/option[contains(text(),'Basic')]"));
            LanguageLevel.Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();

        }
    }




}


