using System;

namespace Legacy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var ecs = new ECS(28); 

            var ecs = new ECS(28, new TempSensor(), new Heater());      //Constructor injection

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            
        }
    }
}
