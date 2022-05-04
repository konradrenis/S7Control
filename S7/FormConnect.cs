using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using S7.Net;

namespace S7
{
    public partial class FormConnect : Form
    {
        public static FormConnect Instance = new();

        public FormConnect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text)) throw new Exception("Wprowadź poprawny adres IP");
                CpuType cpuType = CpuType.S71200;
                string ipAddress = textBox1.Text;
                short rack = 0;
                short slot = 1;
                
                FormMain.plc = new Plc(cpuType, ipAddress, rack, slot);
                FormMain.plc.Open();
                if (!FormMain.plc.IsConnected) throw new Exception("Nie udało się nawiązać połączenia z PLC");
                FormMain.buttonConnect.Enabled = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormMain.plc.IsConnected)
            {
                FormMain.buttonConnect.Enabled = true;
            }
        }
    }
}
