using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public class Program
        {
            /*Input
            ["MyLinkedList", "addAtHead", "addAtTail", "addAtIndex", "get", "deleteAtIndex", "get"]
            [[], [1], [3], [1, 2], [1], [1], [1]]
            Output
            [null, null, null, null, 2, null, 3]*/
            public static void LinkedList(string[] args)
            {
                MyLinkedList myLinkedList = new MyLinkedList();
                myLinkedList.AddAtHead(1);
                myLinkedList.AddAtTail(3);
                myLinkedList.AddAtIndex(1, 2);
                myLinkedList.Get(1);
                myLinkedList.DeleteAtIndex(1);
                myLinkedList.Get(1);

                Console.ReadKey();
            }
        }

        private Node head;
        int length = 0;

        public static ListNode CreateSinglyLinkedList(int[] list) => CreateList(list, out _);

        public static ListNode CreateSinglyLinkedList(int[] list, out ListNode tail) => CreateList(list, out tail);

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

            return head;
        }

            public MyLinkedList()
        {

        }
        public int Get(int index)
        {
            if (this.head == null)
            {
                return -1;
            }

            Node temp = this.head;
            int curr = 0;

            while (curr < index && temp != null)
            {
                temp = temp.next;
                curr++;
            }

            if (curr == index && temp != null)
            {
                return temp.val;
            }
            else
            {
                return -1;
            }
        }

        public void AddAtHead(int val)
        {
            Node newHead = new Node(val, this.head);
            this.head = newHead;
        }

        public void AddAtTail(int val)
        {
            if (this.head == null)
            {
                this.head = new Node(val);
                return;
            }

            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new Node(val);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > length)
            {
                return;
            }

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            var newNode = new Node(val);
            if (index == length)
            {
                AddAtTail(val);
                return;
            }

            int countDown = 0;
            var counter = head;
            while (countDown != index && counter != null)
            {
                countDown++;
                counter = counter.next;
            }

            if (counter == null)
            {
                return;
            }

            var prev = counter.prev;
            newNode.prev = prev;
            newNode.next = counter;
            prev.next = newNode;
            counter.prev = newNode;
            length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0 && head != null)
            {
                this.head = this.head.next;
                return;
            }

            Node temp = this.head;
            int curr = 0;

            while (curr < index - 1 && temp != null)
            {
                temp = temp.next;
                curr++;
            }

            if (curr == index - 1 && temp.next != null)
            {
                temp.next = temp.next.next;
                return;
            }
        }


        public class Node
        {
            public int val { get; set; }
            public Node next { get; set; }
            public Node prev { get; set; }


            public Node(int v)
            {
                this.val = v;
            }

            public Node(int v, Node next)
            {
                this.val = v;
                this.next = next;
            }
        }
    }
}