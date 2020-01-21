using OpenQA.Selenium;

namespace TestFramework.Highliters
{
    public interface IHighliter
    {
        IHighliter HighlightElement(IWebElement webElement);
    }
}