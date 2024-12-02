//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;

//namespace Lab_2_SpecFlow.StepDefinitions
//{
//    [Binding]
//    public class CustomerListSortingStepDefinitions
//    {
//        private readonly IWebDriver _driver;

//        public CustomerListSortingStepDefinitions(ScenarioContext scenarioContext)
//        {
//            _driver = scenarioContext.Get<IWebDriver>("WebDriver");
//        }

//        [Given(@"I am on the bank login page")]
//        public void GivenIAmOnTheBankLoginPage()
//        {
//            _driver.Navigate().GoToUrl(" ");
//        }

//        [When(@"I log in as a bank manager")]
//        public void WhenILogInAsABankManager()
//        {
//            _driver.FindElement(By.CssSelector("button[ng-click='manager()']")).Click();
//        }

//        [When(@"I navigate to the customers page")]
//        public void WhenINavigateToTheCustomersPage()
//        {
//            _driver.FindElement(By.CssSelector("button[ng-click='showCust()']")).Click();
//        }

//        [When(@"I sort the customer list by first name")]
//        public void WhenISortTheCustomerListByFirstName()
//        {
//            _driver.FindElement(By.CssSelector("button[ng-click='sortType = \"fName\"']")).Click();
//        }

//        [Then(@"the customer list should be sorted in alphabetical order by first name")]
//        public void ThenTheCustomerListShouldBeSortedInAlphabeticalOrderByFirstName()
//        {
//            var customerNames = _driver.FindElements(By.XPath("//td[1]"));
//            var namesList = customerNames.Select(element => element.Text).ToList();
//            var sortedList = namesList.OrderBy(name => name).ToList();

//            Assert.IsTrue(namesList.SequenceEqual(sortedList), "Список не відсортовано в алфавітному порядку.");
//        }
//    }
//}
