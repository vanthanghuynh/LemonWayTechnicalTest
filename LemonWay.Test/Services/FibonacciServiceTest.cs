using LemonWay.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.Test.Services
{
    [TestClass]
    public class FibonacciServiceTest
    {
        private FibonacciService _fibonacciService;

        [TestInitialize]
        public void SetUp()
        {
            _fibonacciService = new FibonacciService();
        }

        [TestMethod]
        public void should_return_fibonacci_number()
        {
            int number = 6;
            int expected = 8;

            int actual = _fibonacciService.ComputeFibonacci(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_return_negative_1_when_number_is_less_than_1()
        {
            int number = -10;
            int expected = -1;

            int actual = _fibonacciService.ComputeFibonacci(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_return_negative_1_when_number_is_greater_than_100()
        {
            int number = 101;
            int expected = -1;

            int actual = _fibonacciService.ComputeFibonacci(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
