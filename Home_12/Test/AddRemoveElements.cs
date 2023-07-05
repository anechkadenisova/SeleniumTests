using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace Home_12.Test
{
    internal class AddRemoveElements : BaseTest
    {
   
        [Test]

        public void OpenWindow()
        {

            var expectedUrl = "https://the-internet.herokuapp.com/add_remove_elements/";

            var element = driver.FindElement(By.LinkText("Add/Remove Elements"));
            element.Click();
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            driver.FindElement(By.TagName("button")).Click();
            driver.FindElement(By.TagName("button")).Click();
            var addedButton = driver.FindElement(By.ClassName("added-manually"));
            Assert.IsNotNull(addedButton);
            
            addedButton.Click();
            Assert.IsNotEmpty(driver.FindElements(By.ClassName("added-manually")));

            int addedButtonCount = driver.FindElements(By.ClassName("added-manually")).Count;
            Console.WriteLine(addedButtonCount);
        }

    }
}
