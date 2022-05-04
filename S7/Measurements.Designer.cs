
namespace S7
{
    partial class Measurements
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
            this.title = new System.Windows.Forms.Label();
            this.wv1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wv2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wv3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wv4 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv4)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1080, 67);
            this.title.TabIndex = 1;
            this.title.Text = "Wykresy";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wv1
            // 
            this.wv1.CreationProperties = null;
            this.wv1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv1.Enabled = false;
            this.wv1.Location = new System.Drawing.Point(17, 106);
            this.wv1.Name = "wv1";
            this.wv1.Size = new System.Drawing.Size(500, 250);
            this.wv1.Source = new System.Uri("http://192.168.1.20:3000/d/0MuvOMzRz/new-dashboard?orgId=1&from=now-1h&to=now&ref" +
        "resh=10s&kiosk&viewPanel=4", System.UriKind.Absolute);
            this.wv1.TabIndex = 2;
            this.wv1.ZoomFactor = 1D;
            // 
            // wv2
            // 
            this.wv2.CreationProperties = null;
            this.wv2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv2.Enabled = false;
            this.wv2.Location = new System.Drawing.Point(564, 106);
            this.wv2.Name = "wv2";
            this.wv2.Size = new System.Drawing.Size(500, 250);
            this.wv2.TabIndex = 3;
            this.wv2.ZoomFactor = 1D;
            // 
            // wv3
            // 
            this.wv3.CreationProperties = null;
            this.wv3.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv3.Enabled = false;
            this.wv3.Location = new System.Drawing.Point(17, 390);
            this.wv3.Name = "wv3";
            this.wv3.Size = new System.Drawing.Size(500, 250);
            this.wv3.TabIndex = 4;
            this.wv3.ZoomFactor = 1D;
            // 
            // wv4
            // 
            this.wv4.CreationProperties = null;
            this.wv4.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv4.Enabled = false;
            this.wv4.Location = new System.Drawing.Point(564, 390);
            this.wv4.Name = "wv4";
            this.wv4.Size = new System.Drawing.Size(500, 250);
            this.wv4.TabIndex = 5;
            this.wv4.ZoomFactor = 1D;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(905, 57);
            this.comboBox.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox.MaxDropDownItems = 10;
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(159, 29);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(809, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ustaw czas";
            // 
            // Measurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.wv4);
            this.Controls.Add(this.wv3);
            this.Controls.Add(this.wv2);
            this.Controls.Add(this.wv1);
            this.Controls.Add(this.title);
            this.Name = "Measurements";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Load += new System.EventHandler(this.Measurements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv2;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv3;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
    }
}
