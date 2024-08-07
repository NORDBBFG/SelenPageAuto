using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenPageAuto.Pages;

namespace SelenPageAuto
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-fullscreen");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            //Arrange
            string code;
            string expirationOption;
            string pasteNameTitle;

            //Act

            code = "Hello from WebDriver";
            expirationOption = "10 Minutes";
            pasteNameTitle = "helloweb";

            //Assert
            driver.Navigate().GoToUrl("https://pastebin.com/");
            var newPastaCOntext = new NewPastePageContext(driver);
            Thread.Sleep(3000);
            newPastaCOntext
                .EnterTextIntoTestField(code)
                .SelectExpirationOptionByText(expirationOption)
                .EnterTextIntoPasteNameTitleInput(pasteNameTitle)
                .ClickButtonCreateNewPaste()
                .VerifyMasagePostCreatSuccessfullyApears();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}