using OpenQA.Selenium;
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
        public void EditListing(IWebDriver driver)
        {
            //Click Manage Listings Menu
            driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Click();
            Thread.Sleep(5000);

            //Click Edit Icon
            IWebElement element = driver.FindElement(By.CssSelector("table.ui.striped.table:nth-child(1) tbody:nth-child(2) tr:nth-child(1) td.one.wide:nth-child(8) > i.outline.write.icon"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
            Console.WriteLine("Edit Icon Clicked");
            Thread.Sleep(5000);

            //Change Title
            IWebElement title = driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
            string title1 = title.Text;
            title.Clear();
            title.SendKeys("Industry Connect Software Tester");

            //Click Savebutton
            driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

            //Verification   
            var title2 = "Industry Connect Software Tester";
            
            
            if (title1 == title2)
            {
                Console.WriteLine("Test1 passed : title edited successfully");
            }
            else
            {
                Console.WriteLine("Test1 failed : Title not edited");
            }


        }

        public void DeleteListing(IWebDriver driver)
        {
            //Click Manage Listings Menu
            driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Click();
            Thread.Sleep(5000);

            //Click Delete Icon
            IWebElement element = driver.FindElement(By.CssSelector("table.ui.striped.table:nth-child(1) tbody:nth-child(2) tr:nth-child(1) td.one.wide:nth-child(8) > i.remove.icon"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
            Console.WriteLine("Deleted Icon Clicked");

            //click "Yes" in delete pop up
            driver.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']")).Click();

            //Verfication
            string ExpResult3 = "Software Tester has been deleted";
            Thread.Sleep(2000);
            string ActResult3 = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            if (ExpResult3 == ActResult3)
            {
                Console.WriteLine("Test 3 Pass : Record deleted successully");
            }
            else
            {
                Console.WriteLine("Test 3 Fail: Record not deleted");
            }
        }
    }
}
