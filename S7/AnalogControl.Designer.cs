
namespace S7
{
    partial class AnalogControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.varSet = new System.Windows.Forms.TextBox();
            this.varName = new System.Windows.Forms.Label();
            this.varAnalog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(77, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ustaw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // varSet
            // 
            this.varSet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.varSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varSet.Location = new System.Drawing.Point(155, 38);
            this.varSet.Name = "varSet";
            this.varSet.Size = new System.Drawing.Size(72, 29);
            this.varSet.TabIndex = 1;
            this.varSet.Text = "Wartosc";
            // 
            // varName
            // 
            this.varName.AutoSize = true;
            this.varName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.varName.Location = new System.Drawing.Point(15, 6);
            this.varName.Name = "varName";
            this.varName.Size = new System.Drawing.Size(123, 20);
            this.varName.TabIndex = 3;
            this.varName.Text = "Nazwa zmiennej";
            // 
            // varAnalog
            // 
            this.varAnalog.AutoSize = true;
            this.varAnalog.BackColor = System.Drawing.Color.Transparent;
            this.varAnalog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varAnalog.Location = new System.Drawing.Point(1, 2);
            this.varAnalog.Margin = new System.Windows.Forms.Padding(0);
            this.varAnalog.Name = "varAnalog";
            this.varAnalog.Size = new System.Drawing.Size(71, 21);
            this.varAnalog.TabIndex = 2;
            this.varAnalog.Text = "Zmienna";
            this.varAnalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.varAnalog.Click += new System.EventHandler(this.varAnalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zadaj wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.varAnalog);
            this.panel1.Location = new System.Drawing.Point(155, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 29);
            this.panel1.TabIndex = 8;
            // 
            // AnalogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varName);
            this.Controls.Add(this.varSet);
            this.Controls.Add(this.button1);
            this.Name = "AnalogControl";
            this.Size = new System.Drawing.Size(230, 115);
            this.Load += new System.EventHandler(this.AnalogControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox varSet;
        public System.Windows.Forms.Label varName;
        public System.Windows.Forms.Label varAnalog;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
