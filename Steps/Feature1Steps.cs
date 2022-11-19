using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature1Steps
    {
        public IWebDriver driver = WebHook.driver;
        customerLoginPageObjects _customerLoginPageObjects = new customerLoginPageObjects();

        [Given(@"I Click the customer login")]
        public void GivenIClickTheCustomerLogin()
        {
            _customerLoginPageObjects.clickCustomerLoginButton();
        }
        
        [Given(@"Select Neville longbottom")]
        public void GivenSelectNevilleLongbottom()
        {
            _customerLoginPageObjects.selectRightCustomer();
        }
        
        [Given(@"I Select login")]
        public void GivenISelectLogin()
        {
            _customerLoginPageObjects.clickLoginButton();
        }
        
        [Then(@"I should be presented with the seleceted user account")]
        public void ThenIShouldBePresentedWithTheSelecetedUserAccount()
        {
            _customerLoginPageObjects.validateUserIsLoggedIn();
        }
    }
}
