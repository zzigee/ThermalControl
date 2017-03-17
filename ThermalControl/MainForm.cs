using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ThermalControl
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {

        private MainClass m_MainClass;

        LiveData model = new LiveData(); 
        Font font = new Font("온도제어", 12F, System.Drawing.FontStyle.Regular); 


        public MainForm()
        {
            InitializeComponent();


            // 메인클래스 객체 생성
            this.m_MainClass = new MainClass(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            model.StartTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_MainClass.m_TCPClass.StartClient();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void radialGaugeNeedle1_Click(object sender, EventArgs e)
        {

        }

        private void radRadialGauge1_Click(object sender, EventArgs e)
        {

        }

        private void radRadialGauge1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radChartView1_Click(object sender, EventArgs e)
        {

        }

        private void radChartView1_Initialized(object sender, EventArgs e)
        {
            
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.ForeColor = Color.FromArgb(235, 235, 235);
            grid.DrawVerticalStripes = false;
            grid.DrawHorizontalStripes = true;
            grid.DrawHorizontalFills = false;
            grid.DrawVerticalFills = false;
            area.ShowGrid = true;

            LineSeries lineSeries;
            lineSeries = new LineSeries(); 
            lineSeries.BorderColor = Color.FromArgb(142, 196, 65);   
            

            lineSeries.PointSize = new SizeF(0, 0);
            lineSeries.CategoryMember = "Category";
            lineSeries.ValueMember = "Value";
            lineSeries.DataSource = model.Data;
            lineSeries.BorderWidth = 2;

            this.radChartView1.Series.Add(lineSeries);

            this.radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.radChartView1.ChartElement.TitleElement.Margin = new Padding(10, 10, 0, 0);
            this.radChartView1.View.Margin = new Padding(10, 0, 35, 0);

            LinearAxis axeY = radChartView1.Axes.Get<LinearAxis>(1);
            axeY.Minimum = 50;
            axeY.Maximum = 300;
            axeY.MajorStep = 30;

            CategoricalAxis axeX = radChartView1.Axes.Get<CategoricalAxis>(0);
            axeX.ClipLabels = false;
            axeX.LabelInterval = 50;
            axeX.LabelFormat = "{0:HH:mm:ss.f}";
            

        }
    }
}
