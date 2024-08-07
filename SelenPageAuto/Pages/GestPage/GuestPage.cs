using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenPageAuto.Pages.GestPage
{
    public class GuestPage
    {
        private readonly IWebDriver driver;

        public GuestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement MasagePostCreatSuccessfully => driver.FindElement(By.XPath("//div[@class='notice -success -post-view']"));
    }
}
