namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Verify factorial of numbers and their position.
    /// </summary>
    [TestClass]
    public class FactorialTests
    {
        /// <summary>
        /// Verify factorial of zero is 1.
        /// </summary>
        [TestMethod]
        public void VerifyFactorialOfZero()
        {
            int number = 0;
            Factorial.FactorialOfANumber(number).Should().Be(1);
        }

        /// <summary>
        /// Verify factorial of one is 1.
        /// </summary>
        [TestMethod]
        public void VerifyFactorialOf1()
        {
            int number = 1;
            Factorial.FactorialOfANumber(number).Should().Be(1);
        }

        /// <summary>
        /// verify factorial of 5 is 120.
        /// </summary>
        [TestMethod]
        public void VerifyFactorialOf5()
        {
            int number = 5;
            Factorial.FactorialOfANumber(number).Should().Be(120);
        }

        /// <summary>
        /// Verify first factorial of first zero is 1.
        /// </summary>
        [TestMethod]
        public void Verify1stFactorialStartingZero()
        {
            int number = 0;
            Factorial.NthFactorialStartingZero(number).Should().Be(1);
        }

        /// <summary>
        /// Verify second factorial of first 1 is 1.
        /// </summary>
        [TestMethod]
        public void Verify2ndFactorialStartingZero()
        {
            int number = 1;
            Factorial.NthFactorialStartingZero(number).Should().Be(1);
        }

        /// <summary>
        /// Verify fcatorial 4 which is 5th in order is 24.
        /// </summary>
        [TestMethod]
        public void Verif5thFactorialStartingZero()
        {
            int number = 5;
            Factorial.NthFactorialStartingZero(number).Should().Be(24);
        }
    }
}
