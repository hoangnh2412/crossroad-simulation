using CrossroadSimulation.Constants;

namespace CrossroadSimulation.Events
{
    /// <summary>
    /// Parameter of event ChangedColor
    /// </summary>
    public class TrafficLightChangeColorEvent
    {
        public string Name { get; set; }
        public TrafficLightColor Color { get; set; }
    }
}