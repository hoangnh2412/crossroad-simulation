using CrossroadSimulation.Constants;
using CrossroadSimulation.Objects.Abstractions;

namespace CrossroadSimulation.Objects
{
    public class Road : IRoad
    {
        public Direction Direction => throw new System.NotImplementedException();

        public int StartPosition => throw new System.NotImplementedException();

        public int EndPosition => throw new System.NotImplementedException();

        public int StartCrossroadPosition => throw new System.NotImplementedException();

        public int EndCrossroadPosition => throw new System.NotImplementedException();

        public Road(Direction direction, int startPosition, int endPosition, int startCrossroadPosition, int endCrossroadPosition)
        {
        }
    }
}