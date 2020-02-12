using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    internal class FakeTempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return number;
        }

        public int number { get; set; }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}