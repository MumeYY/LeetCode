// Given a string, find the length of the longest substring without repeating characters.

// Examples:

// Given "abcabcbb", the answer is "abc", which the length is 3.

// Given "bbbbb", the answer is "b", with the length of 1.

// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

// Subscribe to see which companies asked this question.
//思路1
//O(n^2)
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // char[] charArray = s.ToArray();
        int[] result = new int[s.Length+1];
        result[0] = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s.IndexOf(s[i],  i - result[i], result[i] + 1));
        }
    }
}