namespace HierarchicalGrouper
{
    public class TreeNode
    {
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

        public TreeNode FirstNode { get; }
        public TreeNode SecondNode { get; }
        public TreeNode ParentNode { get; set; }
        public string Name { get; }
        public int Value { get; }

        public override string ToString()
        {
            return "(" + FirstNode?.Name + " - " + SecondNode?.Name + ")" + " = " + Name + "(" + Value + ")" + " -> " +
                   ParentNode?.Name;
        }
    }
}