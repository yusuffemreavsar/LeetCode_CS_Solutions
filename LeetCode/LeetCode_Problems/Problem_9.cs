/*
 Palindrome Number Problem
 -------------------
 Problem Link: https://leetcode.com/problems/palindrome-number/
 Run Time: 38ms
 Memory: 39.60 MB
 -------------------
*/

namespace LeetCode.LeetCode_Problems
{
    public class Problem_9
    {
        public bool IsPalindrome(int x)
        {
            string reverseNumber = "";
            string orgNumber = x.ToString();
            if (x >= 0)
            {
                for (int i = orgNumber.Length - 1; i >= 0; i--)
                {
                    reverseNumber += orgNumber[i];
                }
            }
            return reverseNumber == orgNumber & x >= 0;

        }
    }
}
