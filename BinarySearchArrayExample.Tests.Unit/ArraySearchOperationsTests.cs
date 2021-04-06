using FluentAssertions;
using NUnit.Framework;

namespace BinarySearchArrayExample.Tests.Unit
{
    [TestFixture]
    public class ArraySearchOperationsTests
    {
        private int[] _numbersArray = new int[] { 1, 3, 5, 7, 9 };

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        public void Given_IntArray_When_Exists_Returned_Element(int target)
        {
            _numbersArray.BinarySearch(target).Should().BeTrue();
        }

        [Test]
        public void Given_IntArray_When_DoesNotExist_Returned_Null()
        {
            _numbersArray.BinarySearch(2).Should().BeFalse();
        }
    }
}
