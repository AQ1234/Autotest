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
        private IWebElement practiseForm;

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstName;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastName;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Male')]")]
        private IWebElement maleGender;

        [FindsBy(How = How.Id, Using = "userNumber")]
        private IWebElement mobileNumber;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Sports')]")]
        private IWebElement hobbySport;

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Jurek Jarecki')]")]
        private IWebElement fullName;
        #region Methods
        public FormsPage GoToPractiseForm()
        {
            practiseForm.Click();
            return this;

        }
        public FormsPage InputFirstName()
        {
            firstName.SendKeys("Jurek");
            return this;
        }
        public FormsPage InputLastName()
        {
            lastName.SendKeys("Jarecki");
            return this;
        }
        public FormsPage InputGender()
        {
            maleGender.Click();
            return this;
        }
        public FormsPage InputNumber()
        {
            mobileNumber.SendKeys("1234567890");
            return this;
        }
        public FormsPage InputHobby()
        {
            hobbySport.Click();
            return this;
        }
        public FormsPage ClickSubmit()
        {
            submitBtn.Click();
            return this;
        }
        public FormsPage AssertFormsPageIsDisplayed()
        {

            Assert.True(fullName.Displayed);

            return this;
        }
        public FormsPage IsFullNameIsCorrect()
        {
            var name = _driver.FindElement(By.XPath("//td[contains(text(),'Jurek Jarecki')]"));
            Assert.Equal(name, fullName);

            return this;
        }


        #endregion
    }
}
