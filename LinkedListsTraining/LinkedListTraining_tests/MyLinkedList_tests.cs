using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        MyLinkedList myLinkedList = new MyLinkedList();

        List<string> list = new List<string>();
        list.Add ListNode("MyLinkedList");
        int param_1 = obj.get(index);
        obj.addAtHead(val);
        obj.addAtTail(val);
        obj.addAtIndex(index, val);
        obj.deleteAtIndex(index);


        public static class AssertLinkedList
        {
            public static void NodesHaveEqualValue(ListNode expected, ListNode actual)
            {
                while (expected != null)
                {
                    Assert.AreEqual(expected.val, actual.val);
                    expected = expected.next;
                    actual = actual.next;
                }
            }
        }
        [TestMethod]
        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void addAtHead_OneNumber_CanReturnNumber()
        { 
            var input = 2;
            var expected = 0;

            var sut = new MyLinkedList();

            sut.addAtHead(input);

            var actual = sut.get(0);
            Assert.AreEqual(expected, actual);

            
        }

        [TestMethod]
        /** Append a node of value val to the last element of the linked list. */
        public void addAtTail_LastElement_CanReturnNumber()
        {
            myLinkedList.addAtTail(3);
            int[] addatTail;
        }

        [TestMethod]
        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void addAtIndex_IfValid_CanReturnNumber()
        {
            myLinkedList.addAtIndex(1, 2); //linked list becomes 1>2>3
            int[] addAtIndex;
        }

        [TestMethod]
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public void Get_Value_CanReturnANumber()
        {
            myLinkedList.get(1); // returns 2
        }

        [TestMethod]
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void deleteAtIndex_IfValid_CanReturnNumber()
        {
            myLinkedList.deleteAtIndex(1); //now the linked list is 1>3
        }

        public void Get_Value_CanReturnAnotherNumber()
        { 
            myLinkedList.get(1); // returns 3
        }
    }
}
