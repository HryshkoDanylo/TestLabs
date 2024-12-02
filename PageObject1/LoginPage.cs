using OpenQA.Selenium;

namespace Lab_2_SpecFlow.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly By _bankManagerLoginButton = By.CssSelector("button.btn.btn-primary.btn-lg[ng-click='manager()']");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
        }

        public void ClickBankManagerLogin()
        {
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(_bankManagerLoginButton).Click();
        }
    }
}
