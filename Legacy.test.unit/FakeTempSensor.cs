using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    internal class FakeTempSensor : ITempSensor
    {
        private Random gen = new Random();
        public int Number { get; set; }

        public int GetTemp()
        {
            return Number;
        }

        

        public bool RunSelfTest()
        {
            return true;
        }
    }
}