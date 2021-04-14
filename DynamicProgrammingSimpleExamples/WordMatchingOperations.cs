using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgrammingSimpleExamples
{
    public static class WordMatchingOperations
    {
        public static string BestSubMatchFrom(this string word, List<string> possibleMatches) =>
            possibleMatches.Aggregate(
                string.Empty, (bestMatch, nextWord) => 
                word.LongestSubstringWith(nextWord) > bestMatch.Length 
                ? nextWord 
                : bestMatch);

        public static string BestSeqMatchFrom(this string word, List<string> possibleMatches) =>
            possibleMatches.Aggregate(
                string.Empty, (bestMatch, nextWord) =>
                word.LongestSubSequenceWith(nextWord) > bestMatch.Length
                ? nextWord
                : bestMatch);

        private static int LongestSubstringWith(this string firstWord, string secondWord)
        {
            var firstWordChars = firstWord.ToCharArray();
            var secondWordChars = secondWord.ToCharArray();
            var evaluationGrid = new int[firstWord.Length, secondWord.Length];
            var longestSubstring = 0;
            
            for(int row = 0; row < firstWord.Count(); row++)
            {
                for(int column = 0; column < secondWord.Count(); column++)
                {
                    if (firstWordChars[row] == secondWordChars[column])
                    {
                        var currentSubstringLength = row - 1 >= 0 && column - 1 >= 0 
                            ? evaluationGrid[row - 1, column - 1] + 1 
                            : 1;

                        evaluationGrid[row, column] = currentSubstringLength;

                        longestSubstring = currentSubstringLength > longestSubstring 
                            ? currentSubstringLength 
                            : longestSubstring;
                    }
                }
            }

            return longestSubstring;
        }

        private static int LongestSubSequenceWith(this string firstWord, string secondWord)
        {
            var firstWordChars = firstWord.ToCharArray();
            var secondWordChars = secondWord.ToCharArray();
            var evaluationGrid = new int[firstWord.Length, secondWord.Length];
            var longestSequence = 0;

            for (int row = 0; row < firstWord.Count(); row++)
            {
                for (int column = 0; column < secondWord.Count(); column++)
                {
                    if (firstWordChars[row] == secondWordChars[column])
                    {
                        var currentSeqLength = row - 1 >= 0 && column - 1 >= 0
                            ? evaluationGrid[row - 1, column - 1] + 1
                            : 1;

                        evaluationGrid[row, column] = currentSeqLength;

                        longestSequence = currentSeqLength;
                    }
                    else
                    {
                        var left = column - 1 >= 0 ? evaluationGrid[row, column - 1] : 0;
                        var above = row - 1 >= 0 ? evaluationGrid[row - 1, column] : 0;
                        evaluationGrid[row, column] = Math.Max(left, above);
                    }
                }
            }

            return longestSequence;
        }
    }
}
