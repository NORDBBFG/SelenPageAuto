using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenPageAuto.Pages.GestPage
{
    internal class GuestPageContext : TestStepContext
    {
        private readonly IWebDriver driver;
        private GuestPage newGuestPage;

        public GuestPageContext(IWebDriver driver)
        {
            this.driver = driver;
            this.newGuestPage = new GuestPage(driver);
        }

        public GuestPageContext VerifyMasagePostCreatSuccessfullyApears()
        {
            Thread.Sleep(1000);
            bool actual = newGuestPage.MasagePostCreatSuccessfully.Enabled;
            Assert.IsTrue(actual);
            return this;
        }
    }
}
