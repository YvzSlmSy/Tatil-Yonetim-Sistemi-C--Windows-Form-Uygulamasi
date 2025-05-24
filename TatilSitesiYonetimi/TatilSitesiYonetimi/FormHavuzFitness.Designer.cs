namespace TatilSitesiYonetimi
{
    partial class FormHavuzFitness
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
            this.cmbTc = new System.Windows.Forms.ComboBox();
            this.btnHavuzKullan = new System.Windows.Forms.Button();
            this.lblTcSec = new System.Windows.Forms.Label();
            this.lblHizmetSec = new System.Windows.Forms.Label();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.lblSonucHavuz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTc
            // 
            this.cmbTc.FormattingEnabled = true;
            this.cmbTc.Location = new System.Drawing.Point(198, 39);
            this.cmbTc.Name = "cmbTc";
            this.cmbTc.Size = new System.Drawing.Size(418, 24);
            this.cmbTc.TabIndex = 0;
            // 
            // btnHavuzKullan
            // 
            this.btnHavuzKullan.Location = new System.Drawing.Point(220, 191);
            this.btnHavuzKullan.Name = "btnHavuzKullan";
            this.btnHavuzKullan.Size = new System.Drawing.Size(242, 65);
            this.btnHavuzKullan.TabIndex = 1;
            this.btnHavuzKullan.Text = "KULLANIMI BAŞLAT";
            this.btnHavuzKullan.UseVisualStyleBackColor = true;
            this.btnHavuzKullan.Click += new System.EventHandler(this.btnHavuzKullan_Click);
            // 
            // lblTcSec
            // 
            this.lblTcSec.AutoSize = true;
            this.lblTcSec.Location = new System.Drawing.Point(74, 39);
            this.lblTcSec.Name = "lblTcSec";
            this.lblTcSec.Size = new System.Drawing.Size(65, 16);
            this.lblTcSec.TabIndex = 2;
            this.lblTcSec.Text = "TC Seçin:";
            // 
            // lblHizmetSec
            // 
            this.lblHizmetSec.AutoSize = true;
            this.lblHizmetSec.Location = new System.Drawing.Point(51, 133);
            this.lblHizmetSec.Name = "lblHizmetSec";
            this.lblHizmetSec.Size = new System.Drawing.Size(88, 16);
            this.lblHizmetSec.TabIndex = 3;
            this.lblHizmetSec.Text = "Hizmet Seçin:";
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.Location = new System.Drawing.Point(198, 133);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(418, 24);
            this.cmbHizmet.TabIndex = 4;
            // 
            // lblSonucHavuz
            // 
            this.lblSonucHavuz.AutoSize = true;
            this.lblSonucHavuz.Location = new System.Drawing.Point(139, 280);
            this.lblSonucHavuz.Name = "lblSonucHavuz";
            this.lblSonucHavuz.Size = new System.Drawing.Size(97, 16);
            this.lblSonucHavuz.TabIndex = 5;
            this.lblSonucHavuz.Text = "lblSonucHavuz";
            // 
            // FormHavuzFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 365);
            this.Controls.Add(this.lblSonucHavuz);
            this.Controls.Add(this.cmbHizmet);
            this.Controls.Add(this.lblHizmetSec);
            this.Controls.Add(this.lblTcSec);
            this.Controls.Add(this.btnHavuzKullan);
            this.Controls.Add(this.cmbTc);
            this.Name = "FormHavuzFitness";
            this.Text = "FormHavuzFitness";
            this.Load += new System.EventHandler(this.FormHavuzFitness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTc;
        private System.Windows.Forms.Button btnHavuzKullan;
        private System.Windows.Forms.Label lblTcSec;
        private System.Windows.Forms.Label lblHizmetSec;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.Label lblSonucHavuz;
    }
}