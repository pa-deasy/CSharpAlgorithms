using System.Collections.Generic;
using System.Linq;

namespace DijkstrasAlgorithmSimpleExample
{
    public static class SearchOperations
    {
        public static Dictionary<string, Vertice> QuickestPath(this Dictionary<string, Dictionary<string, int>> graph)
        {
            var graphVertices = new Dictionary<string, Vertice>();

            var startingVerticesKeys = graph["START"].Keys;
            startingVerticesKeys.ToList().ForEach(k => graphVertices.Add(k, new Vertice { Parent = "START", QuickestPath = graph["START"][k], Processed = false }));

            while (graphVertices.GetQuickestUnprocessedVertice() != "FIN")
            {
                var quickestKey = graphVertices.GetQuickestUnprocessedVertice();
                var cost = graphVertices[quickestKey].QuickestPath;
                var neighbors = graph[quickestKey];

                foreach(string neighborKey in neighbors.Keys)
                {
                    var newCost = cost + neighbors[neighborKey];

                    if (!graphVertices.ContainsKey(neighborKey))
                    {
                        graphVertices.Add(neighborKey, new Vertice { Parent = quickestKey, QuickestPath = newCost, Processed = false });
                        continue;
                    }

                    if (newCost < graphVertices[neighborKey].QuickestPath)
                    {
                        graphVertices[neighborKey].QuickestPath = newCost;
                        graphVertices[neighborKey].Parent = quickestKey;
                    }
                }
                graphVertices[quickestKey].Processed = true;
            }

            return graphVertices;
        }

        private static string GetQuickestUnprocessedVertice(this Dictionary<string, Vertice> graphVertices)
        {
            var quickest = string.Empty;
            foreach(string verticeKey in graphVertices.Keys)
            {
                if (graphVertices[verticeKey].Processed)
                    continue;

                if(quickest == string.Empty)
                {
                    quickest = verticeKey;
                    continue;
                }

                if (graphVertices[verticeKey].QuickestPath < graphVertices[quickest].QuickestPath)
                    quickest = verticeKey;
            }

            return quickest;
        }

        public static string Format(this Dictionary<string, Vertice> graphvertices)
        {
            var vertice = "FIN";
            var formatted = "FIN";

            while (graphvertices.ContainsKey(vertice))
            {
                var parent = graphvertices[vertice].Parent;

                formatted = parent + " -> " + formatted;
                vertice = parent;
            }

            return formatted;
        }
    }
}
