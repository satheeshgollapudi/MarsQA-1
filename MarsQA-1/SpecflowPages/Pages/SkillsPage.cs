using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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

    internal class SkillsPage
    {

        public SkillsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/a[contains(text(),'Profile')]")]
        private IWebElement Profiletab { get; set; }

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        private IWebElement ClickSkillstab { get; set; }

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewButton { get; set; }


        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement AddSkill { get; set; }


        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//select[@name='level']/option[2]")]
        private IWebElement SkillLevel { get; set; }


        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddButton { get; set; }






        #endregion

        public void ClickSkillsTab()

        {



            // Click on Profile tab
            Profiletab.Click();


            //Click on Skill Tab
            ClickSkillstab.Click();
        }

        public void AddANewSkill()
        {



            //Click on Add New button
            AddNewButton.Click();

            //Add Skill
            AddSkill.SendKeys("Manual");

            //Click on Skill Level
            SkillLevel.Click();

            //Click on Add button
            AddButton.Click();

        }

    }
}
