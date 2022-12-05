namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test FizzBuzz logic.
    /// </summary>
    [TestClass]
    public class FizzBuzzTesting
    {
        /// <summary>
        /// List of string.
        /// </summary>
        static List<string> getList = new List<string>();

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            getList = SubstitutionWithFizzBuzz.GetFizzBuzzList();
        }
        /// <summary>
        /// Verify the list contains 100 values.
        /// </summary>
        [TestMethod]
        public void ListShouldReturnHundredItems()
        {
            getList.Should().NotBeNull();
            getList.Count().Should().Be(100);
        }

        /// <summary>
        /// Verify the list contains Fizz as third item
        /// And Buzz as fifth item
        /// And FizzBuzz as fifteenth item.
        /// </summary>
        [TestMethod]
        public void ListShouldHaveCorrectItemAtThirdFifthAndFifteenthPlace()
        {
            getList[2].Should().Be("Fizz");
            getList[4].Should().Be("Buzz");
            getList[14].Should().Be("FizzBuzz");
        }

        /// <summary>
        /// Verify the list contains number at non multiplier of three
        /// And Five.
        /// </summary>
        [TestMethod]
        public void ListShouldHaveNumberAtNonMultiplierOfThreeAndFive()
        {
            getList[0].Should().Be("1");
            getList[1].Should().Be("2");
            getList[3].Should().Be("4");
        }
    }
}