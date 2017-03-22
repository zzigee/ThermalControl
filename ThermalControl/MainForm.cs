using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ThermalControl
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private MainClass m_MainClass;
        
        private LiveData model;

        Font font = new Font("온도제어", 12F, System.Drawing.FontStyle.Regular);
        
        public MainForm()
        {

            // 메인클래스 객체 생성
            this.m_MainClass = new MainClass(this);
            this.model = new LiveData(this);


            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        byte[] buff = new byte[20];

        private void MainForm_Load(object sender, EventArgs e)
        {
            model.StartTimer();
            timer1.Start();


            // Serial Port Open
            try
            {
                serialPort.Open();

                buff[0] = 0x02;

                buff[1] = Convert.ToByte('0');
                buff[2] = Convert.ToByte('1');

                buff[3] = Convert.ToByte('D');

                buff[4] = Convert.ToByte('w');

                buff[5] = Convert.ToByte('0');
                buff[6] = Convert.ToByte('1');

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[7] = (byte)Convert.ToChar(str1);
                buff[8] = (byte)Convert.ToChar(str2);

                buff[9] = 0x03;

                serialPort.Write(buff, 0, 10);

            }

            catch (Exception ex)
            {
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

        private void radButton2_Click(object sender, System.EventArgs e)
        {

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
            int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6];
            string str1 = checksum.ToString("X2").Substring(0, 1);
            string str2 = checksum.ToString("X2").Substring(1, 1);

            buff[9] = (byte)Convert.ToChar(str1);
            buff[10] = (byte)Convert.ToChar(str2);

            buff[11] = 0x03;




            serialPort.Write(buff, 0, 12);
        }





        public void SerialPacketAnalysis(string data, int i)
        {
            string str = ""; 

            Console.WriteLine(data);

            float ff = 0.0f;

            if(data.Length > 10)
            {
                if(data.Substring(4, 2) == "09")        // To set target flow 
                {
                    string ss = data.Substring(6, 8);
                    string sss = "";

                    sss += ss.Substring(6, 2);
                    sss += ss.Substring(4, 2);
                    sss += ss.Substring(2, 2);
                    sss += ss.Substring(0, 2);

                    uint num = uint.Parse(sss, System.Globalization.NumberStyles.AllowHexSpecifier);
                    byte[] bb = BitConverter.GetBytes(num);
                    ff = BitConverter.ToSingle(bb, i);
                    byte[] bbb = { 0x00, 0x00, 0x00, 0x00 };
                    ff = BitConverter.ToSingle(bbb, 0);


                }
                else if(data.Substring(4, 2) == "04")   // to read current flow 
                {
                    string ss = data.Substring(6, 8);
                    string sss = "";

                    sss += ss.Substring(6, 2);
                    sss += ss.Substring(4, 2);
                    sss += ss.Substring(2, 2);
                    sss += ss.Substring(0, 2);

                    uint num = uint.Parse(sss, System.Globalization.NumberStyles.AllowHexSpecifier);
                    byte[] bb = BitConverter.GetBytes(num);
                    ff = BitConverter.ToSingle(bb, i);
                    byte[] bbb = { 0x00, 0x00, 0x00, 0x00 };
                    ff = BitConverter.ToSingle(bbb, 0);
                }

                radLinearGauge1.Value = ff;
            }
        }

        string strRxData = "";
        int nReceiveCount = 0;

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //string message = serialPort.ReadExisting();
            //System.Console.WriteLine("Receive Message : " + message);

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
                    else if(data == (byte)DefineClass.DMFC_PROTOCOL.ETX)
                    {
                        nReceiveCount = 0;
                        strRxData += data;

                        SerialPacketAnalysis(strRxData, 0);
                    }
                    else
                    {
                        nReceiveCount++;
                        strRxData += data;
                    }
  
                }

                
            }
        }






        public double PV, SP, OV;

        public GetDouble readPV;
        public GetDouble readSP;
        public SetDouble writeOV;


        public double setPV() { return PV; }
        public double setSP() { return SP; }
        public void getOV(double OV) { this.OV = OV; }
        
        PID pidClass;

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            PV = 100;
            SP = 10000;

            readPV = new GetDouble(setPV);
            readSP = new GetDouble(setSP);
            writeOV = new SetDouble(getOV);

            pidClass = new PID(100.0, 1.0, 0.1, 100, -100, 100, -100, readPV, readSP, writeOV);
            pidClass.Enable();

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
            socket.Send(buff, 0, 7, SocketFlags.None);
            


            /*
            The Compute routine is where the meat of the algorithm lies. Basically, it starts out reading the process variable (pv) and set point (sp). It then Clamp's them to pvMin and pvMax, then scales them so they are a percentage between -100% and 100% of the scale. It then figures out the error percentage and starts running the PID calculation.

            The calculation is pretty simple; it starts out finding the pTerm, which is the error times the gain (kp). Then, inside the if statement, we do what is called anti-windup reset, where we only calculate the iTerm if the process variable isn't pegged at or above the process variable range. This helps to limit the output of the system, and keeps the error from blowing up when the process variable gets out of range.

            The last thing it does is simply sum the three terms to obtain the output value, clamp it to +/-100% of the output range, then scale it to come up with a real output number. It then uses the SetDouble delegate called writeOV (write output variable) to set the output value.

            And there you have it. If we have a more real-time or critical process, we can set the runThread priority to something higher, but I wouldn't recommend going above "High" since it will cause other things to become preempted too often.

            This is a very versatile class; setting the I gain term to zero will give you a PD controller, and if you wanted, you could have a strictly P controller by setting both the I and D gains to zero.
            */



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
            //System.Console.WriteLine("Send Message : " + System.Text.Encoding.ASCII.GetString(buff));
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
            Console.WriteLine(radTrackBar2.Value);

            float aSingl = radTrackBar2.Value;
            string str = BitConverter.ToString(BitConverter.GetBytes(aSingl));
            Console.WriteLine(str);


            linearGaugeNeedleIndicator1.Value = aSingl;
            linearGaugeNeedleIndicator1.DrawValue = true;



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

                // check sum 
                int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8] ^ buff[9] ^ buff[10] ^ buff[11] ^ buff[12];
                string str1 = checksum.ToString("X2").Substring(0, 1);
                string str2 = checksum.ToString("X2").Substring(1, 1);

                buff[13] = (byte)Convert.ToChar(str1);
                buff[14] = (byte)Convert.ToChar(str2);

                buff[15] = 0x03;

                serialPort.Write(buff, 0, 16);
            }
        }


        private void timer1_Tick(object sender, System.EventArgs e)
        {
            //radLinearGauge1.Value = liev


            //Console.WriteLine("PV : " + PV);
            //Console.WriteLine("SP : " + SP);
            //Console.WriteLine("OV : " + OV);




            /*
            buff[0] = 0x02;

            buff[1] = Convert.ToByte('0');
            buff[2] = Convert.ToByte('1');

            buff[3] = Convert.ToByte('D');

            buff[4] = Convert.ToByte('R');

            buff[5] = Convert.ToByte('0');
            buff[6] = Convert.ToByte('4');
            
            // check sum 
            int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6];
            string str1 = checksum.ToString("X2").Substring(0, 1);
            string str2 = checksum.ToString("X2").Substring(1, 1);

            buff[7] = (byte)Convert.ToChar(str1);
            buff[8] = (byte)Convert.ToChar(str2);

            buff[9] = 0x03;

            serialPort.Write(buff, 0, 10);
             * */



             


        }

        Socket socket;
        
        private void btnTCPStart_Click(object sender, System.EventArgs e)
        {
            TCPConnect();
        }

        private void TCPConnect()
        {
            try
            {
                if (socket != null) socket.Close();

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress svrIp = IPAddress.Parse("192.168.0.115");
                IPEndPoint ipep = new IPEndPoint(svrIp, 5555);
 
                socket.Connect(ipep);

                if(socket.Connected)
                {
                    MessageBox.Show("접속성공");

                    ThreadStart();
                }
                else
                {
                    MessageBox.Show("접속실패");
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

        int recvCnt;
        string recvData;
        bool recvStatus;
        
        public void PacketAnalysis(string data)
        {
            string tt = ""; 

            if(data.Length > 8)
            {
                if (data.Length == 12) tt = data.Substring(5, 6);
                else if (data.Length == 13) tt = data.Substring(5, 7);
            }

            Console.WriteLine(tt);

            linearGaugeBar1.Text = float.Parse(tt).ToString();


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
                        TCPConnect();
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

                                PacketAnalysis(recvData);
                            }
                            else
                            {
                                recvData += Convert.ToChar(data[i]).ToString();
                            }
                                


                            //Console.Write(Convert.ToChar(data[i]));
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
            buff[0] = 0x02;

            buff[1] = Convert.ToByte('0');
            buff[2] = Convert.ToByte('1');

            buff[3] = Convert.ToByte('D');

            buff[4] = Convert.ToByte('w');

            buff[5] = Convert.ToByte('0');
            buff[6] = Convert.ToByte('9');


            buff[7] = Convert.ToByte('0');
            buff[8] = Convert.ToByte('0');
            buff[9] = Convert.ToByte('0');
            buff[10] = Convert.ToByte('0');
            buff[11] = Convert.ToByte('2');
            buff[12] = Convert.ToByte('0');
            buff[13] = Convert.ToByte('4');
            buff[14] = Convert.ToByte('0');

            // check sum 
            int checksum = buff[1] ^ buff[2] ^ buff[3] ^ buff[4] ^ buff[5] ^ buff[6] ^ buff[7] ^ buff[8] ^ buff[9] ^ buff[10] ^ buff[11] ^ buff[12] ^ buff[13] ^ buff[14];
            string str1 = checksum.ToString("X2").Substring(0, 1);
            string str2 = checksum.ToString("X2").Substring(1, 1);

            buff[15] = (byte)Convert.ToChar(str1);
            buff[16] = (byte)Convert.ToChar(str2);

            buff[17] = 0x03;

            serialPort.Write(buff, 0, 18);
        }

        private void radTrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            Console.WriteLine(radTrackBar1.Value);

            float aSingl = radTrackBar1.Value;
            string str = BitConverter.ToString(BitConverter.GetBytes(aSingl));
            Console.WriteLine(str);

            radialGaugeNeedle1.Value = aSingl;
            radialGaugeNeedle2.Value = aSingl;


            //AnimatedPropertySetting setting = new AnimatedPropertySetting(
            //    RadLinearGaugeElement.ValueProperty,
            //    radialGaugeNeedle2.Value,
            //    aSingl,
            //    12,
            //    40);
            //setting.ApplyEasingType = RadEasingType.OutBounce;
            //setting.ApplyValue(radRadialGauge1.GaugeElement);

        }
    }
}