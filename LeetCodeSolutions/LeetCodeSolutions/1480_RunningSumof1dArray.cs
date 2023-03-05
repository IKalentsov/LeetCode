namespace LeetCodeSolutions
{
    /// <summary>
    /// 1480. Running Sum of 1d Array
    /// https://leetcode.com/problems/running-sum-of-1d-array/
    /// 
    /// Description
    /// Given an array nums. We define a running sum of an array as 
    /// runningSum[i] = sum(nums[0]…nums[i]).
    /// Return the running sum of nums
    /// </summary>
    public class RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums)
        {
            var value = 0;
            var array = new int[nums.Length];

            for (var num = 0; num < nums.Length; num++) 
            {
                if (num == 0)
                {
                    value = nums[num];
                    array[num] = value;

                    continue;
                }

                value += nums[num];

                array[num] = value;
            }

            return array;
        }
    }
}