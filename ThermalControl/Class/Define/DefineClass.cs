using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    class DefineClass
    {

        public MainClass m_MainClass;
        
        public DefineClass(MainClass mc)
        {
            this.m_MainClass = mc;
        }

        public enum TIMER_INTERVAL
        {
            ONE_SEC = 1000,
            TWO_SEC = ONE_SEC * 2,
            THREE_SEC = ONE_SEC * 3,
            FOUR_SEC = ONE_SEC * 4,
            FIVE_SEC = ONE_SEC * 5,
            TEN_SEC = 10000,
            TWENTY_SEC = TEN_SEC * 2,
            THIRTY_SEC = TEN_SEC * 3,
            FORTY_SEC = TEN_SEC * 4,
            FIFTY_SEC = TEN_SEC * 5
        }

    }
}
