using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S7
{
    public partial class Control : UserControl
    {

        bool boolLastState = false;
        bool boolCurrentState = true;

        Timer ControlTimer = new();
        public Control()
        {
            InitializeComponent();

            InitializeAnalog(ref analogControl1, "DB2.DBD0", "Zmienna 1", "DB1.DBD16");
            InitializeAnalog(ref analogControl2, "DB2.DBD4", "Zmienna 2", "DB1.DBD20");
            InitializeAnalog(ref analogControl3, "DB2.DBD8", "Zmienna 3", "DB1.DBD24");
            InitializeAnalog(ref analogControl4, "DB2.DBD12", "Zmienna 4", "DB1.DBD28");
        }

        
        private void SetOnPlc(Button btnOn, Button btnOff, PictureBox pictureBox, string sendBoolTo)
        {
            try
            {
                if(FormMain.plc.IsConnected)
                {
                    FormMain.plc.Write(sendBoolTo,true);
                    btnOn.Enabled = false;
                    btnOff.Enabled = true;
                    pictureBox.BackColor = Color.LimeGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ResetOnPlc(Button btnOn, Button btnOff, PictureBox pictureBox, string sendBoolTo)
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    FormMain.plc.Write(sendBoolTo, true);
                    btnOn.Enabled = true;
                    btnOff.Enabled = false;
                    pictureBox.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Control_Load(object sender, EventArgs e)
        {
            //Inicjalizacje przeniosłem wyżej
            webView21.Source = new Uri("http://192.168.3.3:3000/d/feddXckgk/tasmociag?&from=now-5m&to=now&viewPanel=13&refresh=20s&kiosk");
            webView22.Source = new Uri("http://192.168.3.3:3000/d/feddXckgk/tasmociag?&from=now-5m&to=now&viewPanel=14&refresh=20s&kiosk");
            webView23.Source = new Uri("http://192.168.3.3:3000/d/feddXckgk/tasmociag?&from=now-5m&to=now&viewPanel=15&refresh=20s&kiosk");
            webView24.Source = new Uri("http://192.168.3.3:3000/d/feddXckgk/tasmociag?&from=now-5m&to=now&viewPanel=16&refresh=20s&kiosk");


            //Inintialize timer
            ControlTimer.Enabled = true;
            ControlTimer.Interval = (1000);
            ControlTimer.Tick += new EventHandler(ControlTimer_Tick);
            ControlTimer.Start();
        }
         
        private void InitializeOnOff(OnOffControl onOffControl, OnOff onOff)
        {
            onOffControl.boolVariable = onOff.varBool;
            onOffControl.adressOn = onOff.adressOn;
            onOffControl.adressOff = onOff.adressOff;
        }
        private void InitializeAnalog(ref AnalogControl analogControl, string _adress, string _varNameText, string _variable)
        {
            analogControl.varName.Text = _varNameText;
            analogControl.varAdress = _adress;
            analogControl.variable = _variable;
        }
        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            if (FormMain.plc.IsConnected)
            {
                boolCurrentState = FormMain.readData.led1;
                if (boolLastState != boolCurrentState)
                {
                    if (boolCurrentState)
                    {
                        
                    }
                    else
                    {
                        
                    }
                }
                boolLastState = boolCurrentState;
            }
        }

        
    }
}
