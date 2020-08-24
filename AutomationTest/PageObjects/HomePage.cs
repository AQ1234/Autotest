
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.PageObjects
{
   public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
          //  PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.XPath, Using = "//div[@class='category-cards']//div[1]//div[1]//div[2]")]
        public IWebElement elements { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='category-cards']//div[1]//div[1]//div[2]")]
        public IWebElement forms { get; set; }

        public FormsPage GoToFormsPage()
        {
            elements.Click();
            return new FormsPage(_driver);
        }

        public ElementsPage GoToElementsPage()
        {
            forms.Click();
            return new ElementsPage(_driver);
        }
    }
}
