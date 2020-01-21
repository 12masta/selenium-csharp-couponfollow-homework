using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace TestFramework.PageObjects.SitePage
{
    public class SitePageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        public SitePageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public ISitePage Create()
        {
            return new SitePage(driverWrapper, wait, webElementComposer);
        }

        public ISitePage Create(string path)
        {
            return new SitePage(driverWrapper, wait, webElementComposer, path);
        }
    }
}