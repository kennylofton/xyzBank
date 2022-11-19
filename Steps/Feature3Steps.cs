using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature3Steps
    {
        public IWebDriver driver = WebHook.driver;
        customerLoginPageObjects _customerLoginPageObjects = new customerLoginPageObjects();

        [Given(@"I select the withdrawal button")]
        public void GivenISelectTheWithdrawalButton()
        {
            _customerLoginPageObjects.clickCustomerLoginButton();
            _customerLoginPageObjects.selectRightCustomer();
            _customerLoginPageObjects.clickLoginButton();
            _customerLoginPageObjects.validateUserIsLoggedIn();
            _customerLoginPageObjects.clickWithdrawalHeader();
        }
        
        [When(@"I Input a withdrawal amount")]
        public void WhenIInputAWithdrawalAmount()
        {
            _customerLoginPageObjects.inputWithdrawalAmount();
        }
        
        [When(@"I Select withdraw")]
        public void WhenISelectWithdraw()
        {
            _customerLoginPageObjects.clickWithdrawalButton();
        }
        
        [Then(@"I should get a withdrawal succefful message")]
        public void ThenIShouldGetAWithdrawalSucceffulMessage()
        {
            _customerLoginPageObjects.validateSuccessfultransaction();
        }
    }
}
