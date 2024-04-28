using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    public static class ListExtensions
    {
        public static IList<int> QuickSort(this IList<int> numbers)
        {
            if (numbers.Count < 2)
                return numbers;

            var numbersStack = new Stack<int>(numbers.ToArray());

            var pivot = numbersStack.Pop();

            var lesserNumbers = numbersStack.Where(n => n <= pivot).ToList();
            var greaterNumbers = numbersStack.Where(n => n > pivot).ToList();

            var sortedList = new List<int>();
            sortedList.AddRange(lesserNumbers.QuickSort());
            sortedList.Add(pivot);
            sortedList.AddRange(greaterNumbers.QuickSort());

            return sortedList;
        }
    }
}
