using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    public class MultiplyTest : BaseTest
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


        [Test, Category("MathTest"), Description("Multiply random test")]
        public void MultiplyRandomTest()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Multiply(random.NextInt64(0, 4), 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Retry(10)]
        [Category("MathTest")]
        [Description("Multiply range test")]
        public void MultiplyTestRange(
            [Values(2, 4)] double operand1,
            [Range(0, 4)] double operand2)
        {
            var expected = 16;
            var actual = calculator.Multiply(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 2, 2)]
        [TestCase(4, -1, 4)]
        [TestCase(0, 4, 0)]
        [Category("MathTest")]
        [Description("Multiply negative test")]
        public void MultiplyNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            var actual = calculator.Multiply(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(3, 1, ExpectedResult = 4)]
        [TestCase(20, 5, ExpectedResult = 4)]
        [Category("MathTest")]
        [Description("Multiply return test")]
        public double DivNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Multiply(operand1, operand2);
        }
    }
}
