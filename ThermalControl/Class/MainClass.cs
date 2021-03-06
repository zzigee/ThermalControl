﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalControl
{
    
    internal class MainClass
    {
        public MainForm m_MainForm;
        public SystemLogClass m_SystemLogClass;   // 로그관리
        public DefineClass m_Define_Class;  // 사전정의
        public UtilsClass m_UtilsClass;

        public ThermalControl m_ThermalControl;
        public TCPClass m_TCPClass;

        public LiveDataModel m_LiveDataModel;

        public DefineClass.ST_TEMP_SENSOR stTempSensor;
        public DefineClass.ST_MFC_CONTROLLER stMfcController;
        public DefineClass.ST_PID_GAIN stPIDGain;

        public PID m_PidClass;

        public MainClass(MainForm mf)
        {
            // Current MainForm Ojbect (for Handling GUI)
            this.m_MainForm = mf;

            this.m_SystemLogClass = new SystemLogClass(this);
            this.m_Define_Class = new DefineClass(this);
            this.m_UtilsClass = new UtilsClass(this);

            this.m_LiveDataModel = new LiveDataModel(this);

            this.m_TCPClass = new TCPClass(this, (int)DefineClass.TIMER_INTERVAL.TEN_SEC);
            this.m_ThermalControl = new ThermalControl(this, (int)DefineClass.TIMER_INTERVAL.TEN_SEC);

            stTempSensor = new DefineClass.ST_TEMP_SENSOR();
            stMfcController = new DefineClass.ST_MFC_CONTROLLER();
            stPIDGain = new DefineClass.ST_PID_GAIN();
        }
    }
}
