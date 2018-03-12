// 515. Find Largest Value in Each Tree Row
// You need to find the largest value in each row of a binary tree.

// Example:
// Input: 

//           1
//          / \
//         3   2
//        / \   \  
//       5   3   9 

// Output: [1, 3, 9]
// Subscribe to see which companies asked this question.
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 using System.Collections.Generic;
partial class FindLargestValueInEachTreeRow {
    public IList<int> LargestValues(TreeNode root) {
        IList<int> result = new List<int>();
        if(root == null)
        {
            return result;
        }
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            var queueSize = q.Count;
            var largestValue = int.MinValue;
            for(int i = 0; i < queueSize; ++i)
            {
                var tmpNode = q.Dequeue();
                largestValue = System.Math.Max(largestValue, tmpNode.val);
                if(tmpNode.left != null) q.Enqueue(tmpNode.left);
                if(tmpNode.right != null) q.Enqueue(tmpNode.right);
            }
            result.Add(largestValue);
        }
        return result;
    }
}
 //层次遍历写得太啰嗦了
// partial class Solution {
//     public IList<int> LargestValues(TreeNode root) {
//         IList<int> result = new List<int>();
//         if(root == null)
//         {
//             return result;
//         }
//         Queue<KeyValuePair<int, TreeNode>> q = new Queue<KeyValuePair<int, TreeNode>>();
//         q.Enqueue(new KeyValuePair<int, TreeNode>(1, root));
//         int height = 1;
//         int maxVal = int.MinValue;
//         while(q.Count > 0)
//         {
//             var tmp = q.Dequeue();
//             TreeNode tmpNode = tmp.Value;
//             var tmpheight = tmp.Key;
//             if(tmpheight == height)
//             {
//                 maxVal = System.Math.Max(maxVal, tmpNode.val);
//             }
//             else
//             {
//                 height = tmpheight;
//                 result.Add(maxVal);
//                 maxVal = tmpNode.val;
//             }
//             if(tmpNode.left != null)
//             {
//                 q.Enqueue(new KeyValuePair<int, TreeNode>(tmpheight+1, tmpNode.left));
//             }
//             if(tmpNode.right != null)
//             {
//                 q.Enqueue(new KeyValuePair<int, TreeNode>(tmpheight+1, tmpNode.right));
//             }
//         }
//         result.Add(maxVal);
//         return result;
//     }
// }