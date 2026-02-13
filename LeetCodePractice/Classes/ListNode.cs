using System;

namespace LeetCodePractice.Classes
{
    // THis is a class to be used with Singly-Linked lists
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val=0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
