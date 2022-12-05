namespace Finthrive.Assessment.Test
{
    using Finthrive.Assessment.ForTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test different operations on the list.
    /// </summary>
    [TestClass]
    public class OperationsOnListTests
    {
        /// <summary>
        /// Verify the common numbers from list gets returned and are distinct.
        /// </summary>
        [TestMethod]
        public void VerifyCommonNumbersInList1And2ArereturnedWhenDistinct()
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };
            int[] list2 = new int[] { 4, 9, 2, 3, 10, 5, 6, 9, 3, 5, 0 };
            var expectedOutput = new int[] { 4, 9, 2, 3, 5, 6 };
            var output = OperationsOnList.GetCommonNumbersInList1And2(list1, list2);
            output.Should().NotBeNullOrEmpty();
            output.Should().Contain(expectedOutput);
            Enumerable.SequenceEqual(expectedOutput, output).Should().BeTrue();
        }

        /// <summary>
        /// Verify no item returned for no common items.
        /// </summary>
        [TestMethod]
        public void VerifyNoItemReturnedWhenThereIsNoItemCommon()
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
            int[] list2 = new int[] { 0, 0, 9};
            var expectedOutput = new int[] { };
            var output = OperationsOnList.GetCommonNumbersInList1And2(list1, list2);
            output.Should().BeEmpty();
            Enumerable.SequenceEqual(expectedOutput, output).Should().BeTrue();
        }

        /// <summary>
        /// Verify first ocuurrence of 10 is returned.
        /// </summary>
        [TestMethod]
        public void VerifyFirstOcurrenceOf10ReturnedfromTheList()
        {
            int[] list1 = new int[] { 1, 10, 3, 4, 5, 6, 7, 10 };
            int value = OperationsOnList.GetFirstOccuranceOf10InList2(list1);
            value.Should().Be(10);
        }

        /// <summary>
        /// Verify first ocuurrence of 10 is returned when there is only one ocurrence.
        /// </summary>
        [TestMethod]
        public void VerifyOnlyOcurrenceOf10ReturnedfromTheList()
        {
            int[] list1 = new int[] { 1, 10, 3, 4, 5, 6, 7};
            int value = OperationsOnList.GetFirstOccuranceOf10InList2(list1);
            value.Should().Be(10);
        }

        /// <summary>
        /// Verify first ocuurrence of 10 is returned when there is only one ocurrence.
        /// </summary>
        [TestMethod]
        public void VerifyZeroReturnedWhenThereNoTenInTheList()
        {
            int[] list1 = new int[] { 1, 3, 4, 5, 6, 7 };
            int value = OperationsOnList.GetFirstOccuranceOf10InList2(list1);
            value.Should().Be(0);
        }

        /// <summary>
        /// Verify first ocuurrence of 2 is returned
        /// When there is only one 2.
        /// </summary>
        [TestMethod]
        public void VerifyTheOnlyOcurrenceOf2ReturnedfromTheList()
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 10 };
            int value = OperationsOnList.GetSingleOccuranceOf2InList2(list1);
            value.Should().Be(2);
        }

        /// <summary>
        /// Verify exception is thrown when there is more than one ocurrence of 2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void VerifyExceptionWhenMoreThanOneOcurrenceOf2ReturnedfromTheList()
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 2, 10 };
            OperationsOnList.GetSingleOccuranceOf2InList2(list1);
        }

        /// <summary>
        /// Verify exception is thrown when there is no ocurrence of 2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void VerifyExceptionWhenNoOcurrenceOf2ReturnedfromTheList()
        {
            int[] list1 = new int[] { 1, 3, 4, 5, 6, 8, 10 };
            OperationsOnList.GetSingleOccuranceOf2InList2(list1);
        }
    }
}
