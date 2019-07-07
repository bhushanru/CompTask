using CompTask.Helpers;
using OpenQA.Selenium;

using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompTask.Pages
{
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(CommonDriver.Driver, this);
        }

        //Define IwebELements
        //Share Skill button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement ShareSkillBtn { get; set; }

        //Title
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        //Description
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { get; set; }

        //Sub-Category
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement Subcategory { get; set; }

        //Tags
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        private IWebElement Tag1 { get; set; }

        //Service Type
        [FindsBy(How = How.Name, Using = "serviceType")]
        private IWebElement Servicetype { get; set; }

        //Location type
        [FindsBy(How = How.Name, Using = "locationType")]
        private IWebElement Locationtype { get; set; }

        //EndDate
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement Enddate { get; set; }

        //Monday Checkbox
        [FindsBy(How = How.XPath, Using = "//div[3]//div[1]//div[1]//input[1]")]
        private IWebElement MonCheck { get; set; }

        //Monday Start time
        [FindsBy(How = How.XPath, Using = "//div[3]//div[2]//input[1]")]
        private IWebElement MonStart { get; set; }

        //Monday End Time
        [FindsBy(How = How.XPath, Using = "//body//div[3]//div[3]//input[1]")]
        private IWebElement MonEnd { get; set; }

        //Tuesday Checkbox
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[4]//div[1]//div[1]//input[1]")]
        private IWebElement TuesCheck { get; set; }

        //Tuesday Start time
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[4]//div[2]//input[1]")]
        private IWebElement TuesStart { get; set; }

        //Tuesday End Time
        [FindsBy(How = How.XPath, Using = "//div[4]//div[3]//input[1]")]
        private IWebElement TuesEnd { get; set; }

        //Wednesday Checkbox
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[5]//div[1]//div[1]//input[1]")]
        private IWebElement WedCheck { get; set; }

        //Wednesday Start time
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[5]//div[2]//input[1]")]
        private IWebElement WedStart { get; set; }

        //Wednesday End Time
        [FindsBy(How = How.XPath, Using = "//div[5]//div[3]//input[1]")]
        private IWebElement WedEnd { get; set; }

        //Thursday Checkbox
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[6]//div[1]//div[1]//input[1]")]
        private IWebElement ThursCheck { get; set; }

        //Thursday Start time
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[6]//div[2]//input[1]")]
        private IWebElement ThursStart { get; set; }

        //Thursday End Time
        [FindsBy(How = How.XPath, Using = "//div[6]//div[3]//input[1]")]
        private IWebElement ThursEnd { get; set; }

        //Friday Checkbox
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[1]//div[1]//input[1]")]
        private IWebElement FriCheck { get; set; }

        //Friday Start time
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[2]//input[1]")]
        private IWebElement FriStart { get; set; }

        //Friday End Time
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[3]//input[1]")]
        private IWebElement FriEnd { get; set; }

        //Select Skill Trade
        [FindsBy(How = How.Name, Using = "skillTrades")]
        private IWebElement SkillTrade { get; set; }

        //Select Skill Exchange
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        private IWebElement SkillExchange { get; set; }

        //Selct Skill Active
        [FindsBy(How = How.Name, Using = "isActive")]
        private IWebElement SkillActive { get; set; }

        //Select Save
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Savebtn { get; set; }



        public void AddShareSkill(IWebDriver Driver)
        {
            //Click Share Skill button
            ShareSkillBtn.Click();
            Thread.Sleep(5000);
            
            //Title Input
            Title.SendKeys("Software Tester 7");

            //Description Input
            Description.SendKeys("I am an experienced software tester in both Manual and Automation");

            //Select Category
            var selectElement1 = new SelectElement(Category);
            selectElement1.SelectByValue("6");
            Console.WriteLine("Category selcted");

            //Select Sub-Catergory
           
            var selectElement2 = new SelectElement(Subcategory);
            selectElement2.SelectByText("QA");
            Console.WriteLine("Sub-Category selcted");

            //Select Tags
            Tag1.SendKeys("testing");
            Tag1.SendKeys(Keys.Enter);

            Console.WriteLine("Enter clicked");

            //Select Service Type
            Servicetype.Click();

            //Select Location Type
            Locationtype.Click();

            //Select End date
            Enddate.SendKeys("29-07-2019");

            //Input for the whole week
            //Monday time
            MonCheck.Click();
            MonStart.SendKeys("0900AM");
            MonEnd.SendKeys("0500PM");

            //Tuesday time
            TuesCheck.Click();
            
            TuesStart.SendKeys("0900AM");
            TuesEnd.SendKeys("0500PM");

            //Wednesday time
            WedCheck.Click();            
            WedStart.SendKeys("0900AM");
            WedEnd.SendKeys("0500PM");

            //Thursday time
            ThursCheck.Click();
            ThursStart.SendKeys("0900AM");
            ThursEnd.SendKeys("0500PM");

            //Friday time
            FriCheck.Click();
            FriStart.SendKeys("0900AM");
            FriEnd.SendKeys("0500PM");

            //Select Skill trade
            SkillTrade.Click();

            //Select Skill Exchange
            SkillExchange.SendKeys("automation");
            SkillExchange.SendKeys(Keys.Enter);

            //Select Active
            SkillActive.Click();

            //Click Save
            Savebtn.Click();
            Thread.Sleep(3000);

            //Verification
            
            //CommonDriver.Driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Click();
            //string ExpectedResult1 = "Software Tester 7";
            //string ActualResult1 = CommonDriver.Driver.FindElement(By.XPath("//td[contains(text(),'q')]")).Text;

            //if (ActualResult1 == ExpectedResult1)
            //{
            //    Console.WriteLine("Test Pass: Skill Added");
            //}
            //else
            //{
            //    Console.WriteLine("Test Fail: Skill Not Added");
            //}
        }
    }
}
