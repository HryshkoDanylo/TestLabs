using OpenQA.Selenium;

namespace Lab_2_SpecFlow.Pages
{
    public class ManagerPage
    {
        private readonly IWebDriver _driver;
        private readonly By _customersButton = By.CssSelector("button.btn.btn-lg.tab[ng-click='showCust()']");

        public ManagerPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToCustomers()
        {
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(_customersButton).Click();
        }
    }
}
