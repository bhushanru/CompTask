using CompTask.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompTask.Pages
{
    class ManageListing
    {

        public ManageListing()
        {
            PageFactory.InitElements(CommonDriver.Driver, this);
        }
                       
        //Defining IWebElements
        //ManageListing Menu
        [FindsBy(How = How.CssSelector, Using = "div:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu > a.item:nth-child(3)")]
        public IWebElement ManageListingsMenu { get; set; }

        //Edit Icon Element
        [FindsBy(How = How.CssSelector, Using = "table.ui.striped.table:nth-child(1) tbody:nth-child(2) tr:nth-child(1) td.one.wide:nth-child(8) > i.outline.write.icon")]
        private IWebElement Element { get; set; }

        //Title
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        //Save Button
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement SaveBtn { get; set; }

        //Delete Icon
        [FindsBy(How = How.CssSelector, Using = "table.ui.striped.table:nth-child(1) tbody:nth-child(2) tr:nth-child(1) td.one.wide:nth-child(8) > i.remove.icon")]
        private IWebElement Delelement { get; set; }

        //Delete Icon
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement DelYes { get; set; }

        //ActualResult3
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement ActResult3 { get; set; }

        public void EditListing(IWebDriver Driver)
        {

            //Click Manage Listings Menu
            ManageListingsMenu.Click();
            Thread.Sleep(3000);

            //Click Edit Icon
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", Element);
            Thread.Sleep(5000);

            //Change Title
            string title1 = Title.Text;
            Title.Clear();
            Title.SendKeys("Industry Connect Software Tester");

            //Click Savebutton
            SaveBtn.Click();

            //Verification   
            var title2 = "Industry Connect Software Tester";
            if (title1 == title2)
            {
                Console.WriteLine("Test1 passed : title edited successfully");
                //Screenshots
                //Helpers.SaveScreenShotClass.SaveScreenshot(CommonDriver.Driver, "Edit Listing");
            }
            else
            {
                Console.WriteLine("Test1 failed : Title not edited");
            }


        }

        public void DeleteListing(IWebDriver Driver)
        {
            //Click Manage Listings Menu
            
            ManageListingsMenu.Click();
            Thread.Sleep(5000);

            //Click Delete Icon
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", Delelement);
            
            //click "Yes" in delete pop up
            DelYes.Click();

            //Verfication
            string ExpResult3 = "Software Tester has been deleted";
            Thread.Sleep(2000);
            string ActualResult3 = ActResult3.Text;

            if (ExpResult3 == ActualResult3)
            {
                Console.WriteLine("Test 3 Pass : Record deleted successully");
               // Helpers.SaveScreenShotClass.SaveScreenshot(CommonDriver.Driver, "Delete Listing");
            }
            else
            {
                Console.WriteLine("Test 3 Fail: Record not deleted");
            }
        }
    }
}
