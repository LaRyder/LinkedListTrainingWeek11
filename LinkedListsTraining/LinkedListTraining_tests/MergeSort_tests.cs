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
    public class MergeSort_tests
    {
        //[TestMethod]
        //public void Test_Can_Fail()
        //{
        //    //Assert.IsTrue(true);
        //    Assert.Fail();
        //}

        //[TestMethod]
        //public void MergeSort_Empty_ReturnsEmpty()
        //{
        //    var arr = new int[] { };

        //    var actual = Sort.MergeSort(arr);

        //    Assert.AreEqual(actual.Length, 0);
        //}

        //[TestMethod]
        //public void MergeSort_OneItem_ReturnsItem()
        //{
        //    var arr = new int[] { 1 };

        //    var actual = Sort.MergeSort(arr);

        //    Assert.AreEqual(actual.Length, 1);
        //}

        //[TestMethod]
        //public void MergeSort_TwoItems_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 2, 1 };
        //    var expected = new int[] { 1, 2 };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void MergeSort_OddAmountOfItems_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 2, 1, 4, 8, 9 };
        //    var expected = new int[] { 1, 2, 4, 8, 9 };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void MergeSort_EvenAmountOfItems_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 2, 1, 4, 8, 9, 6 };
        //    var expected = new int[] { 1, 2, 4, 6, 8, 9 };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void MergeSort_ReversedList_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        //    var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void MergeSort_SimilarItemList_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 5, 6, 5, 6, 5, 6, 5, 6 };
        //    var expected = new int[] { 5, 5, 5, 5, 6, 6, 6, 6 };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void MergeSort_SpecialMergeSortSortNumberList_ReturnsItemsSorted()
        {
            var input = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            var expected = new int[] { 3, 9, 10, 27, 38, 43, 82 };

            var actual = Sort.MergeSort(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void MergeSort_ListWithBounds_ReturnsItemsSorted()
        //{
        //    var arr = new int[] { 99999, Int32.MaxValue, Int32.MinValue, 10, 44, -1111, 0, 2, 2, 2, -1 };
        //    var expected = new int[] { Int32.MinValue, -1111, -1, 0, 2, 2, 2, 10, 44, 99999, Int32.MaxValue };

        //    var actual = Sort.MergeSort(arr);

        //    CollectionAssert.AreEqual(expected, actual);
        //}
    }
}

