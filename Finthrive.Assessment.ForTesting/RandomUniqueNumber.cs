namespace Finthrive.Assessment.ForTesting
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Random number generator.
    /// </summary>
    public class RandomUniqueNumber
    {
        /// <summary>
        /// Readonly instance of random class.
        /// </summary>
        private static readonly Random rand = new Random();

        /// <summary>
        /// Get a list of unique random numbers between 1-1,000,000
        /// And method should be performant to complete in less than a second.
        /// </summary>
        /// <returns>List of randomized numbers with no duplicates.</returns>
        public static IEnumerable<int> GetDistinctRandomNumbers()
        {
            var timer = new Stopwatch();
            timer.Start();
            List<int> millionNumbers = Enumerable.Range(1, 1000000).ToList();
            millionNumbers = (List<int>)GetRandomisedList(millionNumbers);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine(foo);
            return millionNumbers;
        }

        /// <summary>
        /// Randomize the input list.
        /// </summary>
        /// <param name="inputList">Input list.</param>
        /// <returns>Randomize list.</returns>
        private static IEnumerable<int> GetRandomisedList(List<int> inputList)
        {
            for (int i = inputList.Count - 1; i > 0; i--)
            {
                int indexToSwap = rand.Next(i + 1);
                (inputList[indexToSwap], inputList[i]) = (inputList[i], inputList[indexToSwap]);
            }
            return inputList;
        }
    }
}
