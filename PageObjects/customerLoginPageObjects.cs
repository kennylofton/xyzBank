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
    class customerLoginPageObjects
    {
        public IWebDriver driver;

        public customerLoginPageObjects()
        {
            driver = WebHook.driver;
        }


        //private By customerLoginButton = By.CssSelector("[ng-click=customer()]");
        private By customerLoginButton = By.XPath("//button[@ng-click='customer()']");
        private By nevileLongbottom = By.XPath("//option[@value='5']");
        private By loginButton = By.XPath("//button[@type='submit']");
        private By dashboardTitle = By.LinkText("//span[contains(.,'Neville Longbottom')]");
        private By mainDepositFunction = By.XPath("//button[@ng-click='deposit()']");
        private By depositButton = By.XPath("//button[@type='submit']");
        private By depositSuccessfulMessage = By.XPath("//input[@type='number']");
        private By depositAmountField = By.XPath("//input[@type='number']");
        private By mainWithdrawalfunction = By.XPath("//button[@ng-click='withdrawl()']");
        private By withdrawButton = By.XPath("//input[@type='number']");
        private By transactionAmountField = By.XPath("//input[@type='number']");
        private By transactionSuccessfulMessage = By.XPath("//span[contains(.,'Transaction successful')]");
        private By accountDropDownPound = By.XPath("//option[contains(@label,'1014')]");
        private By accountDropDownRuppee = By.XPath("//option[@label='1015']");
        private By accountVerificationPound = By.XPath("//option[contains(@label,'1014')]");
        private By accountVerificationRuppee = By.XPath("//strong[contains(.,'1015')]");
        private By logoutButton = By.XPath("//strong[contains(.,'1015')]");
        private By homeButton = By.XPath("//button[@ng-click='home()']");

        public void clickCustomerLoginButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(customerLoginButton).Click();
        }

        public void selectRightCustomer()
        {
            Thread.Sleep(3000);
            driver.FindElement(nevileLongbottom).Click();
        }

        public void clickLoginButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(loginButton).Click();
        }

        public bool validateUserIsLoggedIn()
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(dashboardTitle);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void clickDepositHeader()
        {
            Thread.Sleep(3000);
            driver.FindElement(mainDepositFunction).Click();
        }

        public void inputDepositAmount()
        {
            Thread.Sleep(3000);
            driver.FindElement(depositAmountField).SendKeys("10");
        }

        public void clickDepositButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(depositButton).Click();
        }

        public bool validateDEpositSuccess()
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(depositSuccessfulMessage);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void clickWithdrawalHeader()
        {
            Thread.Sleep(3000);
            driver.FindElement(mainWithdrawalfunction).Click();
        }
        public void inputWithdrawalAmount()
        {
            Thread.Sleep(3000);
            driver.FindElement(transactionAmountField).SendKeys("10");
        }

        public bool validateSuccessfultransaction()
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(transactionSuccessfulMessage);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void clickWithdrawalButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(withdrawButton).Click();
        }
        public void changeAccountToPounds()
        {
            Thread.Sleep(3000);
            driver.FindElement(accountDropDownPound).Click();
        }

        public bool validateAccountChangeToPounds()
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(accountVerificationPound);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void changeAccountToRuppee()
        {
            Thread.Sleep(3000);
            driver.FindElement(accountDropDownRuppee).Click();
        }
        public bool validateAccountChangeToRuppee()
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(accountVerificationRuppee);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void clickLogout()
        {
            Thread.Sleep(3000);
            driver.FindElement(logoutButton).Click();
        }
        public void clickHomeButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(homeButton).Click();
        }




    }
}
