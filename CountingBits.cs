// 338. Counting Bits
// Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

// Example:
// For num = 5 you should return [0,1,1,2,1,2].

// Follow up:

// It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
// Space complexity should be O(n).
// Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.

// Hint
// You should make use of what you have produced already.
// Divide the numbers in ranges like [2-3], [4-7], [8-15] and so on. And try to generate new range from previous.
// Or does the odd/even status of the number help you in calculating the number of 1s?
partial class CountingBits {
    public int[] CountBits(int num) {
        if(num == 0)
        {
            return new int[1]{0};
        }
        else if(num == 1)
        {
            return new int[2]{0,1};
        }
        int[] result = new int[num+1];
        result[0] = 0;
        result[1] = 1;
        for (int i = 2; i < result.Length; i++)
        {
            result[i] = result[i / 2] + (i % 2);
        }
        return result;
    }
}
//看到代码
//优化点在于i/2以及i%2用位运算