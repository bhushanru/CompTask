using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public void AddShareSkill(IWebDriver driver)
        {
            //Click Share Skill button
            driver.FindElement(By.XPath("//a[@class='ui basic green button']")).Click();
            Thread.Sleep(5000);

            //Identify title
            IWebElement title = driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));

            //Title Input
            title.SendKeys("Software Tester");

            //Identity Description
            IWebElement description = driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));

            //Description Input
            description.SendKeys("I am an experiende software tester in both Manual and Automation");

            //Select Category
            var category = driver.FindElement(By.XPath("//select[@name='categoryId']"));
            var selectElement1 = new SelectElement(category);
            selectElement1.SelectByValue("6");
            Console.WriteLine("Category selcted");

            //Select Sub-Catergory
            var subcategory = driver.FindElement(By.XPath("//select[@name='subcategoryId']"));
            var selectElement2 = new SelectElement(subcategory);
            selectElement2.SelectByText("QA");
            Console.WriteLine("Sub-Category selcted");

            //Select Tags
            IWebElement tag1 = driver.FindElement(By.CssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField"));
            tag1.SendKeys("testing");
            tag1.SendKeys(Keys.Enter);

            Console.WriteLine("Enter clicked");

            //Select Service Type
            IWebElement service = driver.FindElement(By.Name("serviceType"));
            service.Click();

            //Select Location Type
            IWebElement location = driver.FindElement(By.Name("locationType"));
            location.Click();

            //Select End date
            IWebElement enddate = driver.FindElement(By.Name("endDate"));
            enddate.SendKeys("29-07-2019");

            //Input for the whole week
            //Monday time
            driver.FindElement(By.XPath("//div[3]//div[1]//div[1]//input[1]")).Click();
            IWebElement StartTime1 = driver.FindElement(By.XPath("//div[3]//div[2]//input[1]"));
            StartTime1.SendKeys("0900AM");
            IWebElement EndTime1 = driver.FindElement(By.XPath("//body//div[3]//div[3]//input[1]"));
            EndTime1.SendKeys("0500PM");

            //Tuesday time
            driver.FindElement(By.XPath("//div[@class='twelve wide column']//div[4]//div[1]//div[1]//input[1]")).Click();
            IWebElement StartTime2 = driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[4]//div[2]//input[1]"));
            StartTime2.SendKeys("0900AM");
            IWebElement EndTime2 = driver.FindElement(By.XPath("//div[4]//div[3]//input[1]"));
            EndTime2.SendKeys("0500PM");

            //Wednesday time
            driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[5]//div[1]//div[1]//input[1]")).Click();
            IWebElement StartTime3 = driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[5]//div[2]//input[1]"));
            StartTime3.SendKeys("0900AM");
            IWebElement EndTime3 = driver.FindElement(By.XPath("//div[5]//div[3]//input[1]"));
            EndTime3.SendKeys("0500PM");

            //Thursday time
            driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[6]//div[1]//div[1]//input[1]")).Click();
            IWebElement StartTime4 = driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[6]//div[2]//input[1]"));
            StartTime4.SendKeys("0900AM");
            IWebElement EndTime4 = driver.FindElement(By.XPath("//div[6]//div[3]//input[1]"));
            EndTime4.SendKeys("0500PM");

            //Friday time
            driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[7]//div[1]//div[1]//input[1]")).Click();
            IWebElement StartTime5 = driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[7]//div[2]//input[1]"));
            StartTime5.SendKeys("0900AM");
            IWebElement EndTime5 = driver.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[7]//div[3]//input[1]"));
            EndTime5.SendKeys("0500PM");

            //Select Skill trade
            IWebElement skilltrade = driver.FindElement(By.Name("skillTrades"));
            skilltrade.Click();

            //Select Skill Exchange
            IWebElement skillexchange1 = driver.FindElement(By.CssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField"));
            skillexchange1.SendKeys("automation");
            skillexchange1.SendKeys(Keys.Enter);

            //Select Active
            IWebElement active = driver.FindElement(By.Name("isActive"));
            active.Click();

            //Click Save
            IWebElement save = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            save.Click();

        }
    }
}
