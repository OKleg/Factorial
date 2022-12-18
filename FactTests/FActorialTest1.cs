using NUnit.Framework;
using FactorialNS;
namespace FactTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass("5! = 120",MyFactorial.Factorial(5), 120);
            Assert.AreEqual(MyFactorial.Factorial(5),120);
        }
    }
}