// 448. Find All Numbers Disappeared in an Array
// Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

// Find all the elements of [1, n] inclusive that do not appear in this array.

// Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.

// Example:

// Input:
// [4,3,2,7,8,2,3,1]

// Output:
// [5,6]
// Subscribe to see which companies asked this question.

// Show Tags
// Show Similar Problems
using System.Collections.Generic;
partial class FindAllNumbersDisappearedInAnArray {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        for(int i = 0; i < nums.Length; ++i)
        {
            int val = System.Math.Abs(nums[i]) -1;
            if(nums[val] > 0)
                nums[val] = -nums[val];
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] > 0)
                result.Add(i+1);
        }
        return result;
    }
}