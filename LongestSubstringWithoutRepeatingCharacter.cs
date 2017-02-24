// Given a string, find the length of the longest substring without repeating characters.

// Examples:

// Given "abcabcbb", the answer is "abc", which the length is 3.

// Given "bbbbb", the answer is "b", with the length of 1.

// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

// Subscribe to see which companies asked this question.
//思路1
//抄袭答案的，总结就是Hash大法好，进坑保平安
//类似题目需要多观察原理
//这是通过维护一个窗口[i, j]，保证窗口内没有相同字符
using System;
using System.Collections.Generic;
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 0)
        {
            return 0;
        }
        int maxLength = 0;
        HashSet<char> charSet = new HashSet<char>();
        for(int i = 0, j = 0; j < s.Length && i < s.Length;)
        {
            if(!charSet.Contains(s[j]))
            {
                maxLength = Math.Max(maxLength, j - i + 1);
                charSet.Add(s[j]);
                ++j;
            }
            else
            {
                charSet.Remove(s[i]);
                ++i;
            }
        }
        return maxLength;
    }
}