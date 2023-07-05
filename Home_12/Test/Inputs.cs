using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Xml.Linq;


namespace Home_12.Test
{
    internal class Inputs : BaseTest
    {
        [Test]
        public void  EnterNumbers()
        {
            driver.FindElement(By.LinkText("Inputs")).Click();

            var input = driver.FindElement(By.TagName("input"));

            input.SendKeys("100.33");
            input.Clear();

            input.SendKeys("48trvve55464");
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

            input.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
        }
    }
}
