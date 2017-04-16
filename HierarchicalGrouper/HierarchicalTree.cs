using System.Collections.Generic;

namespace HierarchicalGrouper
{
    public class HierarchicalTree
    {
        public List<TreeNode> getHierarchucalTree(int[][] distances)
        {
            List<TreeNode> hierarchicalTree = new List<TreeNode>();

            Distances distancesList = new Distances(distances);

            while (distancesList.GetCount() > 0) {
                DistanceNode minimalDistanceNode = distancesList.GetMinimalDistanceNode();
                distancesList.DeleteDistance(minimalDistanceNode); 
                Distances TempDistances = GenerateTempDistancesList(distancesList, minimalDistanceNode);
            }

            return hierarchicalTree;
        }

        private Distances GenerateTempDistancesList(Distances distances, DistanceNode minimalDistanceNode)
        {
            Distances resultDistances = new Distances();

            foreach (DistanceNode distance in distances) {
                if (distance == minimalDistanceNode) {
                    resultDistances.AddDistance(distance);
                    distances.DeleteDistance(distance);
                }
            }

            return resultDistances;
        }
    }
}
