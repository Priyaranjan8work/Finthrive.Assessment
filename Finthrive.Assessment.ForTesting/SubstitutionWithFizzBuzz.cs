namespace Finthrive.Assessment.ForTesting
{
    /// <summary>
    /// Printing numbers and Fizz,Buzz and FizzBuzz as per rule.
    /// </summary>
    public static class SubstitutionWithFizzBuzz
    {
        /// <summary>
        /// Print the number from 1 to 100
        /// But for multiples of three print "Fizz" instead of the number
        /// And for multiples of five print "Buzz" instead of the number
        /// And for multiples of both five and three print "FizzBuzz" instead of the number.
        /// </summary>
        /// <returns>List of strings</returns>
        public static List<string> GetFizzBuzzList()
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                list.Add(GetSubstitutedValueFromNumber(i));
            }
            return list;
        }

        /// <summary>
        /// Get Fizz when the input number is a multiple of 3
        /// And Buzz when the input number is a multiple of 5
        /// And FizzBuzz when the input number is multiple of both 3 and 5
        /// </summary>
        /// <param name="number">The integer number which need to be substituted if condition meets</param>
        /// <returns>Output string as per the multiplier rule</returns>
        private static string GetSubstitutedValueFromNumber(int number)
        {
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizzBuzz = "FizzBuzz";

            if (number > 1)
            {
                if (number % 15 == 0)
                {
                    return fizzBuzz;
                }
                if (number % 3 == 0)
                {
                    return fizz;
                }
                if (number % 5 == 0)
                {
                    return buzz;
                }
            }
            return number.ToString();
        }
    }
}