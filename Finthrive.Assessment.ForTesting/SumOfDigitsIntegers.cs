namespace Finthrive.Assessment.ForTesting
{
    /// <summary>
    /// Sum of digits in a integers.
    /// </summary>
    public class SumOfDigitsIntegers
    {
        /// <summary>
        /// Gets the sum of digits for the specified integer.
        /// ie. 1010 returns 2, 1024 returns 7, 200000 returns 2, etc.
        /// </summary>
        /// <param name="n">The integer to sum.</param>
        /// <returns>A sum of the digits in the specified integer.</returns>
        public static int GetSumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
