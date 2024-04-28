using NUnit.Framework;
using System.Collections.Generic;

namespace DynamicProgrammingSimpleExamples.Tests.Unit
{
    [TestFixture]
    public class WordMatchingOperationsTests
    {
        [Test]
        public void Given_Hish_When_NumerousPossibleMatches_Then_PicksTheBestMatch()
        {
            var possibleMatches = new List<string> { "fish", "vista" };

            Assert.AreEqual("fish", "hish".BestSubMatchFrom(possibleMatches));
        }

        [Test]
        public void Given_Fosh_When_NumerousPossibleMatches_Then_PicksTheBestMatch()
        {
            var possibleMatches = new List<string> { "fish", "fort" };

            Assert.AreEqual("fish", "fosh".BestSeqMatchFrom(possibleMatches));
        }
    }
}
