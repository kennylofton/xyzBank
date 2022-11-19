using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using xyzBank.Hooks;
using xyzBank.PageObjects;

namespace xyzBank.Steps
{
    [Binding]
    public class Feature6Steps
    {
        public IWebDriver driver = WebHook.driver;
        bankManagerLoginPageObjects _bankManagerLoginPageObjects = new bankManagerLoginPageObjects();

        [Given(@"Select bank manager login")]
        public void GivenSelectBankManagerLogin()
        {
            _bankManagerLoginPageObjects.clickBankManagerLoginButton();
        }
        
        [When(@"I Select Add customer header")]
        public void WhenISelectAddCustomerHeader()
        {
            _bankManagerLoginPageObjects.clickAddCustomerHeading();
        }
        
        [When(@"I Provide customer details")]
        public void WhenIProvideCustomerDetails()
        {
            _bankManagerLoginPageObjects.inputFirstNameField();
            _bankManagerLoginPageObjects.inputLastNameField();
            _bankManagerLoginPageObjects.inputPostCode();
        }
        
        [When(@"I Select add customer")]
        public void WhenISelectAddCustomer()
        {
            _bankManagerLoginPageObjects.clickaddCustomerButton();
        }
        
        [Then(@"I should get a succeful validation message")]
        public void ThenIShouldGetASuccefulValidationMessage()
        {
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
