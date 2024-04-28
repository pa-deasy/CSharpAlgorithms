using NUnit.Framework;

namespace MergeSort.Tests.Unit
{
    [TestFixture]
    public class SortOperationsTests
    {
        [Test]
        public void Given_UnsortedNumbersA_When_Sorted_Then_ReturnsNumbersInOrder()
        {
            var numbers = new int[] { 9, 2, 55, 57, 15, 1 };
            var expectedNumbers = new int[] { 1, 2, 9, 15, 55, 57 };

            var sortedNumbers = numbers.SortNumbers();

            Assert.AreEqual(expectedNumbers, sortedNumbers);
        }

        [Test]
        public void Given_UnsortedNumbersB_When_Sorted_Then_ReturnsNumbersInOrder()
        {
            var numbers = new int[] { 12, 11, 13, 5, 6, 7 };
            var expectedNumbers = new int[] { 5, 6, 7, 11, 12, 13 };

            var sortedNumbers = numbers.SortNumbers();

            Assert.AreEqual(expectedNumbers, sortedNumbers);
        }

        [Test]
        public void Given_UnsortedNumbersC_When_Sorted_Then_ReturnsNumbersInOrder()
        {
            var numbers = new int[] { 79, 69, 9, 95, 65, 49, 65, 40, 27, 95 };
            var expectedNumbers = new int[] { 9, 27, 40, 49, 65, 65, 69, 79, 95, 95 };

            var sortedNumbers = numbers.SortNumbers();

            Assert.AreEqual(expectedNumbers, sortedNumbers);
        }

        [Test]
        public void Given_UnsortedNumbersD_When_Sorted_Then_ReturnsNumbersInOrder()
        {
            var numbers = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            var expectedNumbers = new int[] { 3, 9, 10, 27, 38, 43, 82 };

            var sortedNumbers = numbers.SortNumbers();

            Assert.AreEqual(expectedNumbers, sortedNumbers);
        }
    }
}
