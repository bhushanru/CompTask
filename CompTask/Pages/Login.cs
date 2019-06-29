using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using CompTask.Helpers;

namespace CompTask.Pages
{
    class Login
    {
        //Constructor
        public Login()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        //Define IWebElements
        //username
        [FindsBy(How = How.XPath,Using = "(//INPUT[@type='text'])[2]")]
        private IWebElement username { get; set; }

        //password
        [FindsBy(How = How.XPath,Using = "//INPUT[@type='password']")]
        private IWebElement password { get; set; }

        //Login Button
        [FindsBy(How = How.XPath,Using = "//BUTTON[@class='fluid ui teal button'][text()='Login']")]
        private IWebElement LoginBtn { get; set; }

     public void LoginSteps()
        {
            //Maximise Browser
            CommonDriver.driver.Manage().Window.Maximize();

            //Navigate to the url
            CommonDriver.driver.Navigate().GoToUrl("http://www.skillswap.pro/");
            Thread.Sleep(10000);

            //Click SignIn button
            CommonDriver.driver.FindElement(By.PartialLinkText("Sign In")).Click();
             
            //Input for username
            username.SendKeys("bhushanru@gmail.com");

            //Identify password
            password.SendKeys("bhubhu");

            //Click on login button
            LoginBtn.Click();

            //Wait for login screen
            Thread.Sleep(3000);


        }
    }
}
