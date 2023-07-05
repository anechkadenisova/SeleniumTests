using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Home_12.Test
{
    public class BaseTest
    {
        protected WebDriver driver;
        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        [Test]


        [TearDown]
        public void TearDown()
        {
              driver.Quit();
        }
    }
}