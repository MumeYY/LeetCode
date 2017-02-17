public class Solution {
    public string[] FindWords(string[] words) {
        char[] line1 = "qwertyuiop".ToArray();
        char[] line2 = "asdfghjkl".ToArray();
        char[] line3 = "zxcvbnm".ToArray();

        List<string> result = new List<string>();
        foreach (var item in words)
        {
            if(CheckAddCation(item.ToLower().ToArray(), line1) 
            || CheckAddCation(item.ToLower().ToArray(), line2) 
            || CheckAddCation(item.ToLower().ToArray(), line3) )
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