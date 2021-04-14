using System;
using System.Collections.Generic;

namespace DynamicProgrammingSimpleExamples
{
    public static class SightSeeingOperations
    {
        public static int HighestRatingForDaysOf(this List<Sight> sights, int days)
        {
            var evaluationGrid = new int[sights.Count, days * 2];

            for(int row = 0; row < sights.Count; row++)
            {
                for(int column = 0, timeInDays = 1; column < days * 2; column++, timeInDays++)
                {
                    var previousRatingMax = row - 1 >= 0 
                        ? evaluationGrid[row - 1, column]
                        : 0;

                    var currentRating = timeInDays >= sights[row].TimeTaken * 2 
                        ? sights[row].Rating
                        : 0;

                    var remainingRating = row - 1 >= 0 && timeInDays - (sights[row].TimeTaken * 2) > 0
                        ? evaluationGrid[row - 1, column - (int)(sights[row].TimeTaken * 2)]
                        : 0;

                    evaluationGrid[row, column] = Math.Max(previousRatingMax, currentRating + remainingRating);
                }
            }

            return evaluationGrid[sights.Count - 1, (days * 2) - 1];
        }
    }

    public class Sight
    {
        public string Name{ get; set;}
        public decimal TimeTaken { get; set; }
        public int Rating { get; set; }
    }
}
