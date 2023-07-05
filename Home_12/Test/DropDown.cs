using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_12.Test
{
    internal class DropDown : BaseTest
    {
        [Test]
        public void SelectDropDown()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            List<IWebElement> dropdownList = driver.FindElements(By.TagName("option")).ToList();
            int dropdownCount = driver.FindElements(By.TagName("option")).Count;
            Assert.IsNotEmpty(dropdownList);

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            var dropdownOne = dropdownList[1];
            var dropdownTwo = dropdownList[2];

            select.SelectByIndex(1);

            var selectedByValue = dropdownOne.GetAttribute("selected");
            Assert.IsTrue(true, selectedByValue);

            select.SelectByIndex(2);

            selectedByValue = dropdownTwo.GetAttribute("selected");
            Assert.IsTrue(true, selectedByValue);

        }
    }
}
