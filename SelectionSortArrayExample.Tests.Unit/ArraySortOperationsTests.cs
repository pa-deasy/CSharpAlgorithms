using NUnit.Framework;

namespace SelectionSortArrayExample.Tests.Unit
{
    [TestFixture]
    public class ArraySortOperationsTests
    {
        [Test]
        public void Given_NumbersArray_When_Sorted_Then_OrderedCorrectly()
        {
            var numbersArray = new int[] { 5, 3, 6, 2, 10 };

            var sortedArray = numbersArray.SelectionSort();

            Assert.AreEqual(2, sortedArray[0]);
            Assert.AreEqual(3, sortedArray[1]);
            Assert.AreEqual(5, sortedArray[2]);
            Assert.AreEqual(6, sortedArray[3]);
            Assert.AreEqual(10, sortedArray[4]);
        }
    }
}
