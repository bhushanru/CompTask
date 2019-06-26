using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            IWebDriver driver = new ChromeDriver();

            //Maximise Browser
            driver.Manage().Window.Maximize();

            //Navigate to the url
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");
            Thread.Sleep(10000);

            //Click SignIn button
            driver.FindElement(By.PartialLinkText("Sign In")).Click();

            //Identify username textbox
            IWebElement username = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));

            //Enter valid username
            username.SendKeys("bhushanru@gmail.com");

            //Identify password textbox
            IWebElement password = driver.FindElement(By.XPath("//INPUT[@type='password']"));

            //Enter password
            password.SendKeys("bhubhu");

            //Click on login button
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

            //Wait for login screen
            Thread.Sleep(7000);

        }
    }
}
