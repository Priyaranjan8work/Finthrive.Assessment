namespace Finthrive.Assessment.ForTesting
{
    /// <summary>
    /// Perform different operations on the list.
    /// </summary>
    public  class OperationsOnList
    {
        /// <summary>
        /// Returns the distinct, common numbers in list1 and list2.
        /// </summary>
        /// <param name="list1">Input list 1</param>
        /// <param name="list2">Input list 2</param>
        /// <returns>New list</returns>
        public static IEnumerable<int> GetCommonNumbersInList1And2(int[] list1, int[] list2)
        {
            return list2.Where(a => list1.Any(b => a == b)).Distinct();
        }

        // <summary>
        /// Get the first ocurrence of 10 in the input list.
        /// </summary>
        /// <param name="list2">Input list.</param>
        /// <returns>Ocurrence of 10.</returns>
        public static int GetFirstOccuranceOf10InList2(int[] list2)
        {
            return list2.FirstOrDefault(n => n == 10);
        }

        /// <summary>
        /// Get the single ocurrence of 2 in list
        /// And throw exception when more than exists
        /// </summary>
        /// <returns>returns the ocurrence</returns>
        public static int GetSingleOccuranceOf2InList2(int[] list2)
        {
            return list2.Single(n => n == 2);
        }
    }
}
