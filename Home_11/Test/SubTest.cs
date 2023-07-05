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
    public class SubTest : BaseTest
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


        [Test, Category("MathTest"), Description("subtraction random test")]
        public void SubRandomTest()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Sub(random.NextInt64(4, 6), 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Retry(10)]
        [Category("MathTest")]
        [Description("subtraction range test")]
        public void SubTestRange(
            [Values(8, 4)] double operand1,
            [Range(0, 4)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Sub(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 6, 2)]
        [TestCase(4, -1, 4)]
        [TestCase(4, 4, 0)]
        [Category("MathTest")]
        [Description("subtraction negative test")]
        public void SubNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            var actual = calculator.Sub(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(6, 2, ExpectedResult = 4)]
        [TestCase(3, 1, ExpectedResult = 4)]
        [TestCase(20, 16, ExpectedResult = 4)]
        [Category("MathTest")]
        [Description("subtraction return test")]
        public double SubNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Sub(operand1, operand2);
        }
    }
    }