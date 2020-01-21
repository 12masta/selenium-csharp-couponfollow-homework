using OpenQA.Selenium;
using TestFramework.DriverWrapper;

namespace TestFramework.Highliters
{
    public class Highliter : IHighliter
    {
        private IDriverWrapper driverWrapper;

        public Highliter(IDriverWrapper driverWrapper)
        {
            this.driverWrapper = driverWrapper;
        }

        public IHighliter HighlightElement(IWebElement webElement)
        {
            ((IJavaScriptExecutor)driverWrapper.Driver).ExecuteScript("arguments[0].setAttribute('style','border: 2px solid red;');", webElement);
            return this;
        }
    }
}