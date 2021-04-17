using NUnit.Framework;

namespace MergeSort.Tests.Unit
{
    [TestFixture]
    public class SortOperationsTests
    {
        [Test]
        public void Given_UnsortedNumbers_When_Sorted_Then_ReturnsNumbersInOrder()
        {
            var numbers = new int[] { 9, 2, 55, 57, 15, 1 };
            var expectedNumbers = new int[] { 1, 2, 9, 15, 55, 57 };

            var sortedNumbers = numbers.SortNumbers();

            Assert.AreEqual(expectedNumbers, sortedNumbers);
        }
    }
}
