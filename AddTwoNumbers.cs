// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8

// Subscribe to see which companies asked this question.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode TmpResult = result;
        // bool bCarry = false;
        int sum = 0;
        while (l1 != null || l2 != null)
        {
            if(l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            TmpResult.val = sum % 10;
            sum /= 10;
            if(sum > 0 || l1 != null || l2 != null)
            {
                TmpResult.next = new ListNode(0);
                TmpResult = TmpResult.next;
            }
        }
        if(sum > 0)
        {
            TmpResult.val = 1;
        }
        return result;
    }
}
//整体来说太啰嗦了
// public class Solution {
//     public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
//         // if (l1 == null)
//         // {
//         //     return l2;
//         // }
//         // else if(l2 == null)
//         // {
//         //     return l1;
//         // }
//         ListNode result = new ListNode(0);
//         ListNode TmpResult = result;
//         bool bCarry = false;
//         while (l1 != null && l2 != null)
//         {
//             int tmp = l1.val + l2.val + (bCarry ? 1 : 0);
//             bCarry = tmp >= 10;
//             TmpResult.val = tmp % 10;
//             if(bCarry || l1.next != null || l2.next != null)
//             {
//                 TmpResult.next = new ListNode(0);
//                 TmpResult = TmpResult.next;
//             }
//             l1 = l1.next;
//             l2 = l2.next;
//         }
//         l1 = l1 != null ? l1 : l2;
//         while (l1 != null)
//         {
//             int tmp = l1.val + (bCarry ? 1 : 0);
//             bCarry = tmp >= 10;
//             TmpResult.val = tmp % 10;
//             if(bCarry || l1.next != null)
//             {
//                 TmpResult.next = new ListNode(0);
//                 TmpResult = TmpResult.next;
//             }
//             l1 = l1.next;
//         }
//         if(bCarry)
//         {
//             TmpResult.val = 1;
//         }
//         return result;
//     }
// }