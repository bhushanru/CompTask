using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompTask.Pages
{
    class ManageListing
    {
        public void EditListing(IWebDriver driver)
        {
            //Click Manage Listings Menu
            driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Click();

            //Click Edit Icon
            driver.FindElement(By.CssSelector("table.ui.striped.table:nth-child(1) tbody:nth-child(2) tr:nth-child(1) td.one.wide:nth-child(8) > i.outline.write.icon")).Click();

            //Change Title
            IWebElement title = driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
            title.Clear();
            title.SendKeys("Industry Connect Software Tester");

            //Click Savebutton
            driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

            //Verification   
            var ExpectedValue2 = "Industry Connect Software Tester";
            var ActualValue2 = driver.FindElement(By.XPath("//tr[1]//td[3]")).Text;
            if (ExpectedValue2 == ActualValue2)
            {
                Console.WriteLine("Test1 passed");
            }
            else
            {
                Console.WriteLine("Test1 failed");
            }


        }

        public void DeleteListing(IWebDriver driver)
        {

        }
    }
}
