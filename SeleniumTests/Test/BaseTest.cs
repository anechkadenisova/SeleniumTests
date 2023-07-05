using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    public class BaseTest
    {


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("- OneTimeSetUp");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("---- SetUp");
        }

        [TearDown]

        public void TearDown()
        {
            Console.WriteLine("---- TearDown");
        }

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {
            Console.WriteLine("-- OneTimeTearDown");
        }
    }
}
