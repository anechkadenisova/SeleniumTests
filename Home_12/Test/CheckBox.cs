using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_12.Test
{
    internal class CheckBox : BaseTest
    {
        [Test]
        public void CheckBoxTest()
        {
            driver.FindElement(By.LinkText("Checkboxes")).Click();

            List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);


            var checkBoxOne = checkBoxes[0];
            var checkBoxTwo = checkBoxes[1];


            //checkbox1
            var selected = checkBoxOne.Selected;
            var selectedByAttribute = checkBoxOne.GetAttribute("checked");

            Assert.IsNull(selectedByAttribute);

            checkBoxOne.Click();
            selectedByAttribute = checkBoxOne.GetAttribute("checked");
            Assert.IsTrue(true, selectedByAttribute);

            //checkbox2
            selected = checkBoxTwo.Selected;
            selectedByAttribute = checkBoxTwo.GetAttribute("checked");

            Assert.IsTrue(true, selectedByAttribute);

            checkBoxTwo.Click();

            selectedByAttribute = checkBoxTwo.GetAttribute("checked");
            Assert.IsNull(selectedByAttribute);


        }/*
        SetBoxState(checkBoxOne, false);
        SetBoxState(checkBoxOne, true);
        SetBoxState(checkBoxOne, true);
        SetBoxState(checkBoxOne, false);
        public void SetBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
           bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }*/

    }
}
