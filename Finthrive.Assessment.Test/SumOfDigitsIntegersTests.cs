namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Verify sum of digits in a number.
    /// </summary>
    [TestClass]
    public class SumOfDigitsIntegersTests
    {
        /// <summary>
        /// Verify sum of digits is euivalent to each digit.
        /// </summary>
        [TestMethod]
        public void SumOfDigitsIntegersTest()
        {
            int input = 1234;
            int expectedOutput = 10;
            int result = SumOfDigitsIntegers.GetSumOfDigits(input);
            result.Should().Be(expectedOutput);
        }

        /// <summary>
        /// Verify sum is zero when inout number is zero.
        /// </summary>
        [TestMethod]
        public void SumOfDigitsIntegersWhenInputIsZero()
        {
            int input = 0;
            int expectedOutput = 0;
            int result = SumOfDigitsIntegers.GetSumOfDigits(input);
            result.Should().Be(expectedOutput);
        }

        /// <summary>
        /// Verify sum is equal to the number when it is single digit.
        /// </summary>
        [TestMethod]
        public void SumOfDigitsIntegersWhenInputIsOneDigit()
        {
            int input = 9;
            int expectedOutput = 9;
            int result = SumOfDigitsIntegers.GetSumOfDigits(input);
            result.Should().Be(expectedOutput);
        }
    }
}
