using System;

namespace HierarchicalGrouper
{
    class DistanceNode
    {
        public String FirstNodeName { get; set; }
        public String SecondNodeName { get; set; }
        public int Distance { get; set; }

        public DistanceNode(string firstNodeName, string secondNodeName, int distance)
        {
            FirstNodeName = firstNodeName;
            SecondNodeName = secondNodeName;
            Distance = distance;
        }

        public override string ToString()
        {
            return FirstNodeName + " -> " + SecondNodeName + " = " + Distance;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            DistanceNode distanceNode = obj as DistanceNode;
            if (distanceNode == null) return false;
            if (FirstNodeName == distanceNode.FirstNodeName &&
                SecondNodeName == distanceNode.SecondNodeName && Distance == distanceNode.Distance)
                return true;
            return false;
        }

        protected bool Equals(DistanceNode other)
        {
            return string.Equals(FirstNodeName, other.FirstNodeName) ||
                   string.Equals(SecondNodeName, other.SecondNodeName);
        }

        public override int GetHashCode()
        {
            unchecked {
                var hashCode = (FirstNodeName != null ? FirstNodeName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SecondNodeName != null ? SecondNodeName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Distance;
                return hashCode;
            }
        }
    }
}
