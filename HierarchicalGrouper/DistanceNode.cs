namespace HierarchicalGrouper
{
    internal class DistanceNode
    {
        public DistanceNode(string firstId, string secondId, int distance)
        {
            FirstId = firstId;
            SecondId = secondId;
            Distance = distance;
        }

        public string FirstId { get; private set; }
        public string SecondId { get; private set; }
        public int Distance { get; }

        public override string ToString()
        {
            return FirstId + " -> " + SecondId + " = " + Distance;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            var distanceNode = obj as DistanceNode;
            if (distanceNode == null) return false;
            if (CrossEquals((DistanceNode) obj))
                return true;
            return false;
        }

        public bool Equals(DistanceNode other)
        {
            return string.Equals(FirstId, other.FirstId) ||
                   string.Equals(SecondId, other.SecondId) ||
                   string.Equals(FirstId, other.SecondId) ||
                   string.Equals(SecondId, other.FirstId);
        }

        public bool CrossEquals(DistanceNode other)
        {
            return FirstId == other.FirstId && SecondId == other.SecondId ||
                   FirstId == other.SecondId && SecondId == other.FirstId;
        }

        public override int GetHashCode()
        {
            unchecked {
                var hashCode = FirstId != null ? FirstId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (SecondId != null ? SecondId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Distance;
                return hashCode;
            }
        }

        public string ReplaceId(DistanceNode minimalDistanceNode, char id)
        {
            return FirstId == minimalDistanceNode.FirstId || FirstId == minimalDistanceNode.SecondId
                ? FirstId = id.ToString()
                : SecondId = id.ToString();
        }
    }
}