namespace ThermalControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.AreaSeries areaSeries1 = new Telerik.WinControls.UI.AreaSeries();
            this.radRadialGauge1 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks1 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks2 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks3 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks4 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels1 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeLabels2 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle2 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle1 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLinearGauge1 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar1 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeLine2 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks1 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeTicks2 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks3 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine3 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks4 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeNeedleIndicator1 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTrackBar2 = new Telerik.WinControls.UI.RadTrackBar();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.tbCurrentFlow = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tbSetFlow = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnValveOff = new Telerik.WinControls.UI.RadButton();
            this.btnValveStart = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbGain_Output_Min = new Telerik.WinControls.UI.RadTextBox();
            this.tbGain_Output_Max = new Telerik.WinControls.UI.RadTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbGain_Input_Min = new Telerik.WinControls.UI.RadTextBox();
            this.tbGain_Input_Max = new Telerik.WinControls.UI.RadTextBox();
            this.tbGain_D = new Telerik.WinControls.UI.RadTextBox();
            this.tbGain_I = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.tbGain_P = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnAutoRun = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.tbCurrentTemp = new Telerik.WinControls.UI.RadTextBox();
            this.lbCurrentTemp = new Telerik.WinControls.UI.RadLabel();
            this.tbSetTemp = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.btnTCPStart = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.radChartView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValveOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValveStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Output_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Output_Max)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Input_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Input_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutoRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTCPStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRadialGauge1
            // 
            this.radRadialGauge1.BackColor = System.Drawing.Color.White;
            this.radRadialGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRadialGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeTicks1,
            this.radialGaugeTicks2,
            this.radialGaugeTicks3,
            this.radialGaugeTicks4,
            this.radialGaugeLabels1,
            this.radialGaugeLabels2,
            this.radialGaugeNeedle2,
            this.radialGaugeNeedle1});
            this.radRadialGauge1.Location = new System.Drawing.Point(3, 28);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.RangeEnd = 180D;
            this.radRadialGauge1.Size = new System.Drawing.Size(206, 182);
            this.radRadialGauge1.TabIndex = 1;
            this.radRadialGauge1.Text = "radRadialGauge2";
            this.radRadialGauge1.ThemeName = "ControlDefault";
            this.radRadialGauge1.Value = 0F;
            // 
            // radialGaugeArc1
            // 
            this.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc1.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc1.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc1.Name = "radialGaugeArc1";
            this.radialGaugeArc1.RangeEnd = 120D;
            this.radialGaugeArc1.Text = "radialGaugeArc1";
            this.radialGaugeArc1.Width = 1D;
            // 
            // radialGaugeArc2
            // 
            this.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeArc2.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc2.Name = "radialGaugeArc2";
            this.radialGaugeArc2.RangeEnd = 180D;
            this.radialGaugeArc2.RangeStart = 120D;
            this.radialGaugeArc2.Text = "radialGaugeArc2";
            this.radialGaugeArc2.Width = 1D;
            // 
            // radialGaugeTicks1
            // 
            this.radialGaugeTicks1.DrawText = false;
            this.radialGaugeTicks1.Name = "radialGaugeTicks1";
            this.radialGaugeTicks1.Text = "radialGaugeTicks1";
            this.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks1.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks1.TicksCount = 18;
            this.radialGaugeTicks1.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks1.TickThickness = 1F;
            // 
            // radialGaugeTicks2
            // 
            this.radialGaugeTicks2.DrawText = false;
            this.radialGaugeTicks2.Name = "radialGaugeTicks2";
            this.radialGaugeTicks2.Text = "radialGaugeTicks2";
            this.radialGaugeTicks2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks2.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks2.TicksCount = 54;
            this.radialGaugeTicks2.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks2.TickThickness = 1F;
            // 
            // radialGaugeTicks3
            // 
            this.radialGaugeTicks3.DrawText = false;
            this.radialGaugeTicks3.Name = "radialGaugeTicks3";
            this.radialGaugeTicks3.Text = "radialGaugeTicks3";
            this.radialGaugeTicks3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks3.TicksCount = 18;
            this.radialGaugeTicks3.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks3.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks3.TickThickness = 1F;
            // 
            // radialGaugeTicks4
            // 
            this.radialGaugeTicks4.DrawText = false;
            this.radialGaugeTicks4.Name = "radialGaugeTicks4";
            this.radialGaugeTicks4.Text = "radialGaugeTicks4";
            this.radialGaugeTicks4.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks4.TicksCount = 54;
            this.radialGaugeTicks4.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks4.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks4.TickThickness = 1F;
            // 
            // radialGaugeLabels1
            // 
            this.radialGaugeLabels1.DrawText = false;
            this.radialGaugeLabels1.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels1.LabelFontSize = 4F;
            this.radialGaugeLabels1.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels1.LabelsCount = 9;
            this.radialGaugeLabels1.Name = "radialGaugeLabels1";
            this.radialGaugeLabels1.Text = "radialGaugeLabels1";
            // 
            // radialGaugeLabels2
            // 
            this.radialGaugeLabels2.DrawText = false;
            this.radialGaugeLabels2.ForeColor = System.Drawing.Color.Red;
            this.radialGaugeLabels2.LabelFontSize = 4F;
            this.radialGaugeLabels2.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels2.LabelsCount = 9;
            this.radialGaugeLabels2.LabelStartVisibleRange = 120F;
            this.radialGaugeLabels2.Name = "radialGaugeLabels2";
            this.radialGaugeLabels2.Text = "radialGaugeLabels2";
            // 
            // radialGaugeNeedle2
            // 
            this.radialGaugeNeedle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radialGaugeNeedle2.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle2.LenghtPercentage = 78D;
            this.radialGaugeNeedle2.Name = "radialGaugeNeedle2";
            this.radialGaugeNeedle2.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle2.Text = "radialGaugeNeedle1";
            this.radialGaugeNeedle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radialGaugeNeedle2.Thickness = 2D;
            this.radialGaugeNeedle2.Value = 130F;
            // 
            // radialGaugeNeedle1
            // 
            this.radialGaugeNeedle1.Name = "radialGaugeNeedle1";
            this.radialGaugeNeedle1.Text = "radialGaugeNeedle1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRadialGauge1);
            this.groupBox1.Location = new System.Drawing.Point(18, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 213);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "온도센서 측정결과";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radLinearGauge1);
            this.groupBox2.Location = new System.Drawing.Point(236, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 213);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서보밸브 측정결과";
            // 
            // radLinearGauge1
            // 
            this.radLinearGauge1.BackColor = System.Drawing.Color.White;
            this.radLinearGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLinearGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar1,
            this.linearGaugeLine1,
            this.linearGaugeLine2,
            this.linearGaugeTicks1,
            this.linearGaugeLabels1,
            this.linearGaugeTicks2,
            this.linearGaugeTicks3,
            this.linearGaugeLine3,
            this.linearGaugeTicks4,
            this.linearGaugeNeedleIndicator1});
            this.radLinearGauge1.Location = new System.Drawing.Point(3, 28);
            this.radLinearGauge1.Name = "radLinearGauge1";
            this.radLinearGauge1.Padding = new System.Windows.Forms.Padding(0, 5, 40, 5);
            this.radLinearGauge1.RangeEnd = 45F;
            this.radLinearGauge1.Size = new System.Drawing.Size(112, 182);
            this.radLinearGauge1.TabIndex = 0;
            this.radLinearGauge1.Text = "radLinearGauge1";
            this.radLinearGauge1.Vertical = true;
            this.radLinearGauge1.Click += new System.EventHandler(this.radLinearGauge1_Click);
            // 
            // linearGaugeBar1
            // 
            this.linearGaugeBar1.AutoSize = false;
            this.linearGaugeBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar1.BindEndRange = true;
            this.linearGaugeBar1.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeBar1.Name = "linearGaugeBar1";
            this.linearGaugeBar1.Offset = 35F;
            this.linearGaugeBar1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar1.RangeEnd = 50F;
            this.linearGaugeBar1.Width = 24F;
            this.linearGaugeBar1.Width2 = 24F;
            // 
            // linearGaugeLine1
            // 
            this.linearGaugeLine1.AutoSize = false;
            this.linearGaugeLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeLine1.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine1.Name = "linearGaugeLine1";
            this.linearGaugeLine1.Offset = 35F;
            this.linearGaugeLine1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine1.RangeEnd = 80F;
            this.linearGaugeLine1.Width = 2F;
            // 
            // linearGaugeLine2
            // 
            this.linearGaugeLine2.AutoSize = false;
            this.linearGaugeLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine2.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeLine2.Name = "linearGaugeLine2";
            this.linearGaugeLine2.Offset = 35F;
            this.linearGaugeLine2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine2.RangeEnd = 300F;
            this.linearGaugeLine2.RangeStart = 100F;
            this.linearGaugeLine2.Width = 2F;
            // 
            // linearGaugeTicks1
            // 
            this.linearGaugeTicks1.AutoSize = false;
            this.linearGaugeTicks1.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks1.Name = "linearGaugeTicks1";
            this.linearGaugeTicks1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeTicks1.TicksCount = 3;
            this.linearGaugeTicks1.TicksLenghtPercentage = 4F;
            this.linearGaugeTicks1.TicksLocationPercentage = 33F;
            // 
            // linearGaugeLabels1
            // 
            this.linearGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeLabels1.LabelFontSize = 3F;
            this.linearGaugeLabels1.LabelLocationPercentage = 15F;
            this.linearGaugeLabels1.LabelsCount = 3;
            this.linearGaugeLabels1.Name = "linearGaugeLabels1";
            this.linearGaugeLabels1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeTicks2
            // 
            this.linearGaugeTicks2.AutoSize = false;
            this.linearGaugeTicks2.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks2.Name = "linearGaugeTicks2";
            this.linearGaugeTicks2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks2.TickEndIndexVisibleRange = 4F;
            this.linearGaugeTicks2.TicksCount = 12;
            this.linearGaugeTicks2.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks2.TicksLocationPercentage = 33F;
            // 
            // linearGaugeTicks3
            // 
            this.linearGaugeTicks3.AutoSize = false;
            this.linearGaugeTicks3.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks3.Name = "linearGaugeTicks3";
            this.linearGaugeTicks3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks3.TicksCount = 12;
            this.linearGaugeTicks3.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks3.TicksLocationPercentage = 33F;
            this.linearGaugeTicks3.TickStartIndexVisibleRange = 5F;
            // 
            // linearGaugeLine3
            // 
            this.linearGaugeLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine3.Name = "linearGaugeLine3";
            this.linearGaugeLine3.Offset = 69F;
            this.linearGaugeLine3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine3.RangeEnd = 300F;
            this.linearGaugeLine3.RangeStart = 100F;
            // 
            // linearGaugeTicks4
            // 
            this.linearGaugeTicks4.AutoSize = false;
            this.linearGaugeTicks4.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks4.Name = "linearGaugeTicks4";
            this.linearGaugeTicks4.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks4.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeTicks4.TicksCount = 12;
            this.linearGaugeTicks4.TicksLenghtPercentage = 3F;
            this.linearGaugeTicks4.TicksLocationPercentage = 72F;
            // 
            // linearGaugeNeedleIndicator1
            // 
            this.linearGaugeNeedleIndicator1.AutoSize = false;
            this.linearGaugeNeedleIndicator1.BackColor = System.Drawing.Color.Red;
            this.linearGaugeNeedleIndicator1.Bounds = new System.Drawing.Rectangle(0, 0, 63, 270);
            this.linearGaugeNeedleIndicator1.CircleTicks = true;
            this.linearGaugeNeedleIndicator1.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator1.DrawValue = true;
            this.linearGaugeNeedleIndicator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeNeedleIndicator1.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator1.IsFilled = false;
            this.linearGaugeNeedleIndicator1.LenghtPercentage = 6F;
            this.linearGaugeNeedleIndicator1.LineLenght = 40F;
            this.linearGaugeNeedleIndicator1.LocationPercentage = 70F;
            this.linearGaugeNeedleIndicator1.Name = "linearGaugeNeedleIndicator1";
            this.linearGaugeNeedleIndicator1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator1.PointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator1.TextOffsetFromIndicator = new System.Drawing.SizeF(2F, -5F);
            this.linearGaugeNeedleIndicator1.Value = 66F;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTrackBar1);
            this.groupBox4.Location = new System.Drawing.Point(18, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 61);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도설정(자동모드 전용)";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar1.LargeChange = 1;
            this.radTrackBar1.LargeTickFrequency = 20;
            this.radTrackBar1.Location = new System.Drawing.Point(3, 28);
            this.radTrackBar1.Maximum = 200F;
            this.radTrackBar1.Minimum = 40F;
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.ShowButtons = true;
            this.radTrackBar1.Size = new System.Drawing.Size(330, 55);
            this.radTrackBar1.TabIndex = 4;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.ThemeName = "Windows7";
            this.radTrackBar1.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            this.radTrackBar1.Value = 50F;
            this.radTrackBar1.ValueChanged += new System.EventHandler(this.radTrackBar1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radTrackBar2);
            this.groupBox3.Location = new System.Drawing.Point(18, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "유량설정(수동모드 전용)";
            // 
            // radTrackBar2
            // 
            this.radTrackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTrackBar2.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar2.Location = new System.Drawing.Point(3, 28);
            this.radTrackBar2.Maximum = 45F;
            this.radTrackBar2.Name = "radTrackBar2";
            this.radTrackBar2.ShowButtons = true;
            this.radTrackBar2.Size = new System.Drawing.Size(330, 55);
            this.radTrackBar2.TabIndex = 4;
            this.radTrackBar2.Text = "radTrackBar2";
            this.radTrackBar2.ThemeName = "Windows7";
            this.radTrackBar2.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            this.radTrackBar2.ValueChanged += new System.EventHandler(this.radTrackBar2_ValueChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radChartView1);
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(360, 94);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(604, 366);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Windows7";
            // 
            // radChartView1
            // 
            cartesianArea1.GridDesign.DrawVerticalFills = false;
            cartesianArea1.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "온도";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.radChartView1.Controls.Add(this.button1);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(2, 18);
            this.radChartView1.Name = "radChartView1";
            areaSeries1.DataMember = "model.Data";
            areaSeries1.HorizontalAxis = categoricalAxis1;
            areaSeries1.LabelAngle = 90D;
            areaSeries1.LabelDistanceToPoint = 15D;
            areaSeries1.LegendTitle = null;
            areaSeries1.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            areaSeries1});
            this.radChartView1.Size = new System.Drawing.Size(600, 346);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.ThemeName = "Windows7";
            this.radChartView1.Title = "Temp.";
            this.radChartView1.Initialized += new System.EventHandler(this.radChartView1_Initialized);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 38400;
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGroupBox2.Controls.Add(this.tbCurrentFlow);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.tbSetFlow);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.btnValveOff);
            this.radGroupBox2.Controls.Add(this.btnValveStart);
            this.radGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox2.HeaderText = "MFC Control Module";
            this.radGroupBox2.Location = new System.Drawing.Point(360, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(330, 76);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.Text = "MFC Control Module";
            this.radGroupBox2.ThemeName = "Windows7";
            // 
            // tbCurrentFlow
            // 
            this.tbCurrentFlow.BackColor = System.Drawing.Color.Black;
            this.tbCurrentFlow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentFlow.ForeColor = System.Drawing.Color.Lime;
            this.tbCurrentFlow.Location = new System.Drawing.Point(80, 48);
            this.tbCurrentFlow.Name = "tbCurrentFlow";
            this.tbCurrentFlow.Size = new System.Drawing.Size(89, 35);
            this.tbCurrentFlow.TabIndex = 1;
            this.tbCurrentFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(6, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(137, 34);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Current Flow";
            // 
            // tbSetFlow
            // 
            this.tbSetFlow.BackColor = System.Drawing.Color.Black;
            this.tbSetFlow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetFlow.ForeColor = System.Drawing.Color.Lime;
            this.tbSetFlow.Location = new System.Drawing.Point(80, 23);
            this.tbSetFlow.Name = "tbSetFlow";
            this.tbSetFlow.Size = new System.Drawing.Size(89, 35);
            this.tbSetFlow.TabIndex = 0;
            this.tbSetFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(23, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 34);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Set Flow";
            // 
            // btnValveOff
            // 
            this.btnValveOff.Location = new System.Drawing.Point(251, 23);
            this.btnValveOff.Name = "btnValveOff";
            this.btnValveOff.Size = new System.Drawing.Size(69, 44);
            this.btnValveOff.TabIndex = 17;
            this.btnValveOff.Text = "Valve Off";
            this.btnValveOff.ThemeName = "Windows7";
            this.btnValveOff.Click += new System.EventHandler(this.btnValveOff_Click);
            // 
            // btnValveStart
            // 
            this.btnValveStart.Location = new System.Drawing.Point(176, 23);
            this.btnValveStart.Name = "btnValveStart";
            this.btnValveStart.Size = new System.Drawing.Size(69, 44);
            this.btnValveStart.TabIndex = 16;
            this.btnValveStart.Text = "Valve On";
            this.btnValveStart.ThemeName = "Windows7";
            this.btnValveStart.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.groupBox6);
            this.radGroupBox3.Controls.Add(this.groupBox5);
            this.radGroupBox3.Controls.Add(this.tbGain_D);
            this.radGroupBox3.Controls.Add(this.tbGain_I);
            this.radGroupBox3.Controls.Add(this.radLabel6);
            this.radGroupBox3.Controls.Add(this.tbGain_P);
            this.radGroupBox3.Controls.Add(this.radLabel5);
            this.radGroupBox3.Controls.Add(this.radLabel3);
            this.radGroupBox3.Controls.Add(this.btnAutoRun);
            this.radGroupBox3.HeaderText = "Thermal Controller";
            this.radGroupBox3.Location = new System.Drawing.Point(18, 12);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(336, 90);
            this.radGroupBox3.TabIndex = 15;
            this.radGroupBox3.Text = "Thermal Controller";
            this.radGroupBox3.ThemeName = "Windows7";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbGain_Output_Min);
            this.groupBox6.Controls.Add(this.tbGain_Output_Max);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(190, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(65, 69);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Output";
            // 
            // tbGain_Output_Min
            // 
            this.tbGain_Output_Min.BackColor = System.Drawing.Color.White;
            this.tbGain_Output_Min.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_Output_Min.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_Output_Min.Location = new System.Drawing.Point(3, 44);
            this.tbGain_Output_Min.Name = "tbGain_Output_Min";
            this.tbGain_Output_Min.Size = new System.Drawing.Size(59, 35);
            this.tbGain_Output_Min.TabIndex = 19;
            this.tbGain_Output_Min.Text = "`";
            this.tbGain_Output_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_Output_Min.TextChanged += new System.EventHandler(this.tbGain_Output_Min_TextChanged);
            // 
            // tbGain_Output_Max
            // 
            this.tbGain_Output_Max.BackColor = System.Drawing.Color.White;
            this.tbGain_Output_Max.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_Output_Max.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_Output_Max.Location = new System.Drawing.Point(3, 19);
            this.tbGain_Output_Max.Name = "tbGain_Output_Max";
            this.tbGain_Output_Max.Size = new System.Drawing.Size(59, 35);
            this.tbGain_Output_Max.TabIndex = 18;
            this.tbGain_Output_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_Output_Max.TextChanged += new System.EventHandler(this.tbGain_Output_Max_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbGain_Input_Min);
            this.groupBox5.Controls.Add(this.tbGain_Input_Max);
            this.groupBox5.Location = new System.Drawing.Point(119, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(65, 69);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input";
            // 
            // tbGain_Input_Min
            // 
            this.tbGain_Input_Min.BackColor = System.Drawing.Color.White;
            this.tbGain_Input_Min.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_Input_Min.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_Input_Min.Location = new System.Drawing.Point(3, 44);
            this.tbGain_Input_Min.Name = "tbGain_Input_Min";
            this.tbGain_Input_Min.Size = new System.Drawing.Size(59, 35);
            this.tbGain_Input_Min.TabIndex = 19;
            this.tbGain_Input_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_Input_Min.TextChanged += new System.EventHandler(this.tbGain_Input_Min_TextChanged);
            // 
            // tbGain_Input_Max
            // 
            this.tbGain_Input_Max.BackColor = System.Drawing.Color.White;
            this.tbGain_Input_Max.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_Input_Max.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_Input_Max.Location = new System.Drawing.Point(3, 18);
            this.tbGain_Input_Max.Name = "tbGain_Input_Max";
            this.tbGain_Input_Max.Size = new System.Drawing.Size(59, 35);
            this.tbGain_Input_Max.TabIndex = 18;
            this.tbGain_Input_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_Input_Max.TextChanged += new System.EventHandler(this.tbGain_Input_Max_TextChanged);
            // 
            // tbGain_D
            // 
            this.tbGain_D.BackColor = System.Drawing.Color.White;
            this.tbGain_D.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_D.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_D.Location = new System.Drawing.Point(54, 64);
            this.tbGain_D.Name = "tbGain_D";
            this.tbGain_D.Size = new System.Drawing.Size(59, 35);
            this.tbGain_D.TabIndex = 17;
            this.tbGain_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_D.TextChanged += new System.EventHandler(this.tbGain_D_TextChanged);
            // 
            // tbGain_I
            // 
            this.tbGain_I.BackColor = System.Drawing.Color.White;
            this.tbGain_I.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_I.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_I.Location = new System.Drawing.Point(54, 42);
            this.tbGain_I.Name = "tbGain_I";
            this.tbGain_I.Size = new System.Drawing.Size(59, 35);
            this.tbGain_I.TabIndex = 17;
            this.tbGain_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(7, 65);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(77, 34);
            this.radLabel6.TabIndex = 18;
            this.radLabel6.Text = "D Gain";
            // 
            // tbGain_P
            // 
            this.tbGain_P.BackColor = System.Drawing.Color.White;
            this.tbGain_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGain_P.ForeColor = System.Drawing.Color.Lime;
            this.tbGain_P.Location = new System.Drawing.Point(54, 20);
            this.tbGain_P.Name = "tbGain_P";
            this.tbGain_P.Size = new System.Drawing.Size(59, 35);
            this.tbGain_P.TabIndex = 15;
            this.tbGain_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGain_P.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGain_P_KeyDown);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(12, 43);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(67, 34);
            this.radLabel5.TabIndex = 18;
            this.radLabel5.Text = "I Gain";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(9, 21);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(74, 34);
            this.radLabel3.TabIndex = 16;
            this.radLabel3.Text = "P Gain";
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.BackColor = System.Drawing.Color.LightGray;
            this.btnAutoRun.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAutoRun.Location = new System.Drawing.Point(261, 19);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(70, 64);
            this.btnAutoRun.TabIndex = 14;
            this.btnAutoRun.Text = "<html><p>Thermal</p><p>Control</p></html>";
            this.btnAutoRun.ThemeName = "Windows7";
            this.btnAutoRun.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGroupBox4.Controls.Add(this.tbCurrentTemp);
            this.radGroupBox4.Controls.Add(this.lbCurrentTemp);
            this.radGroupBox4.Controls.Add(this.tbSetTemp);
            this.radGroupBox4.Controls.Add(this.radLabel4);
            this.radGroupBox4.Controls.Add(this.btnTCPStart);
            this.radGroupBox4.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox4.HeaderText = "Temperature Sensor";
            this.radGroupBox4.Location = new System.Drawing.Point(697, 12);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(267, 76);
            this.radGroupBox4.TabIndex = 18;
            this.radGroupBox4.Text = "Temperature Sensor";
            this.radGroupBox4.ThemeName = "Windows7";
            // 
            // tbCurrentTemp
            // 
            this.tbCurrentTemp.BackColor = System.Drawing.Color.Black;
            this.tbCurrentTemp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentTemp.ForeColor = System.Drawing.Color.Lime;
            this.tbCurrentTemp.Location = new System.Drawing.Point(86, 48);
            this.tbCurrentTemp.Name = "tbCurrentTemp";
            this.tbCurrentTemp.Size = new System.Drawing.Size(94, 35);
            this.tbCurrentTemp.TabIndex = 1;
            this.tbCurrentTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCurrentTemp
            // 
            this.lbCurrentTemp.Location = new System.Drawing.Point(4, 48);
            this.lbCurrentTemp.Name = "lbCurrentTemp";
            this.lbCurrentTemp.Size = new System.Drawing.Size(152, 34);
            this.lbCurrentTemp.TabIndex = 2;
            this.lbCurrentTemp.Text = "Current Temp.";
            // 
            // tbSetTemp
            // 
            this.tbSetTemp.BackColor = System.Drawing.Color.Black;
            this.tbSetTemp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetTemp.ForeColor = System.Drawing.Color.Lime;
            this.tbSetTemp.Location = new System.Drawing.Point(86, 23);
            this.tbSetTemp.Name = "tbSetTemp";
            this.tbSetTemp.Size = new System.Drawing.Size(94, 35);
            this.tbSetTemp.TabIndex = 0;
            this.tbSetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(25, 24);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(109, 34);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Set Temp.";
            // 
            // btnTCPStart
            // 
            this.btnTCPStart.Location = new System.Drawing.Point(185, 23);
            this.btnTCPStart.Name = "btnTCPStart";
            this.btnTCPStart.Size = new System.Drawing.Size(70, 44);
            this.btnTCPStart.TabIndex = 16;
            this.btnTCPStart.Text = "Connection";
            this.btnTCPStart.ThemeName = "Windows7";
            this.btnTCPStart.Click += new System.EventHandler(this.btnTCPStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.radChartView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValveOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValveStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Output_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Output_Max)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Input_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_Input_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAutoRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            this.radGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTCPStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private System.IO.Ports.SerialPort serialPort;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton btnAutoRun;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox tbSetFlow;
        private Telerik.WinControls.UI.RadButton btnValveStart;
        private Telerik.WinControls.UI.RadButton btnValveOff;
        private Telerik.WinControls.UI.RadTextBox tbCurrentFlow;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadButton btnTCPStart;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadTextBox tbCurrentTemp;
        private Telerik.WinControls.UI.RadLabel lbCurrentTemp;
        private Telerik.WinControls.UI.RadTextBox tbSetTemp;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle1;
        private Telerik.WinControls.UI.RadTextBox tbGain_D;
        private Telerik.WinControls.UI.RadTextBox tbGain_I;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox tbGain_P;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private Telerik.WinControls.UI.RadTextBox tbGain_Output_Min;
        private Telerik.WinControls.UI.RadTextBox tbGain_Output_Max;
        private System.Windows.Forms.GroupBox groupBox5;
        private Telerik.WinControls.UI.RadTextBox tbGain_Input_Min;
        private Telerik.WinControls.UI.RadTextBox tbGain_Input_Max;


    }
}