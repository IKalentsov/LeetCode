using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// 876. Middle of the Linked List
    /// https://leetcode.com/problems/middle-of-the-linked-list/
    /// 
    /// Description
    /// Given the head of a singly linked list, return the middle node of 
    /// the linked list.
    /// If there are two middle nodes, return the second middle node.
    /// </summary>
    public class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var list = new List<ListNode>();
            var count = 0;

            var next = head;
            while (next != null)
            {
                list.Add(next);
                count++;
                next = next.next;
            }

            return list[count / 2];
        }
    }

    public class ListNode
    {
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int val;
        public ListNode next;
    }
}
