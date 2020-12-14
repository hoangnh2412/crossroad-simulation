using System;

namespace CrossroadSimulation.Events
{
    /// <summary>
    /// Parameter of event CarStarted
    /// </summary>
    public class CarStartedEvent : EventArgs
    {
        public int Distance { get; set; }
        public bool IsRunning { get; set; }
    }
}