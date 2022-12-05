using System.Diagnostics;

namespace Finthrive.Assessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz:");
            CodingTestMethods.FizzBuzz();
            Console.WriteLine("GetDistinctRandom:");
            CodingTestMethods.GetDistinctRandomNumbers();
            Console.WriteLine("GetCommonNumbersInList1And2:");
            var newList = CodingTestMethods.GetCommonNumbersInList1And2();
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("OutputFirstOccuranceOf10InList2:");
            Console.WriteLine(CodingTestMethods.GetFirstOccuranceOf10InList2());
            Console.WriteLine("GetSingleOccuranceOf2InList2:");
            Console.WriteLine(CodingTestMethods.GetSingleOccuranceOf2InList2());
            Console.WriteLine("Sum of Digits:");
            Console.WriteLine("Output for some of digits for 1234 :" + CodingTestMethods.GetSumOfDigits(1234));
            Console.WriteLine("Factorial:");
            Console.WriteLine("Fcatorial of 5:" + CodingTestMethods.FactorialOfANumber(5));
            Console.WriteLine("Factorial value of 5th starting factorial 0(nth position 1, 1, 2, 6, 24, 120, 720, 5040.):" + CodingTestMethods.Factorial(5));
            Console.WriteLine("Fibonacci:");
            Console.WriteLine("The 7th Fibonacci number would be:" + CodingTestMethods.Fibonacci(7));
            Console.ReadLine();
        }
    }

    /// <summary>
    /// All the implementation for the different programs.
    /// </summary>
    public static class CodingTestMethods
    {
        /// <summary>
        /// Readonly instance of random class.
        /// </summary>
        private static readonly Random rand = new Random();

        /// <summary>
        /// Print the number from 1 to 100
        /// But for multiples of three print "Fizz" instead of the number
        /// And for multiples of five print "Buzz" instead of the number
        /// And for multiples of both five and three print "FizzBuzz" instead of the number.
        /// </summary>
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetSubstitutedValueFromNumber(i));
            }
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
            string timeToRun= "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine("Time to run:" + timeToRun);
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

        /// <summary>
        /// Input List first.
        /// </summary>
        private static int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary>
        /// Input List Second.
        /// </summary>
        private static int[] list2 = new int[] { 4, 9, 2, 3, 10, 5, 6, 9, 2, 3, 5, 2, 0 };

        /// <summary>
        /// Returns the distinct, common numbers in list1 and list2.
        /// </summary>
        public static IEnumerable<int> GetCommonNumbersInList1And2()
        {
            return list2.Where(a => list1.Any(b => a == b)).Distinct();
        }

        // <summary>
        /// Get the first ocurrence of 10 in the input list.
        /// </summary>
        /// <returns>Ocurrence of 10.</returns>
        public static int GetFirstOccuranceOf10InList2()
        {
            return list2.FirstOrDefault(n => n == 10);
        }

        /// <summary>
        /// Get the single ocurrence of 2 in list
        /// And throw exception when more than exists
        /// </summary>
        /// <returns>returns the ocurrence</returns>
        public static int GetSingleOccuranceOf2InList2()
        {
            try
            {
                return list2.Single(n => n == 2); //exception thrown as list2 have more than one 2.
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

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

        /// <summary>
        /// Calculates factorial to the nth position.
        /// if n == 0, n! = 1
        /// if n > 0, n! = (n - 1)! * n
        /// ie. 1, 1, 2, 6, 24, 120, 720, 5040...
        /// </summary>
        /// <param name="nthPosition">The nth position to calculate.</param>
        /// <returns>The cacluated nth Factorial.</returns>
        public static long Factorial(int nthPosition)
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

        /// <summary>
        /// Calculates Fibonaccis to the nth position.
        /// F(n) = F(n - 1) + F(n - 2)
        /// ie. 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...
        /// </summary>
        /// <param name="n">The nth position to calculate.</param>
        /// <returns>The calculated nth Fibonacci</returns>
        public static long Fibonacci(int n)
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