using TestFramework.DriverWrapper;

namespace TestFramework.PageObjects.HomePage
{
    public class HomePageFactory
    {
        private IDriverWrapper driverWrapper;

        public HomePageFactory(IDriverWrapper driverWrapper)
        {
            this.driverWrapper = driverWrapper;
        }

        public IHomePage Create()
        {
            return new HomePage(driverWrapper);
        }

        public IHomePage Create(string path)
        {
            return new HomePage(driverWrapper, path);
        }
    }
}