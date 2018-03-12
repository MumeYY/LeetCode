// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

// Note: The solution set must not contain duplicate triplets.

// For example, given array S = [-1, 0, 1, 2, -1, -4],

// A solution set is:
// [
//   [-1, 0, 1],
//   [-1, -1, 2]
// ]
// Subscribe to see which companies asked this question.


//一般来说大于n^2的复杂度的算法就不需要继续下去了
//同时一般一个无序的数组优先排序总是有好处的
using System.Collections.Generic;
using System;
partial class ThreeSum {
    public IList<IList<int>> Solution(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for(int i = 0; i < nums.Length - 2; ++i)
        {
            int target = -nums[i];
            int head = i + 1;
            int tail = nums.Length - 1;

            while (head < tail)
            {
                int sum = nums[head] + nums[tail];
                if(sum < target)
                {
                    head++;
                }
                else if (sum > target)
                {
                    tail--;
                }
                else
                {
                    IList<int> tmp = new List<int>(new int[]{nums[i], nums[head], nums[tail]});
                    result.Add(tmp);
                    //除重复
                    while(head<tail && nums[head] == tmp[1]) head++;
                    while(head<tail && nums[tail] == tmp[2]) tail--;
                }
            }

            //除重复
            while(i < nums.Length - 2 && nums[i+1] == nums[i])
                i++;
        }
        

        return result;
    }
}

//时间复杂度O(n^4)
//Time Limit Exceeded
// public class Solution {
//     struct ThreeSumStruct{
//         public int a;
//         public int b;
//         public int c;

//         public ThreeSumStruct(int x, int y, int z)
//         {
//             this.a = x;
//             this.b = y;
//             this.c = z;
//         }
//     }
//     public IList<IList<int>> ThreeSum(int[] nums) {
//         Array.Sort(nums);
//         List<ThreeSumStruct> Tmpresult = new List<ThreeSumStruct>();
//         for (int i = 0; i < nums.Length - 2; i++)
//         {
//             for(int j = i + 1; j < nums.Length - 1; j++)
//             {
//                 for (int k = j + 1; k < nums.Length; k++)
//                 {
//                     if(nums[i] + nums[j] + nums[k] == 0)
//                     {
//                         var tmp = new ThreeSumStruct(nums[i], nums[j], nums[k]);
//                         if (!Tmpresult.Contains(tmp))
//                             Tmpresult.Add(tmp);
//                     }
//                 }
//             }
//         }
//         IList<IList<int>> result = new List<IList<int>>();
//         foreach (var item in Tmpresult)
//         {
//             IList<int> tmp = new List<int>();
//             tmp.Add(item.a);
//             tmp.Add(item.b);
//             tmp.Add(item.c);
//             result.Add(tmp);
//         }

//         return result;
//     }
// }
//