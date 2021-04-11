using NUnit.Framework;
using System.Collections.Generic;

namespace DijkstrasAlgorithmSimpleExample.Tests.Unit
{
    [TestFixture]
    public class SearchOperationsTests
    {
        [Test]
        public void Given_Graph_When_PathToFinishExists_Then_Returns_Quickest()
        {
            var quickestPath = TravelGraph.QuickestPath();
            Assert.AreEqual(6, quickestPath["FIN"].QuickestPath);
            Assert.AreEqual("A", quickestPath["FIN"].Parent);
        }

        [Test]
        public void Given_TradeGraph_When_PathToFinishExists_Then_Returns_QuickestTrade()
        {
            var quickestTrade = TradeGraph.QuickestPath();
            Assert.AreEqual(35, quickestTrade["FIN"].QuickestPath);
            Assert.AreEqual("DRUM", quickestTrade["FIN"].Parent);
        }

        [Test]
        public void Given_FastestPath_When_Formatted_Then_PrintsSuccessfully()
        {
            Assert.AreEqual("START -> B -> A -> FIN", TravelGraph.QuickestPath().Format());

            Assert.AreEqual("START -> LP -> DRUM -> FIN", TradeGraph.QuickestPath().Format());
        }

        private Dictionary<string, Dictionary<string, int>> TravelGraph =>
            new Dictionary<string, Dictionary<string, int>>
            {
                { "START", new Dictionary<string, int> { { "A", 6 }, { "B", 2 } } },
                { "A", new Dictionary<string, int> { { "FIN", 1 } } },
                { "B", new Dictionary<string, int> { { "A", 3 }, { "FIN", 5 } } }
            };

        private Dictionary<string, Dictionary<string, int>> TradeGraph =>
            new Dictionary<string, Dictionary<string, int>>
            {
                { "START", new Dictionary<string, int>{ { "LP", 5 }, { "POSTER", 0 } } },
                { "LP", new Dictionary<string, int>{ { "GUITAR", 15 }, { "DRUM", 20 } } },
                { "POSTER", new Dictionary<string, int>{ { "GUITAR", 30 }, { "DRUM", 35 } } },
                { "GUITAR", new Dictionary<string, int>{ { "FIN", 20 } } },
                { "DRUM", new Dictionary<string, int>{ { "FIN", 10 } } }
            };
    }
}
