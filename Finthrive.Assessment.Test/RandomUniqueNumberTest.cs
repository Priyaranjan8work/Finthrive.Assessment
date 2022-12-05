namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Testing random unique number generator.
    /// </summary>
    [TestClass]
    public class RandomUniqueNumberTest
    {
        /// <summary>
        /// List of numbers.
        /// </summary>
        static IEnumerable<int> getList = new List<int>();

        /// <summary>
        /// Get the randomized list
        /// </summary>
        /// <param name="context">Test context information</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            getList = RandomUniqueNumber.GetDistinctRandomNumbers();
        }

        /// <summary>
        /// Validate there are million unique numbers.
        /// </summary>
        [TestMethod]
        public void ValidateAllTheNumbersInTheListIsUnique()
        {
            getList.Should().NotBeNull();
            getList.Distinct().Count().Should().Be(1000000);
        }

        /// <summary>
        /// Verify the list is random.
        /// </summary>
        [TestMethod]
        public void ValidateTheNumbersAreRandomlyOrdered()
        {
            List<int> millionNumbers = Enumerable.Range(1, 1000000).ToList();
            getList.Should().NotBeNull();
            Enumerable.SequenceEqual(millionNumbers, getList).Should().BeFalse();
        }
    }
}
