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
            for (var num = 1; num < nums.Length; num++)
            {
                nums[num] += nums[num - 1];
            }

            return nums;
        }
    }
}