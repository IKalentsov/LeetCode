namespace LeetCodeSolutions
{
    /// <summary>
    /// 1342. Number of Steps to Reduce a Number to Zero
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/
    /// 
    /// Description
    /// Given an integer num, return the number of steps to reduce it to zero.
    /// In one step, if the current number is even, you have to divide it by 2,
    /// otherwise, you have to subtract 1 from it.
    /// </summary>
    public class NumberOfStepsToReduceANumberToZero
    {
        public static int steps = 0;

        public static int NumberOfSteps(int num)
        {
            steps = 0;

            CalculateSteps(num);

            return steps;
        }

        private static int CalculateSteps(int num)
        {
            if (num == 0) return steps;

            steps++;

            if (num % 2 == 0)
            {
                num /= 2;

                return CalculateSteps(num);
            }
            else
            {
                num -= 1;
                return CalculateSteps(num);
            }
        }
    }
}
