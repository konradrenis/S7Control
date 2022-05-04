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
    public partial class FormMain : Form
    {
        public static FormMain Instance = new();
        public static Plc plc = new Plc(CpuType.S71200," ",0,1);
        public static Button buttonConnect = new();
        public static Button buttonDisconnect = new();
       
        public struct ReadStructure
        {
            //Pomiary analogowe
            public float varMeasurement1;
            public float varMeasurement2;
            public float varMeasurement3;
            public float varMeasurement4;

            //Pomiary analogowe sterowane
            public float varAnalog1;
            public float varAnalog2;
            public float varAnalog3;
            public float varAnalog4;

            //Stan silników
            public bool motorLeft;
            public bool motorRight;

            //Stan diód LED
            public bool led1;
            public bool led2;
            public bool led3;
            public bool led4;

            //Stan czujników
            public bool barrier;
            public bool sensor1;
            public bool sensor2;
            public bool sensor3;

            public bool mode; // 1 - auto, 0- manual

            public bool res1;
            public bool res2;
            public bool res3;
            public bool res4;
            public bool res5;
        }
        public static ReadStructure readStructure;

        public static Data readData = new();

        Timer MyTimer = new();

        public FormMain()
        {
            InitializeComponent();
            Instance = this;
            buttonConnect = btnConnect;
            buttonDisconnect = btnDisconnect;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ucInfo.Show();
            ucControl.Hide();
            ucVisu.Hide();
            ucInfo.BringToFront();

            MyTimer.Enabled = true;
            MyTimer.Interval = (100); 
            MyTimer.Tick += new EventHandler(ReadTimer);
            MyTimer.Start();

            this.LabelStatus.Text = "Brak połączenia";
        }

        private void ReadTimer(object sender, EventArgs e)
        {
            if (plc.IsConnected)
            {
                LabelStatus.Text = String.Concat("Połączono; IP: ", plc.IP);
                readStructure = (ReadStructure)plc.ReadStruct(typeof(ReadStructure), 1, 0);
            }
            else
            {
                LabelStatus.Text = "Brak połączenia";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ucInfo.Show();
            ucControl.Hide();
            ucVisu.Hide();
            ucMeasurements.Hide();
            ucInfo.BringToFront();
        }

        private void btnVisu_Click(object sender, EventArgs e)
        {
            ucInfo.Hide();
            ucControl.Hide();
            ucVisu.Show();
            ucMeasurements.Hide();
            ucVisu.BringToFront();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            ucInfo.Hide();
            ucControl.Show();
            ucVisu.Hide();
            ucMeasurements.Hide();
            ucControl.BringToFront();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            ucInfo.Hide();
            ucControl.Hide();
            ucVisu.Hide();
            ucMeasurements.Show();
            ucMeasurements.BringToFront();
        }

        //connect button
        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            FormConnect f = new FormConnect();
            f.Show();
            btnConnect.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
                btnConnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Przycisk zamknięcia
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(plc.IsConnected)
            {
                plc.Close();
            }

            this.Close();
        }

        private void ucVisu_Load(object sender, EventArgs e)
        {

        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                FormMain.Instance.Update();
            }
        }

        public static float[] GetAnalogVariables()
        {
            float[] table = new float[8];
            table[0] = readStructure.varMeasurement1;
            table[1] = readStructure.varMeasurement2;
            table[2] = readStructure.varMeasurement3;
            table[3] = readStructure.varMeasurement4;

            table[4] = readStructure.varAnalog1;
            table[5] = readStructure.varAnalog2;
            table[6] = readStructure.varAnalog3;
            table[7] = readStructure.varAnalog4;

            return table;
        }
    }
}
