namespace Finthrive.Assessment.ForTesting
{
    /// <summary>
    /// Get fibonacci numbers.
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// Calculates Fibonaccis to the nth position.
        /// F(n) = F(n - 1) + F(n - 2)
        /// ie. 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...
        /// </summary>
        /// <param name="n">The nth position to calculate.</param>
        /// <returns>The calculated nth Fibonacci</returns>
        public static long GetNthFibonacciNumber(int n)
        {
            long firstNumber = 0;
            long SecondNumber = 1;
            long nthNumber = 0;
            if (n == 0)
            {
                nthNumber = firstNumber;
                return nthNumber;
            }
            for (int i = 2; i <= n; i++)
            {
                nthNumber = firstNumber + SecondNumber;
                firstNumber = SecondNumber;
                SecondNumber = nthNumber;
            }
            return SecondNumber;
        }
    }
}
