using System;

namespace BinarySearchArrayExample
{
    public static class RotateArraySearchOperations
    {
        public static int PositionOf(this int[] numbers, int target)
        {
            var pivotPoint = numbers.FindPivotPoint();

            var leftArray = new int[pivotPoint + 1];
            var rightArray = new int[numbers.Length - pivotPoint - 1];
            Array.Copy(numbers, leftArray, pivotPoint + 1);
            Array.Copy(numbers, pivotPoint + 1, rightArray, 0, numbers.Length - pivotPoint - 1);

            var targetIndexInLeft = leftArray.BinarySearchFor(target);

            if (targetIndexInLeft != -1)
                return targetIndexInLeft;

            var targetIndexInRight = rightArray.BinarySearchFor(target);

            if (targetIndexInRight != -1)
                return pivotPoint + 1 + targetIndexInRight;

            return -1;
        }

        private static int FindPivotPoint(this int[] numbers)
        {
            var lower = 0;
            var upper = numbers.Length - 1;

            while (lower <= upper)
            {
                var mid = (lower + upper) / 2;

                if (numbers[mid] > numbers[mid + 1])
                    return mid;

                if (numbers[mid] < numbers[mid - 1])
                    return mid - 1;

                if (numbers[mid] <= numbers[lower])
                    upper = mid - 1;

                if (numbers[mid] >= numbers[upper])
                    lower = mid + 1;
            }

            return 0;
        }

        private static int BinarySearchFor(this int[] numbers, int target)
        {
            var lower = 0;
            var upper = numbers.Length - 1;

            while (lower <= upper)
            {
                var mid = (lower + upper) / 2;

                if (numbers[mid] == target)
                    return mid;

                if (numbers[mid] <= target)
                    lower = mid + 1;

                if (numbers[mid] > target)
                    upper = mid - 1;
            }

            return -1;
        }
    }
}
