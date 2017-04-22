using System;

namespace HierarchicalGrouper
{
    class DistanceNode
    {
        public String FirstId { get; set; }
        public String SecondId { get; set; }
        public double Distance { get; set; }

        public DistanceNode(string firstId, string secondId, double distance)
        {
            FirstId = firstId;
            SecondId = secondId;
            Distance = distance;
        }

        public override string ToString()
        {
            return FirstId + " -> " + SecondId + " = " + Distance;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            DistanceNode distanceNode = obj as DistanceNode;
            if (distanceNode == null) return false;
            if (CrossEquals((DistanceNode) obj))
                return true;
            return false;
        }

        public bool Equals(DistanceNode other)
        {
            return string.Equals(FirstId, other.FirstId) ||
                   string.Equals(SecondId, other.SecondId) ||
                   string.Equals(FirstId, other.SecondId)||
                   string.Equals(SecondId, other.FirstId);
        }

        public bool CrossEquals(DistanceNode other) => FirstId == other.FirstId && SecondId == other.SecondId ||
                                                       FirstId == other.SecondId && SecondId == other.FirstId;

        public override int GetHashCode()
        {
            unchecked {
                var hashCode = FirstId != null ? FirstId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (SecondId != null ? SecondId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)Distance;
                return hashCode;
            }
        }

        public string ReplaceId(DistanceNode minimalDistanceNode, char id) =>
            FirstId == minimalDistanceNode.FirstId || FirstId == minimalDistanceNode.SecondId
                ? FirstId = id.ToString()
                : SecondId = id.ToString();
    }
}
