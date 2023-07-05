using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_12.Test
{
    internal class Typos : BaseTest
    {
        [Test]
        public void TyposTest()
        {
            {
                driver.FindElement(By.LinkText("Typos")).Click();

                // Получение текста элемента
                IWebElement element = driver.FindElement(By.ClassName("example"));
                string actualText = element.Text;

                string expectedText = "Typos\r\nThis example demonstrates a typo being introduced. It does it randomly on each page load.\r\nSometimes you'll see a typo, other times you won't.";


                // Проверка наличия ожидаемого текста с использованием Assert.Contains
                if (actualText.Equals(expectedText))
                {
                    Console.WriteLine("Ожидаемый текст совпадает с фактическим");
                }
                else
                {
                    Console.WriteLine("Ожидаемый текст НЕ совпадает с фактическим");
                }
                
                
                 // Assert.AreEqual(actualText, expectedText, $"Текст '{actualText}' соответсвует ожидаемому");



            }


        }
    }
}
