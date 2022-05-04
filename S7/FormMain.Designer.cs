
namespace S7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnVisu = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucMeasurements = new S7.Measurements();
            this.ucControl = new S7.Control();
            this.ucVisu = new S7.Visu();
            this.ucInfo = new S7.Info();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.LabelStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.Location = new System.Drawing.Point(1250, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.ForeColor = System.Drawing.Color.Sienna;
            this.LabelStatus.Location = new System.Drawing.Point(3, 12);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(39, 15);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.btnCharts);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.btnDisconnect);
            this.panel2.Controls.Add(this.btnControl);
            this.panel2.Controls.Add(this.btnVisu);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 690);
            this.panel2.TabIndex = 1;
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnCharts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharts.FlatAppearance.BorderSize = 0;
            this.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCharts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btnCharts.Location = new System.Drawing.Point(0, 253);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(200, 34);
            this.btnCharts.TabIndex = 5;
            this.btnCharts.Text = "Pomiary";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(172)))), ((int)(((byte)(28)))));
            this.btnConnect.Location = new System.Drawing.Point(0, 602);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 37);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnDisconnect.Location = new System.Drawing.Point(0, 637);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(200, 41);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Rozłącz";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btnControl.Location = new System.Drawing.Point(0, 210);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(200, 37);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "Sterowanie";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnVisu
            // 
            this.btnVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnVisu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisu.FlatAppearance.BorderSize = 0;
            this.btnVisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btnVisu.Location = new System.Drawing.Point(0, 165);
            this.btnVisu.Name = "btnVisu";
            this.btnVisu.Size = new System.Drawing.Size(200, 39);
            this.btnVisu.TabIndex = 1;
            this.btnVisu.Text = "Wizualizacja";
            this.btnVisu.UseVisualStyleBackColor = false;
            this.btnVisu.Click += new System.EventHandler(this.btnVisu_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btnInfo.Location = new System.Drawing.Point(0, 95);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 34);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Informacje";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.ucMeasurements);
            this.panel3.Controls.Add(this.ucControl);
            this.panel3.Controls.Add(this.ucVisu);
            this.panel3.Controls.Add(this.ucInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 690);
            this.panel3.TabIndex = 2;
            // 
            // ucMeasurements
            // 
            this.ucMeasurements.BackColor = System.Drawing.Color.Silver;
            this.ucMeasurements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMeasurements.Location = new System.Drawing.Point(0, 0);
            this.ucMeasurements.Name = "ucMeasurements";
            this.ucMeasurements.Size = new System.Drawing.Size(1080, 690);
            this.ucMeasurements.TabIndex = 6;
            // 
            // ucControl
            // 
            this.ucControl.BackColor = System.Drawing.Color.Silver;
            this.ucControl.Location = new System.Drawing.Point(0, 0);
            this.ucControl.Name = "ucControl";
            this.ucControl.Size = new System.Drawing.Size(1080, 690);
            this.ucControl.TabIndex = 3;
            // 
            // ucVisu
            // 
            this.ucVisu.BackColor = System.Drawing.Color.Silver;
            this.ucVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVisu.Location = new System.Drawing.Point(0, 0);
            this.ucVisu.Name = "ucVisu";
            this.ucVisu.Size = new System.Drawing.Size(1080, 690);
            this.ucVisu.TabIndex = 2;
            // 
            // ucInfo
            // 
            this.ucInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInfo.Location = new System.Drawing.Point(0, 0);
            this.ucInfo.Name = "ucInfo";
            this.ucInfo.Size = new System.Drawing.Size(1080, 690);
            this.ucInfo.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnVisu;
        private System.Windows.Forms.Button btnInfo;
        private Info ucInfo;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label LabelStatus;
        private Visu ucVisu;
        private Control ucControl;
        private System.Windows.Forms.Button btnCharts;
        private Measurements ucMeasurements;
        private System.Windows.Forms.Button btnConnect;
    }
}