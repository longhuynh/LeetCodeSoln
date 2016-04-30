/**
 * https://leetcode.com/problems/remove-duplicates-from-sorted-list/
 * Given a sorted linked list, delete all duplicates such that each element
 * appear only once.
 * 
 * For example,
 * Given 1->1->2, return 1->2.
 * Given 1->1->2->3->3, return 1->2->3.
 * 
 * Tags: Linkedlist
 */

namespace LeetCode.Algorithm.Easy
{
    class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode currentNode = head;
            while (currentNode != null)
            {
                while (currentNode.Next != null && currentNode.Value == currentNode.Next.Value)
                {
                    currentNode.Next = currentNode.Next.Next;
                }
                currentNode = currentNode.Next;
            }
            return head;
        }

        public ListNode DeleteDuplicates2(ListNode head)
        {
            if (head == null) return null;

            ListNode dummyHead = new ListNode(0) {Next = head};
            ListNode previousNode = head;
            ListNode currentNode = head.Next;
            while (currentNode != null)
            {
                while (currentNode != null && previousNode.Value == currentNode.Value)
                {
                    currentNode = currentNode.Next;
                }

                previousNode.Next = currentNode;
                previousNode = currentNode;
                currentNode = currentNode?.Next;
            }
            return dummyHead.Next;
        }
    }

    public class ListNode
    {
        public int Value;
        public ListNode Next;

        public ListNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
