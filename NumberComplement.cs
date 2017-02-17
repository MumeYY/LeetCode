//两数相加等于2^n - 1
//2 << 31次方错误，成为负数
public class Solution {
    public int FindComplement(int num) {
        if(num == 0 || num == 1)
        {
            return 0;
        }
        int[] tmp = new int[32];
        for (int i = 0; i < tmp.Length; i++)
        {
            tmp[i] = 0x1 << i;
        }
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            if (tmp[i] <= num && num < tmp[i+1])
            {
                return tmp[i+1] - 1 - num;
            }
        }
        return 0;
    }
}