using System;
using System.Collections;
using System.Collections.Generic;

namespace HierarchicalGrouper
{
    internal class Distances : IEnumerable
    {
        private readonly List<DistanceNode> _distancesList;

        public Distances(double[][] distances)
        {
            _distancesList = new List<DistanceNode>();
            InitializeDistances(distances);
        }

        public IEnumerator GetEnumerator()
        {
            return _distancesList.GetEnumerator();
        }

        public void DeleteDistance(DistanceNode distanceNode)
        {
            var count = GetCountDistance(distanceNode);
            for (var i = 0; i < count; i++) _distancesList.Remove(distanceNode);
        }

        private void InitializeDistances(double[][] distances)
        {
            for (var i = 0; i < distances.Length - 1; i++)
            for (var j = i + 1; j < distances[i].Length; j++)
                _distancesList.Add(new DistanceNode("x" + (i + 1), "x" + (j + 1),
                    distances[i][j]));
        }

        public int GetCount()
        {
            return _distancesList.Count;
        }

        public DistanceNode GetMinimalDistanceNode()
        {
            var resultNode = _distancesList[0];
            foreach (var distanceNode in _distancesList)
                if (distanceNode.Distance < resultNode.Distance) resultNode = distanceNode;
            return resultNode;
        }

        private int GetCountDistance(DistanceNode distanceNode)
        {
            var count = 0;
            foreach (var node in _distancesList) if (node.CrossEquals(distanceNode)) count++;
            return count;
        }

        public void RenameNodesInDistancesList(DistanceNode minimalDistanceNode, char id)
        {
            foreach (DistanceNode distance in _distancesList)
                if (distance.Equals(minimalDistanceNode))
                    distance.ReplaceId(minimalDistanceNode, id);
        }
    }
}