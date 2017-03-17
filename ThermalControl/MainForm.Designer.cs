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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTrackBar2 = new Telerik.WinControls.UI.RadTrackBar();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRadialGauge1
            // 
            this.radRadialGauge1.BackColor = System.Drawing.Color.White;
            this.radRadialGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeTicks1,
            this.radialGaugeTicks2,
            this.radialGaugeTicks3,
            this.radialGaugeTicks4,
            this.radialGaugeLabels1,
            this.radialGaugeLabels2,
            this.radialGaugeNeedle2});
            this.radRadialGauge1.Location = new System.Drawing.Point(6, 19);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.RangeEnd = 180D;
            this.radRadialGauge1.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge1.TabIndex = 1;
            this.radRadialGauge1.Text = "radRadialGauge2";
            this.radRadialGauge1.ThemeName = "ControlDefault";
            this.radRadialGauge1.Value = 0F;
            this.radRadialGauge1.ValueChanged += new System.EventHandler(this.radRadialGauge1_ValueChanged);
            this.radRadialGauge1.Click += new System.EventHandler(this.radRadialGauge1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thermal Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRadialGauge1);
            this.groupBox1.Location = new System.Drawing.Point(18, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "온도센서 측정결과";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radLinearGauge1);
            this.groupBox2.Location = new System.Drawing.Point(236, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서보밸브 측정결과";
            // 
            // radLinearGauge1
            // 
            this.radLinearGauge1.BackColor = System.Drawing.Color.White;
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
            this.radLinearGauge1.Location = new System.Drawing.Point(3, 16);
            this.radLinearGauge1.Name = "radLinearGauge1";
            this.radLinearGauge1.Padding = new System.Windows.Forms.Padding(0, 5, 40, 5);
            this.radLinearGauge1.RangeEnd = 120F;
            this.radLinearGauge1.Size = new System.Drawing.Size(106, 209);
            this.radLinearGauge1.TabIndex = 0;
            this.radLinearGauge1.Text = "radLinearGauge1";
            this.radLinearGauge1.Value = 70F;
            this.radLinearGauge1.Vertical = true;
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
            this.linearGaugeBar1.RangeEnd = 70F;
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
            this.linearGaugeLine2.RangeEnd = 120F;
            this.linearGaugeLine2.RangeStart = 80F;
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
            this.linearGaugeLine3.RangeEnd = 120F;
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
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(192, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(162, 42);
            this.radButton1.TabIndex = 12;
            this.radButton1.Text = "자동운전";
            this.radButton1.ThemeName = "Windows7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTrackBar1);
            this.groupBox4.Location = new System.Drawing.Point(17, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 61);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도설정(자동모드 전용)";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar1.Location = new System.Drawing.Point(6, 16);
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(322, 41);
            this.radTrackBar1.TabIndex = 4;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.ThemeName = "Windows7";
            this.radTrackBar1.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radTrackBar2);
            this.groupBox3.Location = new System.Drawing.Point(17, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "유량설정(수동모드 전용)";
            // 
            // radTrackBar2
            // 
            this.radTrackBar2.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.radTrackBar2.Location = new System.Drawing.Point(6, 16);
            this.radTrackBar2.Name = "radTrackBar2";
            this.radTrackBar2.Size = new System.Drawing.Size(322, 41);
            this.radTrackBar2.TabIndex = 4;
            this.radTrackBar2.Text = "radTrackBar2";
            this.radTrackBar2.ThemeName = "Windows7";
            this.radTrackBar2.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radChartView1);
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(360, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(604, 413);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Windows7";
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.PlotMode = Telerik.Charting.AxisPlotMode.OnTicks;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.MajorStep = 50D;
            linearAxis1.Maximum = 300D;
            linearAxis1.Minimum = 0D;
            linearAxis1.ScaleBreakSize = 1D;
            linearAxis1.TickLength = 1D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "온도";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.radChartView1.Location = new System.Drawing.Point(5, 26);
            this.radChartView1.Name = "radChartView1";
            areaSeries1.DataMember = "model.Data";
            areaSeries1.HorizontalAxis = categoricalAxis1;
            areaSeries1.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            areaSeries1});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(594, 382);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.ThemeName = "Windows7";
            this.radChartView1.Initialized += new System.EventHandler(this.radChartView1_Initialized);
            this.radChartView1.Click += new System.EventHandler(this.radChartView1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 439);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
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
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadChartView radChartView1;


    }
}