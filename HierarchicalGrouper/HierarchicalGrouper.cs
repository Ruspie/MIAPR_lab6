namespace HierarchicalGrouper
{
    public class HierarchicalGrouper
    {
        private char _id;

        public HierarchicalTree GetHierarchucalTree(int[][] distances)
        {
            _id = 'a';

            var hierarchicalTree = new HierarchicalTree();

            var distancesList = new Distances(distances);

            for (var i = 0; i < distances.Length; i++) {
                var treeNode = new TreeNode("x" + (i + 1), 0);
                hierarchicalTree.AddTreeNode(treeNode);
            }

            while (distancesList.GetCount() > 0) {
                var minimalDistanceNode = distancesList.GetMinimalDistanceNode();
                distancesList.DeleteDistance(minimalDistanceNode);

                distancesList.RenameNodesInDistancesList(minimalDistanceNode, _id);

                var treeNode = new TreeNode(_id.ToString(), minimalDistanceNode.Distance,
                    hierarchicalTree.GetTreeNode(minimalDistanceNode.FirstId),
                    hierarchicalTree.GetTreeNode(minimalDistanceNode.SecondId));

                hierarchicalTree.AddTreeNode(treeNode);

                _id++;
            }

            hierarchicalTree.SetParentNodeToAllNode();

            return hierarchicalTree;
        }
    }
}