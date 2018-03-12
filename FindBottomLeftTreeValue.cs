// Given a binary tree, find the leftmost value in the last row of the tree.

// Example 1:
// Input:

//     2
//    / \
//   1   3

// Output:
// 1
// Example 2: 
// Input:

//         1
//        / \
//       2   3
//      /   / \
//     4   5   6
//        /
//       7

// Output:
// 7
// Note: You may assume the tree (i.e., the given root node) is not NULL.
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

 //这里用二叉树的后项层次遍历
 //二叉树的前序遍历，后序遍历，中序遍历，层次遍历
 //前面几个都用栈，属于深度优先搜索
 //层次遍历用队列，属于广度优先搜索
 using System.Collections.Generic;
partial class FindBottomLeftTreeValue {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public int FindBottomLeftValue(TreeNode root) {
        // int result = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            root = q.Dequeue();
            // result = root.val;
            if(root.right != null)
            {
                q.Enqueue(root.right);
            }
            if(root.left != null)
            {
                q.Enqueue(root.left);
            }
        }
        return root.val;
    }
    //根节点 左 右
    public void Preorder(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        // s.Push(root);
        while(root != null || s.Count > 0)
        {
            if (root != null)
            {
                // Visit(root);
                s.Push(root);
                root = root.left;
            }
            if(s.Count > 0)
            {
                root = s.Pop();
                root = root.right;
            }
        }
    }
}