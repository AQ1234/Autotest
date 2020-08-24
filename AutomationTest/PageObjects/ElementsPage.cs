using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutomationTest.PageObjects
{
   public class ElementsPage
    {
        private readonly IWebDriver _driver;

        public ElementsPage(IWebDriver driver)
        {
            this._driver = driver;
        
        }

        [FindsBy(How = How.ClassName, Using = ".btn btn-light active")]
        public IWebElement TextBox;



    }
}
