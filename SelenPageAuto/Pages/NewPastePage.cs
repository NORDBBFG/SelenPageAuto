using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenPageAuto.Pages
{
    public class NewPastePage
    {
        private readonly IWebDriver driver;

        public NewPastePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement TestFieldNewPatste => driver.FindElement(By.Id("postform-text"));
        public IWebElement DropDownMenuPasteExpiration => driver.FindElement(By.Id("select2-postform-expiration-container"));
        public IWebElement DropDownMenuPasteExpirationElementByText(string value) => driver.FindElement(By.XPath($"//li[@class = 'select2-results__option' and text()='{value}']"));
        public IWebElement PasteNameTitleInput => driver.FindElement(By.XPath("//input[@id = 'postform-name']"));
        public IWebElement ButtonCreateNewPaste => driver.FindElement(By.XPath("//button[@class='btn -big']"));
    }
}
