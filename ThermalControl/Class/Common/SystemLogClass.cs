using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    class SystemLogClass
    {
        private readonly MainClass m_MainClass;

        public String strClassName;

        public SystemLogClass(MainClass mc)
        {
            this.m_MainClass = mc;
            strClassName = "SysLogClass";
        }



        public void SystemLog(Object obj, string msg)
        {
                Console.WriteLine(string.Format("[{0}] DebugLog Message[{1}]: [ {2} ]", UtilsClass.getCurrentTime(), obj.ToString(), msg));
                    }

    }
}
