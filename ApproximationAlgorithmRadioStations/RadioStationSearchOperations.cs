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
                var bestNumberofMatches = radioStations.Max(r => r.Value.Intersect(requiredStates).Count());
                var bestMatch = radioStations.First(r => r.Value.Intersect(requiredStates).Count() == bestNumberofMatches).Key;

                requiredRadioStations.Add(bestMatch);
                requiredStates.ExceptWith(radioStations[bestMatch]);
            }

            requiredRadioStations.ToList().ForEach(r => Console.WriteLine($"Radio station {r} is needed"));
            return requiredRadioStations;
        }
    }
}
