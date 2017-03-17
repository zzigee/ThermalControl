using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    class ChartTemp
    {
        private double value; 
        private DateTime category;
        public double Value { get { return this.value; } set { this.value = value; } }  
        public DateTime Category { get { return this.category; } set { this.category = value; } } 
    }
}
