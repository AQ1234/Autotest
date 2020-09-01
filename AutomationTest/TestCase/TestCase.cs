using AutomationTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
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
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");

            HomePage homePage = PageFactory.InitElements<HomePage>(driver);
            //Act
            var elementsPage = homePage.GoToElementsPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            //Assert
            elementsPage.AssertElementsPageDisplayed();

            driver.Dispose();

        }

        [Fact]
        public void QATextBoxCaseForm()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/elements";
            //      var elementsPage = new ElementsPage(driver);
            ElementsPage elementsPage = PageFactory.InitElements<ElementsPage>(driver);
            //Act

            elementsPage.ClickTextBoxInMenuList();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            elementsPage.GoToMaleFieldElement();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            elementsPage.clickButton();
            //Assert
            elementsPage.AssertEqualItIsGoodName();

            // driver.Dispose();


        }

        [Fact]
        public void QAFormCase() //Zgodnie z ustaleniami tu jest całkowity test formularza, powyżej tylko poprawione
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            //  var formsPage = new FormsPage(driver);
            FormsPage formsPage = PageFactory.InitElements<FormsPage>(driver);
            //Act
            formsPage.GoToPractiseForm();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            formsPage.InputFirstName();
            formsPage.InputLastName();
            formsPage.InputGender();
            formsPage.InputNumber();
            formsPage.InputHobby();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            formsPage.ClickSubmit();
            //Assert
            formsPage.AssertFormsPageIsDisplayed();
            driver.Dispose();
        }

    }

}

