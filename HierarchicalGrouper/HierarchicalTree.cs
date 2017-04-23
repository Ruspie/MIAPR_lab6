using System.Collections.Generic;

namespace HierarchicalGrouper
{
    public class HierarchicalTree
    {
        private readonly List<TreeNode> _hierarchicalTree;

        public HierarchicalTree()
        {
            _hierarchicalTree = new List<TreeNode>();
        }

        public int GetCountNodes()
        {
            return _hierarchicalTree.Count;
        }

        public void AddTreeNode(TreeNode treeNode)
        {
            _hierarchicalTree.Add(treeNode);
        }

        private TreeNode GetParenTreeNode(TreeNode treeNode, int startIndex)
        {
            for (var i = startIndex + 1; i < _hierarchicalTree.Count; i++) {
                if (treeNode.FirstNode == null && treeNode.SecondNode == null) {
                    if (_hierarchicalTree[i].FirstNode != null && _hierarchicalTree[i].SecondNode != null)
                        if (_hierarchicalTree[i].FirstNode.Name == treeNode.Name ||
                            _hierarchicalTree[i].SecondNode.Name == treeNode.Name)
                            return _hierarchicalTree[i];
                    continue;
                }
                if (_hierarchicalTree[i].FirstNode?.FirstNode == treeNode.FirstNode &&
                    _hierarchicalTree[i].FirstNode?.SecondNode == treeNode.SecondNode ||
                    _hierarchicalTree[i].SecondNode?.FirstNode == treeNode.FirstNode &&
                    _hierarchicalTree[i].SecondNode?.SecondNode == treeNode.SecondNode)
                    return _hierarchicalTree[i];
            }
            return null;
        }

        public TreeNode GetTreeNode(string nodeName)
        {
            int i;
            for (i = 0; i < _hierarchicalTree.Count; i++) if (_hierarchicalTree[i].Name == nodeName) break;

            return _hierarchicalTree[i];
        }

        public TreeNode GetTreeNode(int index)
        {
            return _hierarchicalTree[index];
        }

        public void SetParentNodeToAllNode()
        {
            for (var i = _hierarchicalTree.Count - 2; i >= 0; i--) {
                var treeNode = _hierarchicalTree[i];
                treeNode.ParentNode = GetParenTreeNode(treeNode, i);
            }
        }
    }
}