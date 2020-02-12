using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    public class ECS
    {
        private int _threshold;

        private readonly ITempSensor _tempSensor;         //constructor injection
        private readonly IHeater _heater;                 //constructor injection

       // public ITempSensor _tempSensor { get; set; }        //property injection
       // public IHeater _heater { get; set; }                //property injection

        public ECS(int thr, ITempSensor tempSensor, IHeater heater)
        {
            SetThreshold(thr);

            //tempSensor = new TempSensor();              //property injection
            //heater = new Heater();                      //property injection


            _tempSensor = tempSensor;                //constructor injection
            _heater = heater;                        //constructor injection

            //_tempSensor = new FakeTempSensor();    //Test code
            //_heater = new FakeHeater();            //Test code.

            //_tempSensor = new TempSensor();        //Production code
            //_heater = new Heater();                //Production code
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
