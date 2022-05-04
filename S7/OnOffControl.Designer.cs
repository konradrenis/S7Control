
namespace S7
{
    partial class OnOffControl
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
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Location = new System.Drawing.Point(25, 16);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(100, 30);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(25, 204);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(100, 30);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(25, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // OnOffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Name = "OnOffControl";
            this.Size = new System.Drawing.Size(150, 250);
            this.Load += new System.EventHandler(this.OnOffControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
