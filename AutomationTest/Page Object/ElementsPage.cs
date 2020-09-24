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
            _driver = driver;

        }

        [FindsBy(How = How.XPath, Using = "//div[@class='element-list collapse show']//li[@id='item-0']")]
        private IWebElement textBox;

        [FindsBy(How = How.Id, Using = "currentAddress-label")]
        private IWebElement someContentOfElementPage;

        [FindsBy(How = How.XPath, Using = "//input[@id='userName']")]
        private IWebElement maleField;

        [FindsBy(How = How.XPath, Using = "//p[@id='name']")]
        private IWebElement goodName;

        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement btnSubmit;

        public ElementsPage ClickTextBoxInMenuList()
        {

            textBox.Click();
            return this;
        }
        public ElementsPage GoToMaleFieldElement()
        {
            maleField.SendKeys("MiśPatyśXD");
            return this;
        }
        public ElementsPage clickButton()
        {
            btnSubmit.Click();
            return this;
        }

        public ElementsPage AssertElementsPageDisplayed()
        {
            Assert.True(textBox.Displayed);

            return this;
        }

        public ElementsPage AssertEqualItIsGoodName(string expectedWord)
        {
            expectedWord = "MiśPatyśxD";
            var name = _driver.FindElement(By.XPath("//p[@id='name")).Text;
            Assert.Equal(expectedWord, name = "MiśPatyśxD");
            return this;
        }
    }
}
