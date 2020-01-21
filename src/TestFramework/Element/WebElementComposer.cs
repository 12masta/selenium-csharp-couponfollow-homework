using System;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.Highliters;

namespace TestFramework.Element
{
    public class WebElementComposer : IWebElementComposer
    {
        private IDriverWrapper driverWrapper;
        private IHighliter highliter;

        public WebElementComposer(IDriverWrapper driverWrapper, IHighliter highliter)
        {
            this.driverWrapper = driverWrapper;
            this.highliter = highliter;
        }
        public IWebElementComposer Click(IWebElement webElement)
        {
            highliter.HighlightElement(webElement);
            webElement.Click();
            return this;
        }

        public string GetAttribute(IWebElement webElement, string attribute)
        {
            highliter.HighlightElement(webElement);
            return webElement.GetAttribute(attribute);
        }

        public bool IsDisplayed(IWebElement webElement)
        {
            try
            {
                return webElement.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsDisplayed(By by)
        {
            try
            {
                return driverWrapper.FindElement(by).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Selected(IWebElement webElement)
        {
            highliter.HighlightElement(webElement);
            return webElement.Selected;
        }

        public IWebElementComposer SendKeys(IWebElement webElement, string text)
        {
            highliter.HighlightElement(webElement);
            webElement.SendKeys(text);
            return this;
        }
    }
}