/*
 Two Sum Problem
 -------------------
 Problem Link: https://leetcode.com/problems/two-sum/
 Run Time: 133ms
 Memory: 47.55 MB
 -------------------
*/

namespace LeetCode.LeetCode
{
    public class Problem_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int newValue;
            int deneme2 = 20;
            for (int i = 0; i < nums.Length; i++)
            {
                newValue = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (newValue + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }
    }
}
