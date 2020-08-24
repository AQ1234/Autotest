using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutomationTest.PageObjects
{
   public class FormsPage
    {
        #region Constructor
        private readonly IWebDriver _driver;

        public FormsPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        #endregion

        [FindsBy(How = How.XPath, Using = "//div[@class='element-list collapse show']//li[@id='item-0']")]
        public IWebElement PractiseForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Male')]")]
        public IWebElement MaleGender { get; set; }
        #region Methods
        public FormsPage AssertFormsPageIsDisplayed()
        {
            Assert.True(PractiseForm.Displayed);
            return this;
        }

        #endregion
    }
}
