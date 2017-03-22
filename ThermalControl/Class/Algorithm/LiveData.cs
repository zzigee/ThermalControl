using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThermalControl
{
    class LiveData
    {
        public MainForm mf;

        public BindingList<ChartTemp> data;

        private Timer timer;

        private DateTime tmpDateTime = DateTime.MinValue;
        private int count = 0;
        private DateTime lastDate;
        private Random random = new Random();

        private string MessagesPerSecond;
        private string MessagesPerMinute;

        public LiveData(MainForm mf)
        {
            this.mf = mf;

            this.timer = new Timer();
            this.timer.Interval = 1;
            this.timer.Tick += this.OnTimer;

            this.FillData();
            //this.MessagesPerSecond = this.random.Next(5000, 80000).ToString("#,#");
            //this.MessagesPerMinute = this.random.Next(50000, 55000).ToString("#,#");
        
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

            obj.Value = this.random.Next(0, 250);
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

            // PID TEST 
            mf.PV = this.CreateBusinessObject().Value;
        }
    }
}
