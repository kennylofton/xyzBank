using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace xyzBank.Hooks
{
    [Binding]
    public sealed class WebHook
    {
        public static IWebDriver driver;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }
    }
}
