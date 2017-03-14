//两数相加等于2^n - 1
//2 << 31次方错误，成为负数
//所以需要修改
partial class Solution {
    public int FindComplement(int num) {
        if(num == 0 || num == 1)
        {
            return 0;
        }
        uint unum = (uint)num;
        uint[] tmp = new uint[32];
        for (int i = 0; i < tmp.Length; i++)
        {
            tmp[i] = (uint)0x1 << i;
        }
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            if (tmp[i] <= unum && unum < tmp[i+1])
            {
                return (int)(tmp[i+1] - 1 - unum);
            }
        }
        return 0;
    }
}