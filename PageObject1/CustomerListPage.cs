using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2_SpecFlow.Pages
{
    public class CustomerListPage
    {
        private readonly IWebDriver _driver;
        private readonly By _sortByFirstNameLink = By.CssSelector("a[ng-click=\"sortType = 'fName'; sortReverse = !sortReverse\"]");
        private readonly By _customerNames = By.XPath("//table/tbody/tr/td[1]");

        public CustomerListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SortByFirstName()
        {
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(_sortByFirstNameLink).Click();
            _driver.FindElement(_sortByFirstNameLink).Click();
        }

        public List<string> GetCustomerNames()
        {
            return _driver.FindElements(_customerNames)
                          .Select(name => name.Text.Trim())
                          .ToList();
        }
    }
}
