using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DynamicProgrammingSimpleExamples.Tests.Unit
{
    [TestFixture]
    public class SightSeeingOperationsTests
    {
        [Test]
        public void Given_PossibleSights_When_TravelTimeIsLimited_Then_CalculatesTheHighestRatedTrip()
        {
            var sights = new List<Sight> 
            { 
                new Sight{ Name = "Westminster Abbey", TimeTaken = 0.5m, Rating = 7 },
                new Sight{ Name = "Globe Theater", TimeTaken = 0.5m, Rating = 6 },
                new Sight{ Name = "National Gallery", TimeTaken = 1m, Rating = 9 },
                new Sight{ Name = "British Museum", TimeTaken = 2m, Rating = 9 },
                new Sight{ Name = "St Pauls Cathdral", TimeTaken = 0.5m, Rating = 8 },
            };

            sights.HighestRatingForDaysOf(2).Should().Be(24);
        }
    }
}
