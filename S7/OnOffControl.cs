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
    public partial class OnOffControl : UserControl
    {
        public OnOffControl()
        {
            InitializeComponent();
        }
        bool boolLastState = false;
        bool boolCurrentState = true;

        Timer ControlTimer = new();

        public string adressOn;
        public string adressOff;
        public bool boolVariable;

        private void btnOn_Click(object sender, EventArgs e)
        {
            SetOnPlc(btnOn, btnOff, pictureBox, adressOn);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ResetOnPlc(btnOn, btnOff, pictureBox, adressOff);
        }

 

        private void SetOnPlc(Button btnOn, Button btnOff, PictureBox pictureBox, string sendBoolTo)
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    FormMain.plc.Write(sendBoolTo, true);
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

        private void OnOffControl_Load(object sender, EventArgs e)
        {
            if (boolVariable)
            {
                pictureBox.BackColor = Color.LimeGreen;
                btnOff.Enabled = true;
                btnOn.Enabled = false;
            }
            else
            {
                pictureBox.BackColor = Color.Red;
                btnOff.Enabled = false;
                btnOn.Enabled = true;
            }

            ControlTimer.Enabled = true;
            ControlTimer.Interval = (1000);
            ControlTimer.Tick += new EventHandler(ControlTimer_Tick);
            ControlTimer.Start();
        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            if (FormMain.plc.IsConnected)
            {
                boolCurrentState = boolVariable;
                if (boolLastState != boolCurrentState)
                {
                    if (boolCurrentState)
                    {
                        pictureBox.BackColor = Color.LimeGreen;
                        btnOff.Enabled = true;
                        btnOn.Enabled = false;
                    }
                    else
                    {
                        pictureBox.BackColor = Color.Red;
                        btnOff.Enabled = false;
                        btnOn.Enabled = true;
                    }
                }
                boolLastState = boolCurrentState;
            }
        }

    }
}
