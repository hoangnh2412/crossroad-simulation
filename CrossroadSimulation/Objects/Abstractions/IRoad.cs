using CrossroadSimulation.Constants;

namespace CrossroadSimulation.Objects.Abstractions
{
    public interface IRoad
    {
        /// <summary>
        /// Direction of Road
        /// </summary>
        /// <value></value>
        Direction Direction { get; }

        /// <summary>
        /// Start position of Road on simulation
        /// </summary>
        /// <value></value>
        int StartPosition { get; }

        /// <summary>
        /// Start position of Road on simulation
        /// </summary>
        /// <value></value>
        int EndPosition { get; }

        /// <summary>
        /// Start crossroad position of Road on simulation
        /// </summary>
        /// <value></value>
        int StartCrossroadPosition { get; }

        /// <summary>
        /// End crossroad position of Road on simulation
        /// </summary>
        /// <value></value>
        int EndCrossroadPosition { get; }
    }
}