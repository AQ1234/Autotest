using AutomationTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutomationTest
{
    public class TestCase
    {
        [Fact]
        public void QATestCaseElements()
        {

            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            var homePage = new HomePage(driver);
            // PageFactory.InitElements(driver, homePage);

            //Act
            homePage.elements.Click();
            //Assert
            IWebElement contentElements = driver.FindElement(By.ClassName(".col-12 mt-4 col-md-6"));
            Assert.True(contentElements.Displayed);
            driver.Dispose();
        }

        [Fact]
        public void QATestCaseForm()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            var homePage = new HomePage(driver);
            // PageFactory.InitElements(driver, homePage);

            //Act
            homePage.elements.Click();
            //Assert
            IWebElement contentElements = driver.FindElement(By.ClassName(".col-12 mt-4 col-md-6"));
            Assert.True(contentElements.Displayed);
            driver.Dispose();
        }

        [Fact]
        public void QATextBoxCaseForm()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/elements";
            var elementsPage = new ElementsPage(driver);
            // PageFactory.InitElements(driver, homePage);

            //Act
            elementsPage.TextBox.SendKeys("myName");
            //Assert
            IWebElement contentElements = driver.FindElement(By.Id("#//input[@id='userName']"));
            Assert.True(contentElements.Displayed);
            driver.Dispose();
        }
        [Fact]
        public void QAFormCase()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            var formsPage = new FormsPage(driver);
            //Act
            formsPage.MaleGender.Click();
            //Assert
            IWebElement FormElement = driver.FindElement(By.XPath("//form[@id='userForm']"));
            Assert.True(FormElement.Displayed);
            driver.Dispose();
        }

        IWebDriver GoToURL(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            return driver;
        }
    }


}

