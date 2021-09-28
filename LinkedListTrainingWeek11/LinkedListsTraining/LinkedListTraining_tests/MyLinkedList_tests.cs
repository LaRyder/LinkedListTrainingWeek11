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
        /** Add a node of value val before the first element of the linked list. 
         * After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail_LastElement_CanReturnNumber()
        {
            var input = 3;
            var expected = 3;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);

            var actual = sut.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /** Add a node of value val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended to the end of linked list. 
         * If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex_IfValid_CanReturnNumber()
        {
            var index = 1;
            var valueToAdd = 2;
            var sut = new MyLinkedList();

            var expected = valueToAdd;
            var actual = sut.Get(index);

            sut.AddAtIndex(index, valueToAdd);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public void Get_Value_CanReturnANumber()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex_IfValid_CanReturnNumber()
        {
            throw new NotImplementedException();
        }
    }
}