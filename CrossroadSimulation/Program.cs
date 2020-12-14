using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrossroadSimulation.Constants;
using CrossroadSimulation.Objects;

namespace CrossroadSimulation
{
    class Program
    {
        /// <summary>
        /// Fake countdown of color Reen and Red
        /// </summary>
        /// <value></value>
        private static Dictionary<TrafficLightColor, int> Colors = new Dictionary<TrafficLightColor, int> {
            { TrafficLightColor.Red, 10 },
            { TrafficLightColor.Green, 10 }
        };

        /// <summary>
        /// Fake car run on East
        /// </summary>
        private static int CarsOfEast = 0;

        /// <summary>
        /// Fake car run on West
        /// </summary>
        private static int CarsOfWest = 0;

        /// <summary>
        /// Fake car run on North
        /// </summary>
        private static int CarsOfNorth = 0;

        /// <summary>
        /// Fake car run on South
        /// </summary>
        private static int CarsOfSouth = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SimulationAsync().GetAwaiter().GetResult();

            Console.WriteLine("Done");
        }

        private static async Task SimulationAsync()
        {
            var crossroad = new Crossroad();

            //Add trafficlights to simulation
            crossroad.AddTrafficLight(Direction.East, $"TrafficLight {Direction.East}", TrafficLightColor.Green, Colors);
            crossroad.AddTrafficLight(Direction.West, $"TrafficLight {Direction.West}", TrafficLightColor.Green, Colors);
            crossroad.AddTrafficLight(Direction.North, $"TrafficLight {Direction.North}", TrafficLightColor.Red, Colors);
            crossroad.AddTrafficLight(Direction.South, $"TrafficLight {Direction.South}", TrafficLightColor.Red, Colors);

            //Add roads to simulation
            crossroad.AddRoad(Direction.North, 0, 130, 50, 80);
            crossroad.AddRoad(Direction.South, 0, 130, 50, 80);
            crossroad.AddRoad(Direction.West, 0, 130, 50, 80);
            crossroad.AddRoad(Direction.East, 0, 130, 50, 80);

            Console.WriteLine("===================== Start simulation =====================");

            var tasks = new List<Task>();

            //Run traffilights
            foreach (var light in crossroad.TrafficLights)
            {
                tasks.Add(light.Value.RunAsync());
            }

            //Create car and run
            tasks.Add(Task.Run(async () =>
            {
                int index = 0;
                while (index < CarsOfEast)
                {
                    index++;
                    crossroad.AddCar(Direction.East, $"Car {Direction.East}-{index}", 10);
                    await Task.Delay(500);
                }
            }));
            tasks.Add(Task.Run(async () =>
            {
                int index = 0;
                while (index < CarsOfWest)
                {
                    index++;
                    crossroad.AddCar(Direction.West, $"Car {Direction.West}-{index}", 10);
                    await Task.Delay(500);
                }
            }));
            tasks.Add(Task.Run(async () =>
            {
                int index = 0;
                while (index < CarsOfNorth)
                {
                    index++;
                    crossroad.AddCar(Direction.North, $"Car {Direction.North}-{index}", 10);
                    await Task.Delay(500);
                }
            }));
            tasks.Add(Task.Run(async () =>
            {
                int index = 0;
                while (index < CarsOfSouth)
                {
                    index++;
                    crossroad.AddCar(Direction.South, $"Car {Direction.South}-{index}", 10);
                    await Task.Delay(500);
                }
            }));

            await Task.WhenAll(tasks);
        }
    }
}
