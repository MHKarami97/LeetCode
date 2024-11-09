using BenchmarkDotNet.Attributes;

namespace LeetCode.Problems;

/*
Given an integer array nums, find the
subarray
 with the largest sum, and return its sum.



Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.


Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104


Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
*/
public class P53 : IProgram
{
    [Benchmark]
    public void Run()
    {
        _ = MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
    }

    private int MaxSubArray(int[] nums)
    {
        var maxSubArrayValue = nums[0];
        var currentSum = 0;

        foreach (var item in nums)
        {
            if (currentSum < 0)
            {
                currentSum = 0;
            }

            currentSum += item;
            maxSubArrayValue = Math.Max(maxSubArrayValue, currentSum);
        }

        return maxSubArrayValue;
    }
}