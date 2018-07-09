﻿using System;
using System.Reflection;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OnlineExam.Framework;
using Xunit;

namespace OnlineExam.Tests
{
    public class BaseFixture : IDisposable
    {
        public ExtentHtmlReporter htmlReporter;
        public ExtentReports extentReports;
        public ExtentTest test;


        public string path;
        public string actualPath;
        public string projectPath;
        public string reportPath;

        //[OneTimeSetUp]
        public BaseFixture()
        {
            path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            actualPath = path.Substring(0, path.LastIndexOf("bin"));
            projectPath = new Uri(actualPath).LocalPath;
            reportPath = projectPath + "Reports\\MyOwnReport.html";


            htmlReporter = new ExtentHtmlReporter(reportPath);
            extentReports = new ExtentReports();
            extentReports.AttachReporter(htmlReporter);


            //extentReports.AddSystemInfo("Host Name", "http://localhost:55842/");
            //extentReports.AddSystemInfo("Environment", "QA");
            //// make the charts visible on report open
            //htmlReporter.Configuration().ChartVisibilityOnOpen = true;


            //// report title
            //htmlReporter.Configuration().DocumentTitle = "aventstack - ExtentReports";

            //// encoding, default = UTF-8
            //htmlReporter.Configuration().Encoding = "UTF-8";

            //// protocol (http, https)
            //htmlReporter.Configuration().Protocol = Protocol.HTTPS;

            //// report or build name
            //htmlReporter.Configuration().ReportName = "Build-1224";


            //// theme - standard, dark
            //htmlReporter.Configuration().Theme = Theme.Dark;
            

            //extent = new ExtentReports(reportPath, true);
            //extent
            //    .AddSystemInfo("Host Name", "http://localhost:55842/")
            //    .AddSystemInfo("Environment", "QA");
            //extent.LoadConfig(projectPath + "extent-config.xml");
        }

        //[OneTimeTearDown]
        public void Dispose()
        {
          
            extentReports.Flush();
        }
    }
}