using System;

namespace HierarchicalGrouper
{
    public class TreeNode
    {
        public TreeNode FirstNode { get; set; }
        public TreeNode SecondNode { get; set; }
        public TreeNode ParentNode { get; set; }
        public String Name { get; set; }
        public int Value { get; set; }

        public TreeNode(string name, int value)
        {
            FirstNode = null;
            SecondNode = null;
            ParentNode = null;
            Name = name;
            Value = value;
        }

        public TreeNode(string name, int value, TreeNode firstNode, TreeNode secondNode)
        {
            FirstNode = firstNode;
            SecondNode = secondNode;
            ParentNode = null;
            Name = name;
            Value = value;
        }

        public TreeNode(string name, int value, TreeNode firstNode, TreeNode secondNode, TreeNode parentNode)
        {
            FirstNode = firstNode;
            SecondNode = secondNode;
            ParentNode = parentNode;
            Name = name;
            value = value;
        }
    }
}
