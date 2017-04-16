using System.Collections;
using System.Collections.Generic;

namespace HierarchicalGrouper
{
    class Distances : IEnumerable
    {
        private readonly List<DistanceNode> _distancesList;

        public Distances()
        {
            _distancesList = new List<DistanceNode>();
        }

        public Distances(int[][] distances)
        {
            _distancesList = new List<DistanceNode>();
            InitializeDistances(distances);
        }

        public void AddDistance(DistanceNode distanceNode)
        {
            _distancesList.Add(distanceNode);
        }

        public void DeleteDistance(DistanceNode distanceNode)
        {
            _distancesList.Remove(distanceNode);
        }

        private void InitializeDistances(int[][] distances)
        {
            for (int i = 0; i < distances.Length - 1; i++) {
                for (int j = i + 1; j < distances[i].Length; j++) {
                    _distancesList.Add(new DistanceNode("x" + (i + 1), "x" + (j + 1),
                        distances[i][j]));
                }
            }
            foreach (var distanceNode in _distancesList) {
                System.Console.WriteLine(distanceNode.ToString());
            }
        }

        public int GetCount()
        {
            return _distancesList.Count;
        }

        public DistanceNode GetMinimalDistanceNode()
        {
            DistanceNode resultNode = _distancesList[0];
            foreach (var distanceNode in _distancesList) {
                if (distanceNode.Distance > resultNode.Distance) {
                    resultNode = distanceNode;
                }
            }
            return resultNode;
        }

        public IEnumerator GetEnumerator()
        {
            return _distancesList.GetEnumerator();
        }
    }
}
