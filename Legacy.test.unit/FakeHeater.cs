using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    public class FakeHeater : IHeater
    {
        public int CounterOn { get; set; } = 0;
        public int CounterOff { get; set; } = 0;

        public void TurnOn()
        {
            //System.Console.WriteLine("Heater is on");
            CounterOn++; 
        }

        public void TurnOff()
        {
           // System.Console.WriteLine("Heater is off");
           CounterOff++;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
