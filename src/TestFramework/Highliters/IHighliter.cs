using OpenQA.Selenium;

namespace TestFramework.Highliters
{
    public interface IHighliter
    {
        IHighliter HighlightElement(By by);
        IHighliter HighlightElement(IWebElement webElement);
    }
}