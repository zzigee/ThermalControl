using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThermalControl
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {

        private MainClass m_MainClass;


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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_MainClass.m_TCPClass.StartClient();
        }
    }
}
