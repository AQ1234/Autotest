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

        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement submitBtnForms;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Jurek Jarecki')]")]
        private IWebElement fullName;

        [FindsBy(How = How.ClassName, Using = "css-tlfecz-indicatorContainer")]
        private IWebElement stateAndCity;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]")]
        private IWebElement harayna;
        #region Methods
        public FormsPage GoToPractiseForm()
        {
            practiseForm.Click();
            return this;

        }
        public FormsPage InputFirstName(string inputFirstName)
        {
            firstName.SendKeys(inputFirstName);
            return this;
        }
        public FormsPage InputLastName(string inputLastName)
        {
            lastName.SendKeys(inputLastName);
            return this;
        }
        public FormsPage InputGender()
        {
            maleGender.Click();
            return this;
        }
        public FormsPage InputNumber(string inputNumber)
        {
            mobileNumber.SendKeys(inputNumber);
            return this;
        }
        public FormsPage InputHobby()
        {
            hobbySport.Click();
            return this;
        }
        public FormsPage ClickSubmit()
        {
            
            submitBtnForms.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return this;
        }
        public FormsPage SelectStateAndCity()
        {

            stateAndCity.Click();
           // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            harayna.Click();

            return this;
        }
        #endregion
#region Asserts
        public FormsPage AssertFormsPageIsDisplayed()
        {

            Assert.True(fullName.Displayed);

            return this;
        }
               
        public FormsPage AssertIsFullNameIsCorrect(string inputFirstName, string inputLastName)
        {
            string expectedFullName = inputFirstName + " " + inputLastName;
            string actualFullName = _driver.FindElement(By.XPath("//td[contains(text(),'Jurek Jarecki')]")).Text;
            Assert.Equal(expectedFullName, actualFullName);

            return this;
        }
        #endregion


    }
}
