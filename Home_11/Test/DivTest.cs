using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    public class DivTest : BaseTest
    {
        [OneTimeSetUp, OneTimeTearDown]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();
        }
        public void OneTimeTearDown()
        {
            calculator = new Calculator();
        }
        Calculator calculator;


        [Test, Category("MathTest"), Description("division random test")]
        public void DivRandomTest()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Div(random.NextInt64(4, 8), 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Retry(10)]
        [Category("MathTest")]
        [Description("division range test")]
        public void DivTestRange(
            [Values(8, 4)] double operand1,
            [Range(0, 4)] double operand2)
        {
            var expected = 2;
            var actual = calculator.Div(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 8, 2)]
        [TestCase(4, -1, 4)]
        [TestCase(4, 4, 0)]
        [Category("MathTest")]
        [Description("division negative test")]
        public void DivNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            var actual = calculator.Div(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(8, 2, ExpectedResult = 4)]
        [TestCase(3, 1, ExpectedResult = 4)]
        [TestCase(20, 5, ExpectedResult = 4)]
        [Category("MathTest")]
        [Description("division return test")]
        public double DivNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Div(operand1, operand2);
        }
    }
}
