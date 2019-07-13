
using CompTask.Helpers;
using CompTask.Pages;
using NUnit.Framework;
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
    [TestFixture]
    class Program
    {
        [SetUp]
        public void Login()
        {
            CommonDriver.Driver = new ChromeDriver();
            //Populate Excel Sheet
            Helpers.ExcelLib.PopulateInCollection(@"C:\Users\Bhushan\source\repos\CompTask\CompTask\ExcelData\TestData.xlsx.xlsx", "LoginTestData");
            //steps to login
            Login obj1 = new Login();
            obj1.LoginSteps();

        }

        [Test]
        public void AddSkill()
        {
            //Populate Excel Sheet
            Helpers.ExcelLib.PopulateInCollection(@"C:\Users\Bhushan\source\repos\CompTask\CompTask\ExcelData\TestData.xlsx.xlsx", "ShareSkillTestData");
            //steps to Add a share skill
            ShareSkill obj2 = new ShareSkill();
            obj2.AddShareSkill(CommonDriver.Driver);

        }

        [Test]
        public void EditSkill()
        {
            //Populate Excel Sheet
            Helpers.ExcelLib.PopulateInCollection(@"C:\Users\Bhushan\source\repos\CompTask\CompTask\ExcelData\TestData.xlsx.xlsx", "EditShareSkillTestData");

            //Edit listing
            ManageListing obj3 = new ManageListing();
            obj3.EditListing(CommonDriver.Driver);

        }

        [Test]
        public void DelSkill()
        {
            //Populate Excel Sheet
            Helpers.ExcelLib.PopulateInCollection(@"C:\Users\Bhushan\source\repos\CompTask\CompTask\ExcelData\TestData.xlsx.xlsx", "ShareSkillTestData");

            //Delete a listing
            ManageListing obj3 = new ManageListing();
            obj3.DeleteListing(CommonDriver.Driver);
 
        }

        [TearDown]
        public void FlushTest()
        {

            //Close Browser
            CommonDriver.Driver.Close();
        }

        static void Main(string[] args)
        {

        }

    }
    
}
