using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace QuickSort.Tests.Unit
{
    [TestFixture]
    public class ListExtensionsTests
    {
        [Test]
        public void Given_ListNumbers_When_QuickSorted_Then_ReturnsSortedList()
        {
            var numbers = new List<int> { 10, 5, 2, 3, 5 };
            var sortedNumbers = numbers.QuickSort();

            sortedNumbers[0].Should().Be(2);
            sortedNumbers[1].Should().Be(3);
            sortedNumbers[2].Should().Be(5);
            sortedNumbers[3].Should().Be(5);
            sortedNumbers[4].Should().Be(10);
        }
    }
}
