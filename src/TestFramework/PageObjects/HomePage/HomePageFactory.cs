using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace TestFramework.PageObjects.HomePage
{
    public class HomePageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        public HomePageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IHomePage Create(string path)
        {
            return new HomePage(driverWrapper, wait, webElementComposer, path);
        }
    }
}