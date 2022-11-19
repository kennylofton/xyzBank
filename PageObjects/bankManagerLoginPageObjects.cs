using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xyzBank.Hooks;

namespace xyzBank.PageObjects
{
    class bankManagerLoginPageObjects
    {
        public IWebDriver driver;

        public bankManagerLoginPageObjects()
        {
            driver = WebHook.driver;
        }

        private By bankManagerLoginButton = By.XPath("//button[@ng-click='manager()']");
        private By addCustomerHeading = By.XPath("//button[@ng-click='addCust()']");
        private By firstNameField = By.XPath("//input[@placeholder='First Name']");
        private By lastNameField = By.XPath("//input[@placeholder='Last Name']");
        private By postcodeField = By.XPath("//input[@placeholder='Post Code']");
        private By addCustomerButton = By.XPath("//button[@type='submit']");
        
        

        public void clickBankManagerLoginButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(bankManagerLoginButton).Click();
        }

        public void clickAddCustomerHeading()
        {
            Thread.Sleep(3000);
            driver.FindElement(addCustomerHeading).Click();
        }

        public void inputFirstNameField()
        {
            Thread.Sleep(3000);
            driver.FindElement(firstNameField).SendKeys("test");
        }

        public void inputLastNameField()
        {
            Thread.Sleep(3000);
            driver.FindElement(lastNameField).SendKeys("test");
        }

        public void inputPostCode()
        {
            Thread.Sleep(3000);
            driver.FindElement(postcodeField).SendKeys("test");
        }
        public void clickaddCustomerButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(addCustomerButton).Click();
        }

    }
}
