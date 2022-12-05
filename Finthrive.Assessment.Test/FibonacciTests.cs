namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Fetch fibonacci series numbers.
    /// </summary>
    [TestClass]
    public class FibonacciTests
    {
        /// <summary>
        /// Verify first fibonacci number is 1.
        /// </summary>
        [TestMethod]
        public void VerifyFirstFibonacciNumber()
        {
            int nthPosition = 0;
            Fibonacci.GetNthFibonacciNumber(nthPosition).Should().Be(0);
        }

        /// <summary>
        /// Verify second fibonacci number is 1.
        /// </summary>
        [TestMethod]
        public void VerifySecondFibonacciNumber()
        {
            int nthPosition = 1;
            Fibonacci.GetNthFibonacciNumber(nthPosition).Should().Be(1);
        }

        /// <summary>
        /// Verify third fibonacci number is 2.
        /// </summary>
        [TestMethod]
        public void VerifyThirdFibonacciNumber()
        {
            int nthPosition = 2;
            Fibonacci.GetNthFibonacciNumber(nthPosition).Should().Be(1);
        }

        /// <summary>
        /// Verify 10th fibonacci number is 55.
        /// </summary>
        [TestMethod]
        public void VerifyTenthFibonacciNumber()
        {
            int nthPosition = 10;
            Fibonacci.GetNthFibonacciNumber(nthPosition).Should().Be(55);
        }
    }
}
