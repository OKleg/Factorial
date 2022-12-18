using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialNS;
namespace FactorTests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void FactorialTest00()
        {
            Assert.AreEqual(MyFactorial.Factorial(0), 1); ;
        }
        [TestMethod]
        public void FactorialTest01()
        {
            Assert.AreEqual(MyFactorial.Factorial(1), 1); ;
        }
        [TestMethod]
        public void FactorialTest02()
        {
            Assert.AreEqual(MyFactorial.Factorial(2), 2); ;
        }
        [TestMethod]
        public void FactorialTest03()
        {
            Assert.AreEqual(MyFactorial.Factorial(3), 6); ;
        }
        [TestMethod]
        public void FactorialTest04()
        {
            Assert.AreEqual(MyFactorial.Factorial(4), 24); ;
        }
        [TestMethod]
        public void FactorialTest05()
        {
            Assert.AreEqual(MyFactorial.Factorial(5), 120); ;
        }
        [TestMethod]
        public void FactorialTest06()
        {
            Assert.AreEqual(MyFactorial.Factorial(6), 720) ;
        }
    }
}
