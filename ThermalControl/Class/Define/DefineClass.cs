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

        public string strSensorBoardIP = "192.168.0.115";
        public int nSensorBoardPort = 5555;



        
        
        
        public int nLiveChartUpdateSecond = 1000;           // Live Chart Update Period (second)
       
        
        
        public bool isAutoRun = false;




        // Temp Sensor Board Parameters 
        public bool isConTempSensor = false;    // Temp Sensor Connection Flag 


        // MFC Parameters 
        public bool isMFC_Con = false;           // MFC Connection Flag 
        public bool isMFC_Digit_Mode = false;   // Digital Model Flag 
        public bool isMFC_Valve_Open = false;

        public string MFC_Serial_Port_Name = "COM5";
        public int MFC_Serial_BaudRate = 38400;


        public struct ST_PID_GAIN
        {
            public double kp;
            public double ki;
            public double kd;

            // Input Temperature
            public double inputMax;     
            public double inputMin;

            // Output MFC Flow 
            public double outMax;
            public double outMin;
            
            public double PV;       // Measured Value (Current Temperature)
            public double SP;       // Set-Point Value (Target Temperature)
            public double OV;       // Output Value (Target Flow)
        }

        


        public struct ST_TEMP_SENSOR
        {
            public float fCurrentTemp;
            public float fTargetTemp;
        }

        public struct ST_MFC_CONTROLLER
        {
            public float fCurrentFlow;
            public float fTargetFlow;
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

        public enum DMFC_PROTOCOL
        {
            NULL = 0x00, SOH  = 0x01, STX  = 0x02, ETX  = 0x03, EOT  = 0x04, ENQ  = 0x05, ACK  = 0x06, 
            BELL = 0x07, BS   = 0x08, TAB  = 0x09, LF   = 0x0A, VT   = 0x0B, FF   = 0x0C, CR   = 0x0D, SO   = 0x0E, SI   = 0x0F, DLE  = 0x00, DC1  = 0x01, DC2  = 0x02, DC3  = 0x03, 
            DC4  = 0x04, NAK  = 0x05, SYN  = 0x06, ETB  = 0x07, CAN  = 0x08, EM   = 0x09, SUB  = 0x0A, FSC  = 0x0B, FS   = 0x0C, GS   = 0x0D, RS   = 0x0E, US   = 0x0F, 
            A	 = 0x41, B	 = 0x42, C	 = 0x43, D	 = 0x44, E	 = 0x45, F	 = 0x46, G	 = 0x47, H	 = 0x48, I	 = 0x49, J	 = 0x4A, K	 = 0x4B, L	 = 0x4C, 
            M	 = 0x4D, N	 = 0x4E, O	 = 0x4F, P	 = 0x50, Q	 = 0x51, R	 = 0x52, S	 = 0x53, T	 = 0x54, U	 = 0x55, V	 = 0x56, W	 = 0x57, X	 = 0x58, Y	 = 0x59, Z	 = 0x5A, 
            a	 = 0x61, b	 = 0x62, c	 = 0x63, d	 = 0x64, e	 = 0x65, f	 = 0x66, g	 = 0x67, h	 = 0x68, i	 = 0x69, j	 = 0x6A, k	 = 0x6B, l	 = 0x6C, m	 = 0x6D, n	 = 0x6E, o	 = 0x6F, 
            p	 = 0x70, q	 = 0x71, r    = 0x72, s	 = 0x73, t	 = 0x74, u	 = 0x75, v	 = 0x76, w	 = 0x77, x	 = 0x78, y	 = 0x79, z	 = 0x7A, 
            zero = 0x30,
            one = 0x31,
            two = 0x32,
            three = 0x33,
            four = 0x34,
            five = 0x35,
            six = 0x36,
            seven = 0x37,
            eight = 0x38,
            nine = 0x39
        }

    }
}
