
using CompTask.Helpers;
using CompTask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonDriver.driver = new ChromeDriver();

            //steps to login
            Login obj1 = new Login();
            obj1.LoginSteps(CommonDriver.driver);

            //steps to Add a share skill
            ShareSkill obj2 = new ShareSkill();
            obj2.AddShareSkill(CommonDriver.driver);

            //Edit listing
            ManageListing obj3 = new ManageListing();
            obj3.EditListing(CommonDriver.driver);

            //Delete a listing
            obj3.DeleteListing(CommonDriver.driver);

            //Close Browser
            CommonDriver.driver.Close();

        }

    }
    
}
