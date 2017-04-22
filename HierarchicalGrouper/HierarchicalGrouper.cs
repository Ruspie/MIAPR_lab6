namespace HierarchicalGrouper
{
    public class HierarchicalGrouper
    {
        private char _id;

        public HierarchicalTree GetHierarchucalTree(double[][] distances)
        {
            _id = 'a';

            var hierarchicalTree = new HierarchicalTree();

            var distancesList = new Distances(distances);

            for (int i = 0; i < distances.Length; i++) {
                TreeNode treeNode = new TreeNode("x" + (i + 1), 0);
                hierarchicalTree.AddTreeNode(treeNode);
            }

            while (distancesList.GetCount() > 0) {
                var minimalDistanceNode = distancesList.GetMinimalDistanceNode();
                distancesList.DeleteDistance(minimalDistanceNode);

                distancesList.RenameNodesInDistancesList(minimalDistanceNode, _id);

                TreeNode treeNode = new TreeNode(_id.ToString(), minimalDistanceNode.Distance,
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
