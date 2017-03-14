// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// Example:
// Given nums = [2, 7, 11, 15], target = 9,

// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].
// Subscribe to see which companies asked this question.
using System.Collections.Generic;
partial class Solution {
    public int[] TwoSumHashMap(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return new int[]{map[target - nums[i]], i};
            }
            map.Add(nums[i], i);
        }
        return null;
    }
}