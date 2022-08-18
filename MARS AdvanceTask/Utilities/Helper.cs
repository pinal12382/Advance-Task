using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_AdvanceTask.Utilities
{

    public class Helper
    {
        public IWebDriver driver;

        //ScreenshotPath
        public static string ScreenshotPath = @"C:\Users\Pinal\Desktop\MVPstudio Intenship\Advance Task\MARS AdvanceTask\TestReports\ScreenShots";

        //ExtentReportsPath
        public static string ReportsPath = @"C:\Users\Pinal\Desktop\MVPstudio Intenship\Advance Task\MARS AdvanceTask\TestReports\TestFile\";

        public static string ReportXMLPath = @"C:\Users\Pinal\Desktop\MVPstudio Intenship\Advance Task\MARS AdvanceTask\TestReports\TestFile\XMLFile";
    }
}
