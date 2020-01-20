using TestFramework.DriverWrapper;

namespace TestFramework.PageObjects
{
    public class BasePageObject
    {
        protected IDriverWrapper driverWrapper;

        public BasePageObject(IDriverWrapper driverWrapper)
        {
            this.driverWrapper = driverWrapper;
        }

        public BasePageObject(IDriverWrapper driverWrapper, string path)
        {
            this.driverWrapper = driverWrapper;
            driverWrapper.Load(path);
        }

        public string Url()
        {
            return driverWrapper.Url();
        }
    }
}