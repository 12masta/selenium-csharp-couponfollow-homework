using TestFramework.DriverWrapper;

namespace TestFramework.PageObjects.HomePage
{
    public class HomePage : BasePageObject, IHomePage
    {
        public HomePage(IDriverWrapper driverWrapper) : base(driverWrapper)
        {
        }

        public HomePage(IDriverWrapper driverWrapper, string path) : base(driverWrapper, path)
        {
        }
    }
}