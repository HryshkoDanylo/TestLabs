using OpenQA.Selenium;

namespace PageObject1
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
