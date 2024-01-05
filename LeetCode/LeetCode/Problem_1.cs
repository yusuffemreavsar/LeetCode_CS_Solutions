/*
 
 Two Sum Problen
 ------------------
 Run Time: 133ms
 Memory: 47.55 MB
 ------------------
*/

namespace LeetCode.LeetCode
{
    internal class Problem_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int newValue;

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
