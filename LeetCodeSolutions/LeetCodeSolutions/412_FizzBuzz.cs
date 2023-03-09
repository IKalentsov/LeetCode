using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    /// <summary>
    /// Given an integer n, return a string array answer 
    /// (1-indexed) where:

    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i(as a string) if none of the above conditions
    /// are true.
    /// </summary>
    public class FizzBuzz
    {
        private const string fizzBuzz = "FizzBuzz";
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        public static IList<string> FizzBuzzSolution(int n)
        {
            var result = new List<string>();

            for(var i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) result.Add(fizzBuzz);

                else if (i % 3 == 0) result.Add(fizz);

                else if (i % 5 == 0) result.Add(buzz);

                else result.Add(i.ToString());
            }

            return result;
        }
    }
}
