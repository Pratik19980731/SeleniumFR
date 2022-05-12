using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SeleniumFR
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;

        private static ExtentReports extent;
        private static string reportFile;
        private static string filePath;

        private ExtentManager()
        {

        }

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\PJ65867\source\repos\SeleniumFR\SeleniumFR\ExtentReport\ExtentManager.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("Host Name", "POOLW44ZLPC0197");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("UserName", "Pratik");


                string extentconfigPath = filePath + @"C:\Users\PJ65867\source\repos\SeleniumFR\SeleniumFR\ExtentConfig\extent-config.xml";
            }
            return extent;
        }
    }
}
