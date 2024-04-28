using System;
using System.Collections.Generic;
using System.Linq;

namespace ApproximationAlgorithmRadioStations
{
    public static class RadioStationSearchOperations
    {
        public static HashSet<string> MimimumToReach(this Dictionary<string, HashSet<string>> radioStations, HashSet<string> requiredStates)
        {
            var requiredRadioStations = new HashSet<string>();

            while (requiredStates.Any())
            {
                string bestMatch = null;
                var bestNumberOfMatches = 0;

                foreach(string stationKey in radioStations.Keys)
                {
                    var numberOfMatches = radioStations[stationKey].Intersect(requiredStates).Count();

                    if (numberOfMatches > bestNumberOfMatches)
                    {
                        bestMatch = stationKey;
                        bestNumberOfMatches = numberOfMatches;
                    }
                }

                requiredRadioStations.Add(bestMatch);
                requiredStates.ExceptWith(radioStations[bestMatch]);
            }

            requiredRadioStations.ToList().ForEach(r => Console.WriteLine($"Radio station {r} is needed"));
            return requiredRadioStations;
        }
    }
}
