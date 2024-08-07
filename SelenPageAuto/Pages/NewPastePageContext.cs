using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.FedCm;
using SelenPageAuto.Pages.GestPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenPageAuto.Pages
{
    internal class NewPastePageContext : TestStepContext
    {
        private readonly IWebDriver driver;
        private NewPastePage newPastePage;

        public NewPastePageContext(IWebDriver driver)
        {
            this.driver = driver;
            this.newPastePage = new NewPastePage(driver);
        }

        public NewPastePageContext EnterTextIntoTestField(string text)
        {
            newPastePage.TestFieldNewPatste.SendKeys(text);
            return this;
        }
        public NewPastePageContext SelectExpirationOptionByText(string optionText)
        {
            newPastePage.DropDownMenuPasteExpiration.Click();
            newPastePage.DropDownMenuPasteExpirationElementByText(optionText).Click();
            return this;
        }

        public NewPastePageContext EnterTextIntoPasteNameTitleInput(string text)
        {
            newPastePage.PasteNameTitleInput.SendKeys(text);
            return this;
        }

        public GuestPageContext ClickButtonCreateNewPaste()
        {
            newPastePage.ButtonCreateNewPaste.Click();
            return new GuestPageContext(driver);
        }
    }
}
