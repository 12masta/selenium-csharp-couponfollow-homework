using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace TestFramework.PageObjects.ExternalSitePage
{
    public class ExternalSitePageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        public ExternalSitePageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IExternalSitePage Create()
        {
            return new ExternalSitePage(driverWrapper, wait, webElementComposer);
        }
    }
}