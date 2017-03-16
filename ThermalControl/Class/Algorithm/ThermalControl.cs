using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    internal class ThermalControl : TimerClass
    {
        private readonly MainClass m_MainClass;

        public ThermalControl(MainClass mc, int timer_interval)
        {
            this.m_MainClass = mc;
            this.Start(timer_interval, "ThermalControl");
        }

        /**
         * 주기적으로 실행하는 함수 
         **/
        public override void Run()
        {
            this.m_MainClass.m_SystemLogClass.SystemLog(this, "ThermalModelClassTimer");
        }
    }
}
