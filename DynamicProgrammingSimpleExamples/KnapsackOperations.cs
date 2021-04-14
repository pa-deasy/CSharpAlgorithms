using System;
using System.Collections.Generic;

namespace DynamicProgrammingSimpleExamples
{
    public static class KnapsackOperations
    {
        public static int MaxWorthInBagSizeOf(this List<StealableItem> stealableItems, int bagSize)
        {
            var evaluationgrid = new int[stealableItems.Count, bagSize];

            for(int row = 0; row < stealableItems.Count; row++)
            {
                for(int column = 1; column <= bagSize; column++)
                {
                    var previousMax = row -1 >= 0 
                        ? evaluationgrid[row - 1, column - 1] 
                        : 0;

                    var currentValue = stealableItems[row].Weight <= column 
                        ? stealableItems[row].Value
                        : 0;

                    var remainingValue = row - 1 >= 0 && column - 1 - stealableItems[row].Weight >= 0 
                        ? evaluationgrid[row - 1, column - 1 - stealableItems[row].Weight]
                        : 0;

                    evaluationgrid[row, column - 1] = Math.Max(previousMax, currentValue + remainingValue);
                }
            }
            return evaluationgrid[stealableItems.Count - 1 , bagSize - 1];
        }
    }

    public class StealableItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
    }
}
