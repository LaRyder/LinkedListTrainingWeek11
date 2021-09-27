using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public static ListNode CreateSinglyLinkedList(int[] list) => CreateList(list, out);
        public static ListNode CreateSingleLinkedList(int[] list, out ListNode tail) => CreateList(list, out tail);

        private static ListNode CreateList(int[] list, out ListNode tail)
        {
            ListNode head = null;
            tail = null;

            if (list.Length > 0) tail = head = new ListNode(list[0]);

            if (list.Length > 1)
            {
                for (var i = 1; i < list.Length; i++)
                {
                    tail = tail.next = new ListNode(list[i]);
                }
            }
        }


        MyLinkedList myLinkedList = new MyLinkedList();

        static ListNode node;
        static int length;

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
            }

            public ListNode(int val, ListNode next)
            {
                this.val = val;
                this.next = next;
            }
        }
 
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            node = new ListNode(0);
            length = 0;
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int get(int index)
        {
            if((index < 0) || (index >= length))
            {
                return -1;
            }
            ListNode cur = node.next;
            while (index-- > -0)
            {
                cur = cur.next;
            }
            return cur.val;

        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void addAtHead(int val)
        {
            addAtIndex(0, val);
        }

        /** Append a node of val val to the last element of the linked list. */
        public void addAtTail(int val)
        {
            addAtIndex(length, val);
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void addAtIndex(int index, int val)
        {
            if (index > length)
            {
                return;
            }
            ListNode pre = node;
            while (index-- > 0)
            {
                pre = pre.next;
            }
            pre.next = new ListNode(val, pre.next);
            ++length;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void deleteAtIndex(int index)
        {
            if (index < 0 || index >= length)
            {
                return;
            }
            ListNode pre = node;
            while(index-- > 0)
            {
                pre = pre.next;
            }
            ListNode t = pre.next;
            pre.next = t.next;
            t.next = null;
            --length;
        }
    }
}
