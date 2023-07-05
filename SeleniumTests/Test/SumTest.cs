using NUnit.Framework;
using NUnit.Framework.Internal;
using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    public class SumTest : BaseTest
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


        [Test,Category("MathTest"),Description("sum random test")]
        public void SummRandomTest()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Add(random.NextInt64(0, 2), 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Retry(10)]
        [Category("MathTest")]
        [Description("Sum range test")]
        public void SumTestRange(
            [Values(2, 4)] double operand1,
            [Range(0, 4)] double operand2)
        {
            var expected = 6;
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 2, 2)]
        [TestCase(4, -1, 4)]
        [TestCase(4, 4, 0)]
        [Category("MathTest")]
        [Description("Sum negative test")]
        public void SumNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(8, 2, ExpectedResult = 4)]
        [TestCase(3, 1, ExpectedResult = 4)]
        [TestCase(20, 5, ExpectedResult = 4)]
        [Category("MathTest")]
        [Description("Sum return test")]
        public double SumNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Add(operand1, operand2);
        }
    }
}
