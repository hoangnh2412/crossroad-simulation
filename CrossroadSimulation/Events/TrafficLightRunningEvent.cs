using CrossroadSimulation.Constants;

namespace CrossroadSimulation.Events
{
    /// <summary>
    /// Parameter of event TrafficlightRunning
    /// </summary>
    public class TrafficLightRunningEvent
    {
        public string Name { get; set; }
        public TrafficLightColor Color { get; set; }
        public int Countdown { get; set; }
    }
}