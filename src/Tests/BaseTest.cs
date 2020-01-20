using TestFramework.DriverWrapper;
using TestFramework.Dto;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TestFramework.Waits;
using OpenQA.Selenium.Support.UI;
using System;
using TestFramework.Element;
using TestFramework.Highliters;

namespace Tests
{
    public class BaseTest
    {
        protected IDriverWrapper driverWrapper;
        protected IWait wait;
        protected IWebElementComposer webElementComposer;
        protected IHighliter highliter;

        [SetUp]
        public void Setup()
        {
            var driverConfig = new DriverConfiguration()
                .Bind();
            driverWrapper = new DriverWrapper(new ChromeDriver(driverConfig.DriverPath), driverConfig);
            highliter = new Highliter(driverWrapper);
            webElementComposer = new WebElementComposer(driverWrapper, highliter);
            wait = new Wait(new WebDriverWait(driverWrapper.Driver, TimeSpan.FromSeconds(driverConfig.DefaultTimeout)), webElementComposer);
        }

        [TearDown]
        public void TearDown()
        {
            driverWrapper.Dispose();
        }
    }
}
