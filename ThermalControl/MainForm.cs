using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Telerik.WinControls.UI.Gauges;
using Telerik.WinControls;

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
        
        Font font = new Font("온도제어", 12F, System.Drawing.FontStyle.Regular);
        
        public MainForm()
        {

            // 메인클래스 객체 생성
            this.m_MainClass = new MainClass(this);
            
            InitializeComponent();
            
            //this.appleAverage = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[1], 100.0d);
            //this.appleAverage.BorderColor = Color.LimeGreen;
            //this.appleAverage.BorderWidth = 2;
            //this.appleAverage.Label = "225.74 AVG value";
            //this.appleAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

        }


        private void model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("라이브데이테 클래스에서 PropertyChangedEventArgs 발생 ");
        }



        byte[] buff = new byte[20];

        private void MainForm_Load(object sender, EventArgs e)
        {



            timer1.Start();     // Start Mainform Timer 

            m_MainClass.m_LiveDataModel.StartTimer();     // Start LiveDataChart Timer 
            m_MainClass.m_LiveDataModel.PropertyChanged += new PropertyChangedEventHandler(model_PropertyChanged);
            

            m_MainClass.stPIDGain.kp = 100.1;
            m_MainClass.stPIDGain.ki = 0.1;
            m_MainClass.stPIDGain.kd = 0.1;
            m_MainClass.stPIDGain.inputMax = 200;
            m_MainClass.stPIDGain.inputMin = 50;
            m_MainClass.stPIDGain.outMax = 25;
            m_MainClass.stPIDGain.outMin = 0;


            tbGain_P.Text = m_MainClass.stPIDGain.kp.ToString();
            tbGain_I.Text = m_MainClass.stPIDGain.ki.ToString();
            tbGain_D.Text = m_MainClass.stPIDGain.kd.ToString();
            tbGain_Input_Max.Text = m_MainClass.stPIDGain.inputMax.ToString();
            tbGain_Input_Min.Text = m_MainClass.stPIDGain.inputMin.ToString();
            tbGain_Output_Max.Text = m_MainClass.stPIDGain.outMax.ToString();
            tbGain_Output_Min.Text = m_MainClass.stPIDGain.outMin.ToString();


            // Serial Port Open
            try
            {
                serialPort.BaudRate = m_MainClass.m_Define_Class.MFC_Serial_BaudRate;
                serialPort.PortName = m_MainClass.m_Define_Class.MFC_Serial_Port_Name;

                serialPort.Open();

                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('1');

                buff[7] = Convert.ToByte('0');
                buff[8] = Convert.ToByte('1');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[9] = (byte)Convert.ToChar(str1);
                buff[10] = (byte)Convert.ToChar(str2);

                buff[11] = 0x03;

                serialPort.Write(buff, 0, 12);

                m_MainClass.m_Define_Class.isMFC_Con = true;

            }

            catch (Exception ex)
            {
                m_MainClass.m_Define_Class.isMFC_Con = false; 
                MessageBox.Show("시리얼포트가 정상적으로 연결되지 않았습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_MainClass.m_TCPClass.StartClient();
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
            lineSeries.DataSource = m_MainClass.m_LiveDataModel.Data;
            lineSeries.BorderWidth = 2;

            this.radChartView1.Series.Add(lineSeries);

            this.radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.radChartView1.ChartElement.TitleElement.Margin = new Padding(10, 10, 0, 0);
            this.radChartView1.View.Margin = new Padding(10, 0, 35, 0);

            LinearAxis axeY = radChartView1.Axes.Get<LinearAxis>(1);
            axeY.Minimum = 0;
            axeY.Maximum = 300;
            axeY.MajorStep = 30;

            CategoricalAxis axeX = radChartView1.Axes.Get<CategoricalAxis>(0);
            axeX.ClipLabels = false;
            axeX.LabelInterval = 50;
            axeX.LabelFormat = "{0:HH:mm:ss.f}";


        }

        private void radButton2_Click(object sender, System.EventArgs e)
        {

            buff[0] = 0x02;

            buff[1] = Convert.ToByte('0');
            buff[2] = Convert.ToByte('1');

            buff[3] = Convert.ToByte('D');

            buff[4] = Convert.ToByte('w');

            buff[5] = Convert.ToByte('0');
            buff[6] = Convert.ToByte('2');

            buff[7] = Convert.ToByte('0');
            buff[8] = Convert.ToByte('1');

            // check sum 
            int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
            string str1 = checksum.ToString("X2").Substring(0, 1);
            string str2 = checksum.ToString("X2").Substring(1, 1);

            buff[9] = (byte)Convert.ToChar(str1);
            buff[10] = (byte)Convert.ToChar(str2);

            buff[11] = 0x03;

            serialPort.Write(buff, 0, 12);
        }


        int recvCnt;
        string recvData;
        bool recvStatus;

        public void PacketAnalysTempSensor(string data)
        {
            string tt = "";

            if (data.Length > 8)
            {
                if (data.Substring(0, 5) == "(s131")
                {
                    if (data.Length == 12) tt = data.Substring(5, 6);
                    else if (data.Length == 13) tt = data.Substring(5, 7);


                    /*
                     Channel 1 Sensor Data Receive 
                     */
                    m_MainClass.stTempSensor.fCurrentTemp = float.Parse(tt);

                }
            }

            
        }

        public void PacketAnalysMFC(string data, int data_count)
        {
            string str = ""; 
            float ff = 0.0f;

            if(data.Length > 8)
            {

                if(data.Substring(4, 2) == "09")        // To set target flow 
                {
                    
                    Console.WriteLine(data.Substring(6, 8));


                    string ss = data.Substring(6, 8);
                    string sss = "";

                    sss += ss.Substring(6, 2);
                    sss += ss.Substring(4, 2);
                    sss += ss.Substring(2, 2);
                    sss += ss.Substring(0, 2);

                    uint num = uint.Parse(sss, System.Globalization.NumberStyles.AllowHexSpecifier);
                    byte[] bb = BitConverter.GetBytes(num);
                    ff = BitConverter.ToSingle(bb, 0);

                    m_MainClass.stMfcController.fTargetFlow = ff;
                }
                else if (data.Substring(4, 2) == "04")   // to read current flow 
                {
                    string ss = data.Substring(6, 8);
                    string sss = "";

                    sss += ss.Substring(6, 2);
                    sss += ss.Substring(4, 2);
                    sss += ss.Substring(2, 2);
                    sss += ss.Substring(0, 2);

                    uint num = uint.Parse(sss, System.Globalization.NumberStyles.AllowHexSpecifier);
                    byte[] bb = BitConverter.GetBytes(num);
                    ff = BitConverter.ToSingle(bb, 0);

                    m_MainClass.stMfcController.fCurrentFlow = ff;
                }
                else if (data.Substring(4, 2) == "01")   // to read Set-Point Source 
                {
                    string ss = data.Substring(6, 2);

                    if (ss == "01")
                    {
                        m_MainClass.m_Define_Class.isMFC_Digit_Mode = true;
                    }
                    else
                    {
                        m_MainClass.m_Define_Class.isMFC_Digit_Mode = false;
                    }
                }
                else if (data.Substring(4, 2) == "02")   // to read Flow Valve on/off 
                {
                    string ss = data.Substring(6, 2);

                    if (ss == "01")
                    {
                        m_MainClass.m_Define_Class.isMFC_Valve_Open = true;
                        btnValveStart.BackColor = Color.Lime;
                        btnValveOff.BackColor = Color.LightGray;
                    }
                    else
                    {
                        m_MainClass.m_Define_Class.isMFC_Valve_Open = false;
                        btnValveStart.BackColor = Color.LightGray;
                        btnValveOff.BackColor = Color.Lime;
                    }
                }
            }
        }

        string strRxData = "";
        int nReceiveCount = 0;

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int nNumOfData = serialPort.BytesToRead;

            // Received Data is in buffer 
            if (nNumOfData != 0)
            {
                byte[] buff = new byte[nNumOfData];
                serialPort.Read(buff, 0, nNumOfData);

                for (int i = 0; i < nNumOfData; i++)
                {
                    char data = Convert.ToChar(buff[i]);

                    if(data == (byte)DefineClass.DMFC_PROTOCOL.ACK)
                    {
                        nReceiveCount = 1;
                        strRxData = data.ToString();
                    }
                    else if (data == (byte)DefineClass.DMFC_PROTOCOL.ETX)
                    {
                        strRxData += data;
                        PacketAnalysMFC(strRxData, nReceiveCount);
                        nReceiveCount = 0;
                    }
                    else
                    {
                        nReceiveCount++;
                        strRxData += data;
                    }
                }                
            }
        }
        

        public GetDouble ReadPV;    
        public GetDouble ReadSP;
        public SetDouble WriteOV;

        public double setPV() { return m_MainClass.stPIDGain.PV; }
        public double setSP() { return m_MainClass.stPIDGain.SP; }
        public void getOV(double OV) { this.m_MainClass.stPIDGain.OV = getLimited_PID_OV(OV); }

        //Convert.ToSingle(OV)
        private void radButton1_Click(object sender, System.EventArgs e)
        {
            
            if (!m_MainClass.m_Define_Class.isMFC_Con)
            {
                MessageBox.Show("MFC가 연결되지 않았습니다.");
            }
            else if(!m_MainClass.m_Define_Class.isConTempSensor)
            {
                MessageBox.Show("온도센서 연결되지 않았습니다.");
            }
            else if(!m_MainClass.m_Define_Class.isMFC_Valve_Open)
            {
                MessageBox.Show("MFC 밸브가 닫혀 있습니다.");
            }
            else if(m_MainClass.m_Define_Class.isAutoRun)
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "온도제어를 중지 하겠습니까?", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    m_MainClass.m_Define_Class.isAutoRun = false;
                    btnAutoRun.BackColor = Color.LightGray;
                    m_MainClass.m_PidClass.Disable();
                }
            }
            else
            {
                m_MainClass.m_Define_Class.isAutoRun = true;
                btnAutoRun.BackColor = Color.Lime;

                ReadPV = new GetDouble(setPV);
                ReadSP = new GetDouble(setSP);
                WriteOV = new SetDouble(getOV);

                m_MainClass.m_PidClass = new PID(
                    m_MainClass.stPIDGain.kp, 
                    m_MainClass.stPIDGain.ki,
                    m_MainClass.stPIDGain.kd,
                    m_MainClass.stPIDGain.inputMax,
                    m_MainClass.stPIDGain.inputMin,
                    m_MainClass.stPIDGain.outMax, 
                    m_MainClass.stPIDGain.outMin,
                    ReadPV, ReadSP, WriteOV);
                m_MainClass.m_PidClass.Enable();
            }



                //System.Console.WriteLine("Send Message : " + System.Text.Encoding.ASCII.GetString(buff));

                /*
                 * 
                 * // (1) 한 byte 를 Hex 문자로 변환하는 방법
                    byte b1 = 0xFE;
                    string hex1 = b1.ToString("X2");

                    // (2) byte[] 을 Hex 문자열로 변환하는 방법
                    byte[] bytes = new byte[] { 0xA1, 0xB2, 0xC3, 0x11, 0x2F };
                    string h = string.Concat(Array.ConvertAll(bytes, byt => byt.ToString("X2")));
                    // 혹은
                    // h = BitConverter.ToString(bytes).Replace("-", "");


                    // (3) 한 Hex 문자를 byte 로 변환하는 방법
                    byte b2 = Convert.ToByte("3F", 16);
                    // 혹은
                    // b2 = byte.Parse("3F", NumberStyles.HexNumber);

                    // (4) 여러 Hex 문자열을 byte[] 로 변환하는 방법
                    string hexString = "A1B2C3";
                    byte[] xbytes = new byte[hexString.Length / 2];
                    for (int i = 0; i < xbytes.Length; i++)
                    {
                        xbytes[i] = Convert.ToByte(hexString.Substring(i*2, 2), 16);
                    }
                 */

                /*
                The Compute routine is where the meat of the algorithm lies. Basically, it starts out reading the process variable (pv) and set point (sp). It then Clamp's them to pvMin and pvMax, then scales them so they are a percentage between -100% and 100% of the scale. It then figures out the error percentage and starts running the PID calculation.

                The calculation is pretty simple; it starts out finding the pTerm, which is the error times the gain (kp). Then, inside the if statement, we do what is called anti-windup reset, where we only calculate the iTerm if the process variable isn't pegged at or above the process variable range. This helps to limit the output of the system, and keeps the error from blowing up when the process variable gets out of range.

                The last thing it does is simply sum the three terms to obtain the output value, clamp it to +/-100% of the output range, then scale it to come up with a real output number. It then uses the SetDouble delegate called writeOV (write output variable) to set the output value.

                And there you have it. If we have a more real-time or critical process, we can set the runThread priority to something higher, but I wouldn't recommend going above "High" since it will cause other things to become preempted too often.

                This is a very versatile class; setting the I gain term to zero will give you a PD controller, and if you wanted, you could have a strictly P controller by setting both the I and D gains to zero.
                */

            //}
            //else if(m_MainClass.m_Define_Class.isAutoRun)
            //{
            //    m_MainClass.m_Define_Class.isAutoRun = false;
            //    btnAutoRun.BackColor = Color.LightGray;
            //    m_MainClass.m_PidClass.Disable();
            //}
            //else
            //{
            //}

        }

        private void btnValveOff_Click(object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('2');

                buff[7] = Convert.ToByte('0');
                buff[8] = Convert.ToByte('0');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[9] = (byte)Convert.ToChar(str1);
                buff[10] = (byte)Convert.ToChar(str2);

                buff[11] = 0x03;

                serialPort.Write(buff, 0, 12);
            }
        }

        private void btnIntStart_Click(object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('3');

                buff[7] = Convert.ToByte('0');
                buff[8] = Convert.ToByte('1');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[9] = (byte)Convert.ToChar(str1);
                buff[10] = (byte)Convert.ToChar(str2);

                buff[11] = 0x03;

                serialPort.Write(buff, 0, 12);
            }
        }

        private void btnIntStop_Click(object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('3');

                buff[7] = Convert.ToByte('0');
                buff[8] = Convert.ToByte('0');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[9] = (byte)Convert.ToChar(str1);
                buff[10] = (byte)Convert.ToChar(str2);

                buff[11] = 0x03;

                serialPort.Write(buff, 0, 12);
            }
        }

        private void btnIntReset_Click(object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('3');

                buff[7] = Convert.ToByte('0');
                buff[8] = Convert.ToByte('8');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[9] = (byte)Convert.ToChar(str1);
                buff[10] = (byte)Convert.ToChar(str2);

                buff[11] = 0x03;

                serialPort.Write(buff, 0, 12);
            }
        }



        private void radTrackBar2_ValueChanged(object sender, System.EventArgs e)
        {
            float aSingl = radTrackBar2.Value;
            string str = BitConverter.ToString(BitConverter.GetBytes(aSingl));

            if (serialPort.IsOpen)
            {
                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('9');

                buff[7] = Convert.ToByte(Convert.ToChar(str.Substring(0, 1)));
                buff[8] = Convert.ToByte(Convert.ToChar(str.Substring(1, 1)));

                buff[9] = Convert.ToByte(Convert.ToChar(str.Substring(3, 1)));
                buff[10] = Convert.ToByte(Convert.ToChar(str.Substring(4, 1)));

                buff[11] = Convert.ToByte(Convert.ToChar(str.Substring(6, 1)));
                buff[12] = Convert.ToByte(Convert.ToChar(str.Substring(7, 1)));
                
                buff[13] = Convert.ToByte(Convert.ToChar(str.Substring(9, 1)));
                buff[14] = Convert.ToByte(Convert.ToChar(str.Substring(10, 1)));

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8] ^ buff[9] ^ buff[10] ^ buff[11] ^ buff[12] ^ buff[13] ^ buff[14];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[15] = (byte)Convert.ToChar(str1);
                buff[16] = (byte)Convert.ToChar(str2);

                buff[17] = 0x03;

                serialPort.Write(buff, 0, 18);

            }
        }


        private void timer1_Tick(object sender, System.EventArgs e)
        {

            tbCurrentTemp.Text = m_MainClass.stTempSensor.fCurrentTemp.ToString();
            tbSetTemp.Text = m_MainClass.stTempSensor.fTargetTemp.ToString();
            
            tbCurrentFlow.Text = m_MainClass.stMfcController.fCurrentFlow.ToString();
            tbSetFlow.Text = m_MainClass.stMfcController.fTargetFlow.ToString();

            radialGaugeNeedle1.Value = m_MainClass.stTempSensor.fCurrentTemp;
            radialGaugeNeedle2.Value = m_MainClass.stTempSensor.fTargetTemp;

            radLinearGauge1.Value = m_MainClass.stMfcController.fCurrentFlow;
            linearGaugeNeedleIndicator1.Value = m_MainClass.stMfcController.fTargetFlow;


            // isRun PID Controller 
            if(m_MainClass.m_Define_Class.isAutoRun)
            {   
                m_MainClass.stPIDGain.PV = m_MainClass.stTempSensor.fCurrentTemp;
                m_MainClass.stPIDGain.SP = m_MainClass.stTempSensor.fTargetTemp;
                m_MainClass.stMfcController.fTargetFlow = getLimited_PID_OV(m_MainClass.stPIDGain.OV); // Convert.ToSingle(m_MainClass.stPIDGain.OV);

                Console.WriteLine("PID Controller Running............");
                Console.Write("PV : " + m_MainClass.stPIDGain.PV);
                Console.Write(", SP : " + m_MainClass.stPIDGain.SP);
                Console.WriteLine(", OV : " + m_MainClass.stPIDGain.OV);


                if (serialPort.IsOpen)
                {
                    string str = BitConverter.ToString(BitConverter.GetBytes(m_MainClass.stMfcController.fTargetFlow));

                    buff[0] = 0x02;

                    buff[1] = Convert.ToByte('0');
                    buff[2] = Convert.ToByte('1');

                    buff[3] = Convert.ToByte('D');

                    buff[4] = Convert.ToByte('w');

                    buff[5] = Convert.ToByte('0');
                    buff[6] = Convert.ToByte('9');

                    buff[7] = Convert.ToByte(Convert.ToChar(str.Substring(0, 1)));
                    buff[8] = Convert.ToByte(Convert.ToChar(str.Substring(1, 1)));

                    buff[9] = Convert.ToByte(Convert.ToChar(str.Substring(3, 1)));
                    buff[10] = Convert.ToByte(Convert.ToChar(str.Substring(4, 1)));

                    buff[11] = Convert.ToByte(Convert.ToChar(str.Substring(6, 1)));
                    buff[12] = Convert.ToByte(Convert.ToChar(str.Substring(7, 1)));

                    buff[13] = Convert.ToByte(Convert.ToChar(str.Substring(9, 1)));
                    buff[14] = Convert.ToByte(Convert.ToChar(str.Substring(10, 1)));

                    // check sum 
                    int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8] ^ buff[9] ^ buff[10] ^ buff[11] ^ buff[12] ^ buff[13] ^ buff[14];
                    string str1 = checksum.ToString("X2").Substring(0, 1);
                    string str2 = checksum.ToString("X2").Substring(1, 1);

                    buff[15] = (byte)Convert.ToChar(str1);
                    buff[16] = (byte)Convert.ToChar(str2);

                    buff[17] = 0x03;

                    serialPort.Write(buff, 0, 18);

                }
            }

            

            //AnimatedPropertySetting setting = new AnimatedPropertySetting(
            //    RadLinearGaugeElement.ValueProperty,
            //    radialGaugeNeedle2.Value,
            //    aSingl,
            //    12,
            //    40);
            //setting.ApplyEasingType = RadEasingType.OutBounce;
            //setting.ApplyValue(radRadialGauge1.GaugeElement);




            // Request Current Flow 
            buff[0] = 0x02;

            buff[1] = Convert.ToByte('0');
            buff[2] = Convert.ToByte('1');

            buff[3] = Convert.ToByte('D');

            buff[4] = Convert.ToByte('R');

            buff[5] = Convert.ToByte('0');
            buff[6] = Convert.ToByte('4');
            
            // check sum 
            int checksum1 = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6];
            string str11 = checksum1.ToString("X2").Substring(0, 1);
            string str21 = checksum1.ToString("X2").Substring(1, 1);

            buff[7] = (byte)Convert.ToChar(str11);
            buff[8] = (byte)Convert.ToChar(str21);

            buff[9] = 0x03;

            serialPort.Write(buff, 0, 10);
            


            
        }




        public float getLimited_PID_OV(double ov)
        {
            float f = 0.0f;

            f = Convert.ToSingle(ov);


            return f;
        }
            


        public void startGetTempSensorData()
        {
            byte[] buff = new byte[20];
            buff[0] = Convert.ToByte('(');
            buff[1] = Convert.ToByte('C');
            buff[2] = Convert.ToByte('0');
            buff[3] = Convert.ToByte('7');
            buff[4] = Convert.ToByte('1');
            buff[5] = Convert.ToByte('0');
            buff[6] = Convert.ToByte(')');
            buff[7] = Convert.ToByte(0x0A);

            //socket.Send(buff);
            socket.Send(buff, 0, 8, SocketFlags.None);
        }


        Socket socket;
        
        private void btnTCPStart_Click(object sender, System.EventArgs e)
        {
            SensorBoardTCPConnect();
        }

        private void SensorBoardTCPConnect()
        {
            try
            {
                if (socket != null) socket.Close();

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //IPAddress svrIp = IPAddress.Parse("192.168.0.115");
                //IPEndPoint ipep = new IPEndPoint(svrIp, 5555);
                IPAddress svrIp = IPAddress.Parse(m_MainClass.m_Define_Class.strSensorBoardIP);
                IPEndPoint ipep = new IPEndPoint(svrIp, m_MainClass.m_Define_Class.nSensorBoardPort);
 
                socket.Connect(ipep);

                if(socket.Connected)
                {
                    MessageBox.Show("접속성공");

                    ThreadStart();

                    m_MainClass.m_Define_Class.isConTempSensor = true;
                    btnTCPStart.BackColor = Color.Lime;

                    startGetTempSensorData();
                }
                else
                {
                    MessageBox.Show("접속실패");

                    m_MainClass.m_Define_Class.isConTempSensor = false;
                    btnTCPStart.BackColor = Color.LightGray;
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        public Thread NetworkThread;

        public void ThreadStart()
        {
            NetworkThread = new Thread(new ThreadStart(Receive));
            NetworkThread.Start();
        }

        public void ThreadAbort()
        {
            if (NetworkThread != null) NetworkThread.Abort();
            if (socket.Connected) socket.Close();
        }

        public void Receive()
        {
            while (true)
            {
                Thread.Sleep(500);
                byte[] data = new byte[2048];
                try
                {
                    long startTicks = DateTime.Now.Ticks;
                    int size = socket.Receive(data);

                    if (size < 0) 
                    {
                        SensorBoardTCPConnect();
                    }
                    else
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (data[i] == '(')
                            {
                                recvData = Convert.ToChar(data[i]).ToString();
                                recvStatus = true;
                            }
                            else if (data[i] == ')')
                            {
                                recvData += Convert.ToChar(data[i]).ToString();
                                //Console.WriteLine(recvData);
                                PacketAnalysTempSensor(recvData);
                            }
                            else
                            {
                                recvData += Convert.ToChar(data[i]).ToString();
                            }
                        }                          
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("에러 : " + ex.Message);
                }
            }
        }

        private void radLinearGauge1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            //buff[0] = 0x02;

            //buff[1] = Convert.ToByte('0');
            //buff[2] = Convert.ToByte('1');

            //buff[3] = Convert.ToByte('D');

            //buff[4] = Convert.ToByte('w');

            //buff[5] = Convert.ToByte('0');
            //buff[6] = Convert.ToByte('9');


            //buff[7] = Convert.ToByte('0');
            //buff[8] = Convert.ToByte('0');
            //buff[9] = Convert.ToByte('0');
            //buff[10] = Convert.ToByte('0');
            //buff[11] = Convert.ToByte('2');
            //buff[12] = Convert.ToByte('0');
            //buff[13] = Convert.ToByte('4');
            //buff[14] = Convert.ToByte('0');

            //// check sum 
            //int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8] ^ buff[9] ^ buff[10] ^ buff[11] ^ buff[12] ^ buff[13] ^ buff[14];
            //string str1 = checksum.ToString("X2").Substring(0, 1);
            //string str2 = checksum.ToString("X2").Substring(1, 1);

            //buff[15] = (byte)Convert.ToChar(str1);
            //buff[16] = (byte)Convert.ToChar(str2);

            //buff[17] = 0x03;

            //serialPort.Write(buff, 0, 18);











            //radChartView1.Area.Annotations.Add(this.appleAverage);
        }

        private void radTrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            float aSingl = radTrackBar1.Value;
            string str = BitConverter.ToString(BitConverter.GetBytes(aSingl));
            
            m_MainClass.stTempSensor.fTargetTemp = aSingl;


            //AnimatedPropertySetting setting = new AnimatedPropertySetting(
            //    RadLinearGaugeElement.ValueProperty,
            //    radialGaugeNeedle2.Value,
            //    aSingl,
            //    12,
            //    40);
            //setting.ApplyEasingType = RadEasingType.OutBounce;
            //setting.ApplyValue(radRadialGauge1.GaugeElement);

        }

        private void tbGain_D_TextChanged(object sender, EventArgs e)
        {
            m_MainClass.stPIDGain.kd = double.Parse(tbGain_D.Text);
        }

        private void tbGain_Input_Max_TextChanged(object sender, EventArgs e)
        {
            m_MainClass.stPIDGain.inputMax = double.Parse(tbGain_Input_Max.Text);
        }

        private void tbGain_Input_Min_TextChanged(object sender, EventArgs e)
        {
            m_MainClass.stPIDGain.inputMin = double.Parse(tbGain_Input_Min.Text);
        }

        private void tbGain_Output_Max_TextChanged(object sender, EventArgs e)
        {
            m_MainClass.stPIDGain.outMax = double.Parse(tbGain_Output_Max.Text);
        }

        private void tbGain_Output_Min_TextChanged(object sender, EventArgs e)
        {
            m_MainClass.stPIDGain.outMin = double.Parse(tbGain_Output_Min.Text);
        }

        private void tbGain_P_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.Enter)
                m_MainClass.stPIDGain.kp = double.Parse(tbGain_P.Text);
        }

        private void radChartView1_Click(object sender, EventArgs e)
        {

        }
    }
}