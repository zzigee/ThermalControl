using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    class UtilsClass
    {
        private readonly MainClass m_MainClass;

        public UtilsClass(MainClass mc)
        {
            this.m_MainClass = mc;
        }

        static public String getCurrentTime()
        {
            return System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }

        static public String getCurrentTimeMS()
        {
            return System.DateTime.Now.ToString("fff");
        }

        public void printMsg()
        {
            Console.WriteLine("Class of Utils");
        }
    }
}
