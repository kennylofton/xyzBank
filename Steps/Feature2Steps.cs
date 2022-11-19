using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature2Steps
    {
        public IWebDriver driver = WebHook.driver;
        customerLoginPageObjects _customerLoginPageObjects = new customerLoginPageObjects();

        [Given(@"I Select the deposit button")]
        public void GivenISelectTheDepositButton()
        {
            _customerLoginPageObjects.clickCustomerLoginButton();
            _customerLoginPageObjects.selectRightCustomer();
            _customerLoginPageObjects.clickLoginButton();
            _customerLoginPageObjects.validateUserIsLoggedIn();
            _customerLoginPageObjects.clickDepositHeader();
        }
        
        [When(@"Input deposit amount")]
        public void WhenInputDepositAmount()
        {
            _customerLoginPageObjects.inputDepositAmount();
        }
        
        [When(@"I Select deposit button")]
        public void WhenISelectDepositButton()
        {
            _customerLoginPageObjects.clickDepositButton();
        }
        
        [Then(@"the deposit is successful")]
        public void ThenTheDepositIsSuccessful()
        {
            _customerLoginPageObjects.validateDEpositSuccess();
        }
    }
}
