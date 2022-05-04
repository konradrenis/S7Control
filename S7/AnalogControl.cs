using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace S7
{
    public partial class AnalogControl : UserControl
    {

        public string varAdress;
        public string varNameText;
        public string variable;
 
        Timer ControlTimer = new();

        public AnalogControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendToPLC();
        }

        private void AnalogControl_Load(object sender, EventArgs e)
        {
            ControlTimer.Enabled = true;
            ControlTimer.Interval = (1000);
            ControlTimer.Tick += new EventHandler(ControlTimer_Tick);
            ControlTimer.Start();

        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            ReceiveFromPLC();
        }


        private void SendToPLC()
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    FormMain.plc.Write(varAdress, (float)Convert.ToDouble(varSet.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveFromPLC()
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    float temp = BitConverter.ToSingle(BitConverter.GetBytes((UInt32)FormMain.plc.Read(variable)));
                    varAnalog.Text = temp.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void varAnalog_Click(object sender, EventArgs e)
        {

        }
    }
}
