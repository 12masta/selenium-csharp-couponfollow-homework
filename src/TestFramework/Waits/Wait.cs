using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFramework.DriverWrapper;
using TestFramework.Element;

namespace TestFramework.Waits
{
    public class Wait : IWait
    {
        private WebDriverWait webDriverWait;
        private IWebElementComposer webElementComposer;
        private IDriverWrapper driverWrapper;
        private TimeSpan defaultTimeout;

        public Wait(WebDriverWait webDriverWait, IWebElementComposer webElementComposer, IDriverWrapper driverWrapper)
        {
            this.webDriverWait = webDriverWait;
            this.webElementComposer = webElementComposer;
            this.driverWrapper = driverWrapper;
            defaultTimeout = webDriverWait.Timeout;

        }

        public IWait UntilElementIsDisplayed(IWebElement searchList)
        {
            webDriverWait.Until(_ => webElementComposer.IsDisplayed(searchList) == true);
            return this;
        }

        public IWait UntilElementIsDisplayed(IWebElement searchList, TimeSpan timeSpan)
        {
            webDriverWait.Timeout = timeSpan;
            UntilElementIsDisplayed(searchList);
            webDriverWait.Timeout = defaultTimeout;
            return this;
        }

        public IWait UntilWindowsCountIsHigherThan(int v)
        {
            webDriverWait.Until(_ => driverWrapper.Driver.WindowHandles.Count > v);
            return this;
        }
    }
}