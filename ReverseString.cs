// Write a function that takes a string as input and returns the string reversed.

// Example:
// Given s = "hello", return "olleh".

// Subscribe to see which companies asked this question.
partial class Solution {
    public string ReverseString(string s) {
        char[] result = new char[s.Length];
        for(int i = 0; i < s.Length; ++i)
        {
            result[i] = s[s.Length - 1 - i];
        }
        return new string(result);
    }
}