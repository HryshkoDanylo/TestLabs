using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Lab_2_SpecFlow.Pages;

namespace Lab_2_SpecFlow.StepDefinitions
{
    [Binding]
    public class CustomerListSortingStepDefinitions : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private readonly ManagerPage _managerPage;
        private readonly CustomerListPage _customerListPage;

        public CustomerListSortingStepDefinitions()
        {
            _driver = new ChromeDriver();
            _loginPage = new LoginPage(_driver);
            _managerPage = new ManagerPage(_driver);
            _customerListPage = new CustomerListPage(_driver);
        }

        [Given(@"I am on the bank login page")]
        public void GivenIAmOnTheBankLoginPage()
        {
            _loginPage.Open();
        }

        [When(@"I log in as a bank manager")]
        public void WhenILogInAsABankManager()
        {
            _loginPage.ClickBankManagerLogin();
        }

        [When(@"I navigate to the customers page")]
        public void WhenINavigateToTheCustomersPage()
        {
            _managerPage.NavigateToCustomers();
        }

        [When(@"I sort the customer list by first name")]
        public void WhenISortTheCustomerListByFirstName()
        {
            _customerListPage.SortByFirstName();
        }

        [Then(@"the customer list should be sorted in alphabetical order by first name")]
        public void ThenTheCustomerListShouldBeSortedInAlphabeticalOrderByFirstName()
        {
            var nameList = _customerListPage.GetCustomerNames();

            // Make a sorted copy
            var sortedNames = new List<string>(nameList);

            sortedNames.Sort();

            // Verify that the list is sorted
            CollectionAssert.AreEqual(sortedNames, nameList, "ERROR, the sorting operation was not successful");
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
