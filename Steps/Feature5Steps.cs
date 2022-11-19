using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature5Steps
    {
        public IWebDriver driver = WebHook.driver;
        customerLoginPageObjects _customerLoginPageObjects = new customerLoginPageObjects();

        [Given(@"I change account to Rupee")]
        public void GivenIChangeAccountToRupee()
        {
            _customerLoginPageObjects.clickCustomerLoginButton();
            _customerLoginPageObjects.selectRightCustomer();
            _customerLoginPageObjects.clickLoginButton();
            _customerLoginPageObjects.validateUserIsLoggedIn();
            _customerLoginPageObjects.changeAccountToRuppee();
        }
        
        [Then(@"the account number should change to show rupee")]
        public void ThenTheAccountNumberShouldChangeToShowRupee()
        {
            _customerLoginPageObjects.validateAccountChangeToRuppee();
        }
    }
}
