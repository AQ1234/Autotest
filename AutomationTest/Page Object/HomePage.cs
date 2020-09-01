using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            //  PageFactory.InitElements(driver, this);

        }
        // nie używamy absolute path!!!
        [FindsBy(How = How.XPath, Using = "//div[@class='category-cards']//div[1]//div[1]//div[2]")]
        // nazwa do poprawy
        private IWebElement elements;

        [FindsBy(How = How.XPath, Using = "//div[@class='category-cards']//div[1]//div[1]//div[2]")]
        private IWebElement forms;

        public FormsPage GoToFormsPage()
        {
            forms.Click();
            return PageFactory.InitElements<FormsPage>(_driver);

        }

        public ElementsPage GoToElementsPage()
        {
            elements.Click();
            return PageFactory.InitElements<ElementsPage>(_driver);
        }
    }
}
