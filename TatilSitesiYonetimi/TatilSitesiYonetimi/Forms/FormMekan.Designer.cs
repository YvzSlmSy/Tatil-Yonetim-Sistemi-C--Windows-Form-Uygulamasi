namespace TatilSitesiYonetimi.Forms
{
    partial class FormMekan
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.pnlListele = new System.Windows.Forms.Panel();
            this.btnYenileListe = new System.Windows.Forms.Button();
            this.lstMekanListe = new System.Windows.Forms.ListBox();
            this.pnlDuzenle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAdresDuzenle = new System.Windows.Forms.TextBox();
            this.txtIdDuzenle = new System.Windows.Forms.TextBox();
            this.cmbTipDuzenle = new System.Windows.Forms.ComboBox();
            this.lstMekanDuzenle = new System.Windows.Forms.ListBox();
            this.pnlEkle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydetEkle = new System.Windows.Forms.Button();
            this.txtAdresEkle = new System.Windows.Forms.TextBox();
            this.txtIdEkle = new System.Windows.Forms.TextBox();
            this.cmbTipEkle = new System.Windows.Forms.ComboBox();
            this.pnlSil = new System.Windows.Forms.Panel();
            this.bttnSil = new System.Windows.Forms.Button();
            this.lstMekanSil = new System.Windows.Forms.ListBox();
            this.pnlListele.SuspendLayout();
            this.pnlDuzenle.SuspendLayout();
            this.pnlEkle.SuspendLayout();
            this.pnlSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 224);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Mekan Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(183, 54);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Mekan Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(183, 53);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Mekanları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 123);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(183, 53);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Mekanları Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // pnlListele
            // 
            this.pnlListele.Controls.Add(this.btnYenileListe);
            this.pnlListele.Controls.Add(this.lstMekanListe);
            this.pnlListele.Location = new System.Drawing.Point(217, 12);
            this.pnlListele.Name = "pnlListele";
            this.pnlListele.Size = new System.Drawing.Size(487, 362);
            this.pnlListele.TabIndex = 4;
            this.pnlListele.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlListele_Paint);
            // 
            // btnYenileListe
            // 
            this.btnYenileListe.Location = new System.Drawing.Point(175, 323);
            this.btnYenileListe.Name = "btnYenileListe";
            this.btnYenileListe.Size = new System.Drawing.Size(150, 36);
            this.btnYenileListe.TabIndex = 6;
            this.btnYenileListe.Text = "Listeyi Yenile";
            this.btnYenileListe.UseVisualStyleBackColor = true;
            this.btnYenileListe.Click += new System.EventHandler(this.btnYenileListe_Click);
            // 
            // lstMekanListe
            // 
            this.lstMekanListe.FormattingEnabled = true;
            this.lstMekanListe.ItemHeight = 16;
            this.lstMekanListe.Location = new System.Drawing.Point(22, 25);
            this.lstMekanListe.Name = "lstMekanListe";
            this.lstMekanListe.Size = new System.Drawing.Size(442, 292);
            this.lstMekanListe.TabIndex = 5;
            // 
            // pnlDuzenle
            // 
            this.pnlDuzenle.Controls.Add(this.label3);
            this.pnlDuzenle.Controls.Add(this.label2);
            this.pnlDuzenle.Controls.Add(this.label1);
            this.pnlDuzenle.Controls.Add(this.btnGuncelle);
            this.pnlDuzenle.Controls.Add(this.txtAdresDuzenle);
            this.pnlDuzenle.Controls.Add(this.txtIdDuzenle);
            this.pnlDuzenle.Controls.Add(this.cmbTipDuzenle);
            this.pnlDuzenle.Controls.Add(this.lstMekanDuzenle);
            this.pnlDuzenle.Location = new System.Drawing.Point(217, 15);
            this.pnlDuzenle.Name = "pnlDuzenle";
            this.pnlDuzenle.Size = new System.Drawing.Size(487, 362);
            this.pnlDuzenle.TabIndex = 5;
            this.pnlDuzenle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDuzenle_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tip: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(131, 327);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(194, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAdresDuzenle
            // 
            this.txtAdresDuzenle.Location = new System.Drawing.Point(140, 295);
            this.txtAdresDuzenle.Name = "txtAdresDuzenle";
            this.txtAdresDuzenle.Size = new System.Drawing.Size(344, 22);
            this.txtAdresDuzenle.TabIndex = 3;
            this.txtAdresDuzenle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIdDuzenle
            // 
            this.txtIdDuzenle.Location = new System.Drawing.Point(140, 267);
            this.txtIdDuzenle.Name = "txtIdDuzenle";
            this.txtIdDuzenle.Size = new System.Drawing.Size(344, 22);
            this.txtIdDuzenle.TabIndex = 2;
            // 
            // cmbTipDuzenle
            // 
            this.cmbTipDuzenle.FormattingEnabled = true;
            this.cmbTipDuzenle.Location = new System.Drawing.Point(140, 237);
            this.cmbTipDuzenle.Name = "cmbTipDuzenle";
            this.cmbTipDuzenle.Size = new System.Drawing.Size(344, 24);
            this.cmbTipDuzenle.TabIndex = 1;
            // 
            // lstMekanDuzenle
            // 
            this.lstMekanDuzenle.FormattingEnabled = true;
            this.lstMekanDuzenle.ItemHeight = 16;
            this.lstMekanDuzenle.Location = new System.Drawing.Point(3, 3);
            this.lstMekanDuzenle.Name = "lstMekanDuzenle";
            this.lstMekanDuzenle.Size = new System.Drawing.Size(481, 228);
            this.lstMekanDuzenle.TabIndex = 0;
            this.lstMekanDuzenle.SelectedIndexChanged += new System.EventHandler(this.lstMekanDuzenle_SelectedIndexChanged);
            // 
            // pnlEkle
            // 
            this.pnlEkle.Controls.Add(this.label6);
            this.pnlEkle.Controls.Add(this.label5);
            this.pnlEkle.Controls.Add(this.label4);
            this.pnlEkle.Controls.Add(this.btnKaydetEkle);
            this.pnlEkle.Controls.Add(this.txtAdresEkle);
            this.pnlEkle.Controls.Add(this.txtIdEkle);
            this.pnlEkle.Controls.Add(this.cmbTipEkle);
            this.pnlEkle.Location = new System.Drawing.Point(217, 12);
            this.pnlEkle.Name = "pnlEkle";
            this.pnlEkle.Size = new System.Drawing.Size(496, 365);
            this.pnlEkle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mekan Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mekan ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mekan Tipi:";
            // 
            // btnKaydetEkle
            // 
            this.btnKaydetEkle.Location = new System.Drawing.Point(140, 238);
            this.btnKaydetEkle.Name = "btnKaydetEkle";
            this.btnKaydetEkle.Size = new System.Drawing.Size(201, 54);
            this.btnKaydetEkle.TabIndex = 3;
            this.btnKaydetEkle.Text = "EKLE";
            this.btnKaydetEkle.UseVisualStyleBackColor = true;
            this.btnKaydetEkle.Click += new System.EventHandler(this.btnKaydetEkle_Click);
            // 
            // txtAdresEkle
            // 
            this.txtAdresEkle.Location = new System.Drawing.Point(175, 154);
            this.txtAdresEkle.Name = "txtAdresEkle";
            this.txtAdresEkle.Size = new System.Drawing.Size(283, 22);
            this.txtAdresEkle.TabIndex = 2;
            // 
            // txtIdEkle
            // 
            this.txtIdEkle.Location = new System.Drawing.Point(175, 91);
            this.txtIdEkle.Name = "txtIdEkle";
            this.txtIdEkle.Size = new System.Drawing.Size(283, 22);
            this.txtIdEkle.TabIndex = 1;
            // 
            // cmbTipEkle
            // 
            this.cmbTipEkle.FormattingEnabled = true;
            this.cmbTipEkle.Location = new System.Drawing.Point(175, 29);
            this.cmbTipEkle.Name = "cmbTipEkle";
            this.cmbTipEkle.Size = new System.Drawing.Size(283, 24);
            this.cmbTipEkle.TabIndex = 0;
            // 
            // pnlSil
            // 
            this.pnlSil.Controls.Add(this.bttnSil);
            this.pnlSil.Controls.Add(this.lstMekanSil);
            this.pnlSil.Location = new System.Drawing.Point(217, 12);
            this.pnlSil.Name = "pnlSil";
            this.pnlSil.Size = new System.Drawing.Size(493, 365);
            this.pnlSil.TabIndex = 7;
            this.pnlSil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSil_Paint);
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(189, 308);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(152, 45);
            this.bttnSil.TabIndex = 8;
            this.bttnSil.Text = "Seçili Mekanı Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // lstMekanSil
            // 
            this.lstMekanSil.FormattingEnabled = true;
            this.lstMekanSil.ItemHeight = 16;
            this.lstMekanSil.Location = new System.Drawing.Point(3, 3);
            this.lstMekanSil.Name = "lstMekanSil";
            this.lstMekanSil.Size = new System.Drawing.Size(490, 292);
            this.lstMekanSil.TabIndex = 0;
            this.lstMekanSil.SelectedIndexChanged += new System.EventHandler(this.lstMekanSil_SelectedIndexChanged);
            // 
            // FormMekan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 386);
            this.Controls.Add(this.pnlSil);
            this.Controls.Add(this.pnlEkle);
            this.Controls.Add(this.pnlDuzenle);
            this.Controls.Add(this.pnlListele);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "FormMekan";
            this.Text = "FormMekan";
            this.Load += new System.EventHandler(this.FormMekan_Load);
            this.pnlListele.ResumeLayout(false);
            this.pnlDuzenle.ResumeLayout(false);
            this.pnlDuzenle.PerformLayout();
            this.pnlEkle.ResumeLayout(false);
            this.pnlEkle.PerformLayout();
            this.pnlSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Panel pnlListele;
        private System.Windows.Forms.Button btnYenileListe;
        private System.Windows.Forms.ListBox lstMekanListe;
        private System.Windows.Forms.Panel pnlDuzenle;
        private System.Windows.Forms.TextBox txtAdresDuzenle;
        private System.Windows.Forms.TextBox txtIdDuzenle;
        private System.Windows.Forms.ComboBox cmbTipDuzenle;
        private System.Windows.Forms.ListBox lstMekanDuzenle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlEkle;
        private System.Windows.Forms.Button btnKaydetEkle;
        private System.Windows.Forms.TextBox txtAdresEkle;
        private System.Windows.Forms.TextBox txtIdEkle;
        private System.Windows.Forms.ComboBox cmbTipEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSil;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.ListBox lstMekanSil;
    }
}