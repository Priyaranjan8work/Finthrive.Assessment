namespace Finthrive.Assessment.ForTesting
{
    /// <summary>
    /// Get Factorial of a number.
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// Calculates factorial to the nth position.
        /// if n == 0, n! = 1
        /// if n > 0, n! = (n - 1)! * n
        /// ie. 1, 1, 2, 6, 24, 120, 720, 5040...
        /// </summary>
        /// <param name="nthPosition">The nth position to calculate.</param>
        /// <returns>The cacluated nth Factorial.</returns>
        public static long NthFactorialStartingZero(int nthPosition)
        {
            int factorialValue = 1;
            for (int i = 1; i <= nthPosition; i++)
            {
                factorialValue = factorialValue * i;
                if (nthPosition == i + 1)  //Assumed we need nth position 1, 1, 2, 6, 24, 120, 720, 5040.... Second implementation is below. This logic not required.
                {
                    return factorialValue;
                }
            }
            return factorialValue;
        }

        // <summary>
        /// Calculates factorial of the number.
        /// if n == 0, n! = 1
        /// if n > 0, n! = (n - 1)! * n
        /// ie. 1, 1, 2, 6, 24, 120, 720, 5040...
        /// </summary>
        /// <param name="number">Number for which factorial need to be calculated.</param>
        /// <returns>The cacluated Factorial for the number.</returns>
        public static long FactorialOfANumber(int number)
        {
            int factorialValue = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialValue = factorialValue * i;
            }
            return factorialValue;
        }
    }
}
