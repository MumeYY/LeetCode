using System;
using System.Collections.Generic;
public class Solution {
    public string[] FindWords(string[] words) {
        char[] line1 = "qwertyuiop".ToCharArray();
        char[] line2 = "asdfghjkl".ToCharArray();
        char[] line3 = "zxcvbnm".ToCharArray();

        List<string> result = new List<string>();
        foreach (var item in words)
        {
            if(CheckAddCation(item.ToLower().ToCharArray(), line1) 
            || CheckAddCation(item.ToLower().ToCharArray(), line2) 
            || CheckAddCation(item.ToLower().ToCharArray(), line3) )
                result.Add(item);
        }
        return result.ToArray();
    }
    bool CheckAddCation(char[] input, char[] row)
    {
        foreach (var item in input)
        {
            if (Array.IndexOf(row, item) < 0)
            {
                return false;
            }
        }
        return true;
    }
}