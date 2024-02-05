using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //ScreenshotPath
        //public static string ScreenshotPath = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\onboarding.specflow-master\MarsQA-1\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\onboarding.specflow-master\MarsQA-1\TestReports\Report.html";

        //ReportXML Path
        public static string ReportXMLPath = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\onboarding.specflow-master\MarsQA-1\TestReports";
   
   
        public static String paths(String path)
        {

            //Path Added
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("currentDirectory" + currentDirectory);

            //string projectDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"MarsQA-1\TestReports\Screenshots\"));

            //Console.WriteLine("Project Directory: " + projectDirectory);
              string ScreenshotPath = Path.GetFullPath(Path.Combine(currentDirectory, path));
            return ScreenshotPath;
    }
    }
}