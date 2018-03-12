// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// Example:
// Given nums = [2, 7, 11, 15], target = 9,

// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].
// Subscribe to see which companies asked this question.
partial class TwoSum {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length - 1; ++i)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                    return new int[2]{i, j};
            }
        }
        return null;
    }
}