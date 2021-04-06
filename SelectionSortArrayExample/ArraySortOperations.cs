using System.Linq;

namespace SelectionSortArrayExample
{
    public static class ArraySortOperations
    {
        public static int[] SelectionSort(this int[] numbersArray)
        {
            var orderedArray = new int[0];

            while(numbersArray.Length > 0)
            {
                var smallestIndex = numbersArray.FindSmallestIndex();

                orderedArray = orderedArray.Append(numbersArray[smallestIndex]).ToArray();

                numbersArray = numbersArray.RemoveAt(smallestIndex);
            }

            return orderedArray;
        }

        private static int FindSmallestIndex(this int[] numbersArray)
        {
            var smallestIndex = 0;

            for(int i = 1; i < numbersArray.Length; i++ )
            {
                if (numbersArray[i] < numbersArray[smallestIndex])
                    smallestIndex = i;
            }

            return smallestIndex;
        }

        private static int[] RemoveAt(this int[] numbersArray, int index)
        {
            var numbersList = numbersArray.ToList();
            numbersList.RemoveAt(index);
            return numbersList.ToArray();
        }
    }
}
