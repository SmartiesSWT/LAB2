using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
