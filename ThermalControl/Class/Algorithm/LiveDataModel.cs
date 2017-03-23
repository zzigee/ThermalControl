using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThermalControl
{
    class LiveDataModel
    {
        public MainClass m_MainClass;

        public BindingList<ChartTemp> data;

        private Timer timer;

        private DateTime tmpDateTime = DateTime.MinValue;
        private int count = 0;
        private DateTime lastDate;
        private Random random = new Random();

        private string MessagesPerSecond;
        private string MessagesPerMinute;

        private int tickCountSecond;
        private int tickCountMinute;

        public LiveDataModel(MainClass mc)
        {
            this.m_MainClass = mc;
            
            this.timer = new Timer();
            this.timer.Interval = m_MainClass.m_Define_Class.nLiveChartUpdateSecond;
            this.timer.Tick += this.OnTimer;

            this.FillData();
        }
        
        private void FillData()
        {
            BindingList<ChartTemp> collection = new BindingList<ChartTemp>();
            this.lastDate = DateTime.Now;

            for (int i = 0; i < 150; i++)
            {
                this.lastDate = this.lastDate.AddMilliseconds(200);
                collection.Add(this.CreateBusinessObject());
            }

            this.Data = collection;
        }
        public void StartTimer()
        {
            this.timer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public BindingList<ChartTemp> Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.OnPropertyChanged("Data");
                }
            }
        }
        

        private ChartTemp CreateBusinessObject()
        {
            ChartTemp obj = new ChartTemp();

            //obj.Value = this.random.Next(0, 250);
            obj.Value = m_MainClass.stTempSensor.fCurrentTemp;
            obj.Category = this.lastDate;

            return obj;
        }


        private void OnTimer(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if ((now - tmpDateTime).TotalSeconds > 1)
            {
                tmpDateTime = now;
                count = 0;
            }
            else
            {
                count++;
            }

            this.lastDate = this.lastDate.AddMilliseconds(200);
            this.Data.RemoveAt(0);
            this.Data.Add(this.CreateBusinessObject());
            this.UpdateMetrics();

            // PID TEST 
            //mf.PV = this.CreateBusinessObject().Value;
        }


        private void UpdateMetrics()
        {
            this.tickCountSecond++;
            this.tickCountMinute++;

            if (this.tickCountSecond == 5)
            {
                this.tickCountSecond = 0;
                this.MessagesPerSecond = this.random.Next(800, 1800).ToString("#,#");
            }

            if (this.tickCountMinute == 100)
            {
                this.tickCountMinute = 0;
                this.MessagesPerMinute = this.random.Next(50000, 55000).ToString("#,#");
            }
        }

    }
}
