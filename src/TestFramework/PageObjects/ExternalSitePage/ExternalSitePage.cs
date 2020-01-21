using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using System.Linq;
using TestFramework.Element;
using TestFramework.Waits;
using System;

namespace TestFramework.PageObjects.ExternalSitePage
{
    public class ExternalSitePage : BasePageObject, IExternalSitePage
    {
        private IWait wait;
        private IWebElementComposer webElementComposer;

        public ExternalSitePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public ExternalSitePage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, string path) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }
    }
}