using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public static class SortOperations
    {
        public static int[] SortNumbers(this int[] numbers)
        {
            if (!numbers.Any() || numbers.Length == 1)
                return numbers;

            var numbersQueue = new Queue<int>(numbers);
            var half = numbers.Length / 2;
            var leftNumbers = new List<int>();
            var rightNumbers = new List<int>();

            while (numbersQueue.Any())
            {
                if (numbersQueue.Count <= half)
                    leftNumbers.Add(numbersQueue.Dequeue());

                else
                    rightNumbers.Add(numbersQueue.Dequeue());
            }

            return leftNumbers.ToArray().SortNumbers()
                .MergeWith(rightNumbers.ToArray().SortNumbers());
        }

        private static int[] MergeWith(this int[] leftNumbers, int[] rightNumbers)
        {
            var mergedNumbers = new List<int>();

            var leftQueue = new Queue<int>(leftNumbers);
            var rightQueue = new Queue<int>(rightNumbers);

            while(leftQueue.Any())
            {
                if (!rightQueue.Any() || leftQueue.Peek() < rightQueue.Peek())
                    mergedNumbers.Add(leftQueue.Dequeue());

                else
                    mergedNumbers.Add(rightQueue.Dequeue());
            }

            if (rightQueue.Any())
                mergedNumbers.AddRange(rightQueue);

            return mergedNumbers.ToArray();
        }
    }
}
