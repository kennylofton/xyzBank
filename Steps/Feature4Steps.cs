using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature4Steps
    {
        public IWebDriver driver = WebHook.driver;
        customerLoginPageObjects _customerLoginPageObjects = new customerLoginPageObjects();

        [Given(@"I change account type to show the currency pound")]
        public void GivenIChangeAccountTypeToShowTheCurrencyPound()
        {
            _customerLoginPageObjects.clickCustomerLoginButton();
            _customerLoginPageObjects.selectRightCustomer();
            _customerLoginPageObjects.clickLoginButton();
            _customerLoginPageObjects.validateUserIsLoggedIn();
            _customerLoginPageObjects.changeAccountToPounds();
        }
        
        [Then(@"the account number should change")]
        public void ThenTheAccountNumberShouldChange()
        {
            _customerLoginPageObjects.validateAccountChangeToPounds();
        }
    }
}
