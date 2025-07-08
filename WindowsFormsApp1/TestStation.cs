using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;     
using System.Threading;    


namespace WindowsFormsApp1
{
    public partial class TestStation : Form
    {
        private SerialPort serialPortRx = new SerialPort();
        private SerialPort serialPortTx = new SerialPort();

        public int BtnTestSend_Click { get; }

        public TestStation()
        {
            InitializeComponent();
            serialPortRx.DataReceived += SerialPortRx_DataReceived;
            serialPortRx.ErrorReceived += SerialPortRx_ErrorReceived;
            this.Load += TestStation_Load;
            
        }

        private void SerialPortRx_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SerialPortRx_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Mevcut COM portlarını listelemek için
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblRxGyroYCaption_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblRxStateCaption_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tlpRxData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRxCounterCaption_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblRxStageLngCaption_Click(object sender, EventArgs e)
        {

        }

        private void TestStation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void RxPortSetting_Click(object sender, EventArgs e)
        {

        }

        private void RxPortOn_Click(object sender, EventArgs e)
        {

        }

        private void TxPortSetting_Click(object sender, EventArgs e)
        {

        }

        private void TxPortOn_Click(object sender, EventArgs e)
        {

        }

        private void TxDataSend_Click(object sender, EventArgs e)
        {

        }

        private void lblRxAltitudeCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxGpsAltitudeCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxLngCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxPayloadGpsAltCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxPayloadLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxPayloadLngCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxStageGpsAltCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxStageLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxGyroXCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxGyroZCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxAccelYCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxAccelZCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxAngleCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRxCrcCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxTeamIdCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxCounterCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxAltitudeCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxLngCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxPayloadLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxStageGpsAltCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxStageLatCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxStageLngCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxGyroXCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxGyroYCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxGyroZCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxAccelXCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxAccelYCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxAccelZCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxAngleCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxStateCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblTxCrcCaption_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }
    }
}
