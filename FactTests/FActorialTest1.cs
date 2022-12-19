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
        public void FactorialTest0()
        {
            Assert.AreEqual(MyFactorial.Factorial(0), 1); ;
        }
       
        public void FactorialTest1()
        {
            Assert.AreEqual(MyFactorial.Factorial(1), 1); ;
        }
       
        public void FactorialTest2()
        {
            Assert.AreEqual(MyFactorial.Factorial(2), 2); ;
        }
        public void FactorialTest3()
        {
            Assert.AreEqual(MyFactorial.Factorial(3), 6); ;
        }
       
        public void FactorialTest4()
        {
            Assert.AreEqual(MyFactorial.Factorial(4), 24); ;
        }
       
        public void FactorialTest5()
        {
            Assert.AreEqual(MyFactorial.Factorial(5), 120); ;
        }
       
        public void FactorialTest6()
        {
            Assert.AreEqual(MyFactorial.Factorial(6), 720);
        }
    }
}