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
    public partial class Visu : UserControl
    {
        bool[] lastStateOfVariable = new bool[4];

        bool lastMotorLeft = false;
        bool lastMotorRight = false;

        bool lastStateOfMode = false;

        string plcAdressMode = "DB2.DBX16.0";
        string plcAdressRightMotor = "DB2.DBX16.1";
        string plcAdressLeftMotor = "DB2.DBX16.2";

        List<Label> Variables = new();


        Timer MyTimer = new();
        
        public Visu()
        {
            InitializeComponent();
        }

        private void Visu_Load(object sender, EventArgs e)
        {

            //Inicjalizacja wyswietlania zmiennych
            Variables.Add(Var1);
            Variables.Add(Var2);
            Variables.Add(Var3);
            Variables.Add(Var4);
            Variables.Add(Var5);
            Variables.Add(Var6);
            Variables.Add(Var7);
            Variables.Add(Var8);

            varName1.Text = "Zmienna 1";
            varName2.Text = "Zmienna 2";
            varName3.Text = "Zmienna 3";
            varName4.Text = "Zmienna 4";
            varName5.Text = "Zmienna 5";
            varName6.Text = "Zmienna 6";
            varName7.Text = "Zmienna 7";
            varName8.Text = "Zmienna 8";

            //Inicjalizacja 
            for(int i = 0;i<4;i++)
            {
                lastStateOfVariable[i] = false;
            }
            //inicjalizacja timera
            MyTimer.Enabled = true;
            MyTimer.Interval = (100);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();

            //Inicjalizacja obrazów Led
            pictureBox1.Image = Properties.Resources.ledoff;
            pictureBox2.Image = Properties.Resources.ledoff;
            pictureBox3.Image = Properties.Resources.ledoff;
            pictureBox4.Image = Properties.Resources.ledoff;

            //Inicjalizacja animacji ruchu
            pictureBoxMoveLeft.Enabled = false;
            pictureBoxMoveLeft.Hide();
            pictureBoxMoveRight.Enabled = false;
            pictureBoxMoveRight.Hide();

        }
        
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // Wyswietlanie pracy silnikow
            if (lastMotorLeft != FormMain.readStructure.motorLeft)
            {
                if (FormMain.readStructure.motorLeft)
                {
                    pictureBoxMoveLeft.Enabled = true;
                    pictureBoxMoveLeft.Show();

                    pictureBoxMoveRight.Enabled = false;
                    pictureBoxMoveRight.Hide();
                }
                else
                {
                    pictureBoxMoveLeft.Enabled = false;
                    pictureBoxMoveLeft.Hide();

                    pictureBoxMoveRight.Enabled = false;
                    pictureBoxMoveRight.Hide();
                }
            }
            if (lastMotorRight != FormMain.readStructure.motorRight)
            {
                if (FormMain.readStructure.motorRight)
                {
                    pictureBoxMoveRight.Enabled = true;
                    pictureBoxMoveRight.Show();

                    pictureBoxMoveLeft.Enabled = false;
                    pictureBoxMoveLeft.Hide();
                }
                else
                {
                    pictureBoxMoveRight.Enabled = false;
                    pictureBoxMoveRight.Hide();

                    pictureBoxMoveLeft.Enabled = false;
                    pictureBoxMoveLeft.Hide();
                }
            }
            lastMotorLeft = FormMain.readStructure.motorLeft;
            lastMotorRight = FormMain.readStructure.motorRight;

            //Wyswietlanie stanu diod
            bool[] currentStateOfVariable = new bool[4];

            currentStateOfVariable[0] = FormMain.readStructure.led1;
            currentStateOfVariable[1] = FormMain.readStructure.led2;
            currentStateOfVariable[2] = FormMain.readStructure.led3;
            currentStateOfVariable[3] = FormMain.readStructure.led4;

            if(currentStateOfVariable!=lastStateOfVariable)
            {

                if (currentStateOfVariable[0])
                {
                    pictureBox1.Image = Properties.Resources.ledon;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.ledoff;
                }

                if (currentStateOfVariable[1])
                {
                    pictureBox2.Image = Properties.Resources.ledon;
                }
                else
                {
                    pictureBox2.Image = Properties.Resources.ledoff;
                }

                if (currentStateOfVariable[2])
                {
                    pictureBox3.Image = Properties.Resources.ledon;
                }
                else
                {
                    pictureBox3.Image = Properties.Resources.ledoff;
                }

                if (currentStateOfVariable[3])
                {
                    pictureBox4.Image = Properties.Resources.ledon;
                }
                else
                {
                    pictureBox4.Image = Properties.Resources.ledoff;
                }


            }
            lastStateOfVariable = currentStateOfVariable;

            //Wyswietlanie trybu pracy
            if (FormMain.readStructure.mode != lastStateOfMode)
            {
                if (FormMain.readStructure.mode) // Auto
                {
                    btnAuto.BackColor = System.Drawing.Color.LimeGreen;
                    btnManual.BackColor = System.Drawing.Color.Gray;

                    btnLeft.Enabled = false;
                    btnRight.Enabled = false;
                    btnStop.Enabled = false;
                    btnAuto.Enabled = false;
                    btnManual.Enabled = true;
                }
                else // Manual
                {
                    btnManual.BackColor = System.Drawing.Color.LimeGreen;
                    btnAuto.BackColor = System.Drawing.Color.Gray;

                    btnLeft.Enabled = true;
                    btnRight.Enabled = true;
                    btnStop.Enabled = true;
                    btnAuto.Enabled = true;
                    btnManual.Enabled = false;
                }
            }
            lastStateOfMode = FormMain.readStructure.mode;

            //Wyswietlanie zmiennych
            float[] analogTable = FormMain.GetAnalogVariables();
            int i = 0;
            foreach(Label variable in Variables)
            {
                variable.Text = MathF.Round(analogTable[i],2).ToString();
                i++;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    if (!FormMain.readStructure.mode)
                        FormMain.plc.Write(plcAdressMode, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMain.plc.IsConnected)
                {
                    if (FormMain.readStructure.mode)
                    {
                        FormMain.plc.Write(plcAdressMode, false);
                        FormMain.plc.Write(plcAdressRightMotor, false);
                        FormMain.plc.Write(plcAdressLeftMotor, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!FormMain.readStructure.mode)
            {
                try
                {
                    if (FormMain.plc.IsConnected)
                    {
                        FormMain.plc.Write(plcAdressRightMotor, true);
                        FormMain.plc.Write(plcAdressLeftMotor, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!FormMain.readStructure.mode)
            {
                try
                {
                    if (FormMain.plc.IsConnected)
                    {
                        FormMain.plc.Write(plcAdressRightMotor, false);
                        FormMain.plc.Write(plcAdressLeftMotor, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!FormMain.readStructure.mode)
            {
                try
                {
                    if (FormMain.plc.IsConnected)
                    {
                        FormMain.plc.Write(plcAdressRightMotor, false);
                        FormMain.plc.Write(plcAdressLeftMotor, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
