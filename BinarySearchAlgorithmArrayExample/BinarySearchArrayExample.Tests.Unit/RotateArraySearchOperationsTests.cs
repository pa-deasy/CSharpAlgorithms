using NUnit.Framework;

namespace BinarySearchArrayExample.Tests.Unit
{
    [TestFixture]
    public class RotateArraySearchOperationsTests
    {
        [Test]
        public void Given_RotatedArrayA_When_TargetNumberExists_Then_ReturnsIndex()
        {
            var numbers = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };

            Assert.AreEqual(8, numbers.PositionOf(3));
        }

        [Test]
        public void Given_RotatedArrayB_When_TargetNumberExists_Then_ReturnsIndex()
        {
            var numbers = new int[] { 30, 40, 50, 10, 20 };

            Assert.AreEqual(3, numbers.PositionOf(10));
        }

        [Test]
        public void Given_RotatedArray_When_TargetNumberDoesNotExist_Then_ReturnMinusOne()
        {
            var numbers = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };

            Assert.AreEqual(-1, numbers.PositionOf(50));
        }
    }
}
