namespace BinarySearchArrayExample
{
    public static class ArraySearchOperations
    {
        public static bool BinarySearch(this int[] inputArray, int target)
            => inputArray.BinarySearch(target, 0, inputArray.Length - 1);

        private static bool BinarySearch(this int[] inputArray, int target, int low, int high)
        {
            if (low > high)
                return false;

            var mid = (low + high) / 2;
            var guess = inputArray[mid];

            if (guess == target)
                return true;

            if (target > guess)
                return inputArray.BinarySearch(target, mid + 1, high);

            if (guess > target)
                return inputArray.BinarySearch(target, low, mid - 1);

            return false;
        }
    }
}
