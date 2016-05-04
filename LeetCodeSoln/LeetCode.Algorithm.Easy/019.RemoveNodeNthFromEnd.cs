/**
 * https://leetcode.com/problems/remove-duplicates-from-sorted-list/
 * 
 * Tags: Linkedlist
 */

namespace LeetCode.Algorithm.Easy
{
    class RemoveNodeNthFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode listNode = new ListNode(0);
            listNode.Next = head;

            ListNode node1 = listNode;
            ListNode node2 = listNode;

            for (int i = 0; i < n; i++)
            {
                node2 = node2.Next;
            }

            while (node2.Next != null)
            {
                node1 = node1.Next;
                node2 = node2.Next;
            }

            node1.Next = node1.Next.Next;
            return listNode.Next;
        }
    }
}
