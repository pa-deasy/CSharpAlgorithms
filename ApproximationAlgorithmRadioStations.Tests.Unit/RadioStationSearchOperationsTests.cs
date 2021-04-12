using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ApproximationAlgorithmRadioStations.Tests.Unit
{
    [TestFixture]
    public class RadioStationSearchOperationsTests
    {
        [Test]
        public void Given_RadioStations_When_SearchedForRequiredStates_Then_ReturnsNeededStations()
        {
            var requiredStates = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            var minimumStations = Stations.MimimumToReach(requiredStates);

            Assert.AreEqual(4, minimumStations.Count);
            Assert.Contains("kone", minimumStations.ToList());
            Assert.Contains("ktwo", minimumStations.ToList());
            Assert.Contains("kthree", minimumStations.ToList());
            Assert.Contains("kfive", minimumStations.ToList());
        }

        private Dictionary<string, HashSet<string>> Stations =>
            new Dictionary<string, HashSet<string>> 
            {
                { "kone", new HashSet<string>{ "id", "nv", "ut" } },
                { "ktwo", new HashSet<string>{ "wa", "id", "mt" } },
                { "kthree", new HashSet<string>{ "or", "nv", "ca" } },
                { "kfour", new HashSet<string>{ "nv", "ut" } },
                { "kfive", new HashSet<string>{ "ca", "az" } }
            };
    }
}
