using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompTask.Helpers
{
    class CommonDriver
    {
        //Init Common Driver
        public static IWebDriver Driver { set; get; }
    }

    //Screenshots
    #region screenshots
    public class SaveScreenShotClass
    {
        public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
        {
            var folderLocation = @"C:\Users\Bhushan\source\repos\CompTask\CompTask\Screenshots\";

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(ScreenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
            //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
            fileName.Append(".jpeg");
            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
            return fileName.ToString();
        }
    }
    #endregion
}

