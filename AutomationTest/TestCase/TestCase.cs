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
            System.Threading.Thread.Sleep(800);
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
            string word = "MiśPatyśXD";
            ElementsPage elementsPage = PageFactory.InitElements<ElementsPage>(driver);
            //Act

            elementsPage.ClickTextBoxInMenuList();
            System.Threading.Thread.Sleep(250);
            elementsPage.GoToMaleFieldElement();
            System.Threading.Thread.Sleep(800);
            elementsPage.clickButton();
            //Assert
            elementsPage.AssertEqualItIsGoodName(word);
             driver.Dispose();
        }

        [Fact]
        public void QAFormCase() //Zgodnie z ustaleniami tu jest całkowity test formularza, powyżej tylko poprawione
        {
            //Arrange

            // Dane testowe
            string inputFirstName = "Jurek";
            string inputLastName = "Jarecki";
            string inputNumber = "1234567890";
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/automation-practice-form";
            //  var formsPage = new FormsPage(driver);
            FormsPage formsPage = PageFactory.InitElements<FormsPage>(driver);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //Act
            formsPage.GoToPractiseForm();
            formsPage.InputFirstName(inputFirstName);
            System.Threading.Thread.Sleep(25);
            formsPage.InputLastName(inputLastName);
            formsPage.InputGender();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            formsPage.InputNumber(inputNumber);
            formsPage.InputHobby();
            System.Threading.Thread.Sleep(1500);
            js.ExecuteScript("window.scrollBy(0,800);");
            formsPage.SelectStateAndCity();
            formsPage.ClickSubmit();
            //Assert
            formsPage.AssertFormsPageIsDisplayed();
            formsPage.AssertIsFullNameIsCorrect(inputFirstName, inputLastName);
            driver.Dispose();
            //Wait untill selenium
        }

    }

}

