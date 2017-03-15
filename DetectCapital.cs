// 520. Detect Capital
// Given a word, you need to judge whether the usage of capitals in it is right or not.

// We define the usage of capitals in a word to be right when one of the following cases holds:

// All letters in this word are capitals, like "USA".
// All letters in this word are not capitals, like "leetcode".
// Only the first letter in this word is capital if it has more than one letter, like "Google".
// Otherwise, we define that this word doesn't use capitals in a right way.
// Example 1:
// Input: "USA"
// Output: True
// Example 2:
// Input: "FlaG"
// Output: False
// Note: The input will be a non-empty word consisting of uppercase and lowercase latin letters.

// Subscribe to see which companies asked this question.
partial class Solution {
    public bool DetectCapitalUse(string word) {
        if(word.Length == 0)
        {
            return false;
        }
        char First = word[0];
        if(char.IsLower(First))
        {
            for(int i = 1; i < word.Length; ++i)
            {
                if(!char.IsLower(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
        else if(char.IsUpper(First))
        {
            bool bAllUpper = true;
            bool bAllLower = true;
            for(int i = 1; i < word.Length; ++i)
            {
                bAllLower = bAllLower && char.IsLower(word[i]);
                bAllUpper = bAllUpper && char.IsUpper(word[i]);
                if(!bAllLower && !bAllUpper)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}