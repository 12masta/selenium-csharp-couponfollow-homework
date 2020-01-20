using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFramework.Element;

namespace TestFramework.Waits
{
    public class Wait : IWait
    {
        private WebDriverWait webDriverWait;
        private IWebElementComposer webElementComposer;
        private TimeSpan defaultTimeout;

        public Wait(WebDriverWait webDriverWait, IWebElementComposer webElementComposer)
        {
            this.webDriverWait = webDriverWait;
            this.webElementComposer = webElementComposer;
            defaultTimeout = webDriverWait.Timeout;

        }

        public IWait UntilElementIsNotDisplayed(IWebElement webElement)
        {
            webDriverWait.Until(_ => webElementComposer.IsDisplayed(webElement) == false);
            return this;
        }

        public IWait UntilElementIsNotDisplayed(By by)
        {
            webDriverWait.Until(_ => webElementComposer.IsDisplayed(by) == false);
            return this;
        }

        public IWait UntilElementIsNotDisplayed(By by, TimeSpan timeSpan)
        {
            webDriverWait.Timeout = timeSpan;
            UntilElementIsNotDisplayed(by);
            webDriverWait.Timeout = defaultTimeout;
            return this;
        }

        public IWait UntilElementIsNotDisplayed(IWebElement webElement, TimeSpan timeSpan)
        {
            webDriverWait.Timeout = timeSpan;
            UntilElementIsNotDisplayed(webElement);
            webDriverWait.Timeout = defaultTimeout;
            return this;
        }
    }
}