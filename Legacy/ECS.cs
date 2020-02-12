using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public ECS(int thr)
        {
            SetThreshold(thr);
            _tempSensor = new FakeTempSensor(); //Test code
            _heater = new FakeHeater();         //Test code.

            //_tempSensor = new TempSensor(); //Production code
            //_heater = new Heater();         //Production code
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
