namespace TatilSitesiYonetimi
{
    partial class FormOdeme
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
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            this.btnOdemeListele = new System.Windows.Forms.Button();
            this.btnOdemeCikart = new System.Windows.Forms.Button();
            this.btnOdemeDuzenle = new System.Windows.Forms.Button();
            this.pnlOdemeEkle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdemeKaydet = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.pnlOdemeListele = new System.Windows.Forms.Panel();
            this.btnYenileOdeme = new System.Windows.Forms.Button();
            this.lstOdemeler = new System.Windows.Forms.ListBox();
            this.pnlOdemeSil = new System.Windows.Forms.Panel();
            this.btnOdemeSil = new System.Windows.Forms.Button();
            this.lstOdemeSil = new System.Windows.Forms.ListBox();
            this.pnlOdemeDuzenle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdemeGuncelle = new System.Windows.Forms.Button();
            this.dtpTarihDuzenle = new System.Windows.Forms.DateTimePicker();
            this.txtTutarDuzenle = new System.Windows.Forms.TextBox();
            this.txtDaireNoDuzenle = new System.Windows.Forms.TextBox();
            this.lstOdemeDuzenle = new System.Windows.Forms.ListBox();
            this.cmbDaireNoOdeme = new System.Windows.Forms.ComboBox();
            this.pnlOdemeEkle.SuspendLayout();
            this.pnlOdemeListele.SuspendLayout();
            this.pnlOdemeSil.SuspendLayout();
            this.pnlOdemeDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Location = new System.Drawing.Point(12, 22);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(184, 69);
            this.btnOdemeEkle.TabIndex = 0;
            this.btnOdemeEkle.Text = "Ödeme Ekle";
            this.btnOdemeEkle.UseVisualStyleBackColor = true;
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // btnOdemeListele
            // 
            this.btnOdemeListele.Location = new System.Drawing.Point(12, 126);
            this.btnOdemeListele.Name = "btnOdemeListele";
            this.btnOdemeListele.Size = new System.Drawing.Size(184, 69);
            this.btnOdemeListele.TabIndex = 1;
            this.btnOdemeListele.Text = "Ödeme Raporları";
            this.btnOdemeListele.UseVisualStyleBackColor = true;
            this.btnOdemeListele.Click += new System.EventHandler(this.btnOdemeListele_Click);
            // 
            // btnOdemeCikart
            // 
            this.btnOdemeCikart.Location = new System.Drawing.Point(12, 235);
            this.btnOdemeCikart.Name = "btnOdemeCikart";
            this.btnOdemeCikart.Size = new System.Drawing.Size(184, 69);
            this.btnOdemeCikart.TabIndex = 2;
            this.btnOdemeCikart.Text = "Ödeme Sil";
            this.btnOdemeCikart.UseVisualStyleBackColor = true;
            this.btnOdemeCikart.Click += new System.EventHandler(this.btnOdemeCikart_Click);
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.Location = new System.Drawing.Point(12, 333);
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(184, 69);
            this.btnOdemeDuzenle.TabIndex = 3;
            this.btnOdemeDuzenle.Text = "Ödemeleri Düzenle";
            this.btnOdemeDuzenle.UseVisualStyleBackColor = true;
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // pnlOdemeEkle
            // 
            this.pnlOdemeEkle.Controls.Add(this.cmbDaireNoOdeme);
            this.pnlOdemeEkle.Controls.Add(this.label3);
            this.pnlOdemeEkle.Controls.Add(this.label2);
            this.pnlOdemeEkle.Controls.Add(this.label1);
            this.pnlOdemeEkle.Controls.Add(this.btnOdemeKaydet);
            this.pnlOdemeEkle.Controls.Add(this.dtpTarih);
            this.pnlOdemeEkle.Controls.Add(this.txtTutar);
            this.pnlOdemeEkle.Location = new System.Drawing.Point(215, 22);
            this.pnlOdemeEkle.Name = "pnlOdemeEkle";
            this.pnlOdemeEkle.Size = new System.Drawing.Size(391, 380);
            this.pnlOdemeEkle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödeme tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ödeme miktarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daire Numarası:";
            // 
            // btnOdemeKaydet
            // 
            this.btnOdemeKaydet.Location = new System.Drawing.Point(110, 239);
            this.btnOdemeKaydet.Name = "btnOdemeKaydet";
            this.btnOdemeKaydet.Size = new System.Drawing.Size(165, 43);
            this.btnOdemeKaydet.TabIndex = 3;
            this.btnOdemeKaydet.Text = "Ödemeyi Kaydet";
            this.btnOdemeKaydet.UseVisualStyleBackColor = true;
            this.btnOdemeKaydet.Click += new System.EventHandler(this.btnOdemeKaydet_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(129, 151);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(246, 22);
            this.dtpTarih.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(129, 87);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(246, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // pnlOdemeListele
            // 
            this.pnlOdemeListele.Controls.Add(this.btnYenileOdeme);
            this.pnlOdemeListele.Controls.Add(this.lstOdemeler);
            this.pnlOdemeListele.Location = new System.Drawing.Point(215, 22);
            this.pnlOdemeListele.Name = "pnlOdemeListele";
            this.pnlOdemeListele.Size = new System.Drawing.Size(391, 380);
            this.pnlOdemeListele.TabIndex = 5;
            // 
            // btnYenileOdeme
            // 
            this.btnYenileOdeme.Location = new System.Drawing.Point(83, 325);
            this.btnYenileOdeme.Name = "btnYenileOdeme";
            this.btnYenileOdeme.Size = new System.Drawing.Size(225, 52);
            this.btnYenileOdeme.TabIndex = 1;
            this.btnYenileOdeme.Text = "Ödeme Listesini güncelle";
            this.btnYenileOdeme.UseVisualStyleBackColor = true;
            this.btnYenileOdeme.Click += new System.EventHandler(this.btnYenileOdeme_Click);
            // 
            // lstOdemeler
            // 
            this.lstOdemeler.FormattingEnabled = true;
            this.lstOdemeler.ItemHeight = 16;
            this.lstOdemeler.Location = new System.Drawing.Point(0, 0);
            this.lstOdemeler.Name = "lstOdemeler";
            this.lstOdemeler.Size = new System.Drawing.Size(388, 324);
            this.lstOdemeler.TabIndex = 0;
            // 
            // pnlOdemeSil
            // 
            this.pnlOdemeSil.Controls.Add(this.btnOdemeSil);
            this.pnlOdemeSil.Controls.Add(this.lstOdemeSil);
            this.pnlOdemeSil.Location = new System.Drawing.Point(215, 22);
            this.pnlOdemeSil.Name = "pnlOdemeSil";
            this.pnlOdemeSil.Size = new System.Drawing.Size(391, 380);
            this.pnlOdemeSil.TabIndex = 6;
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Location = new System.Drawing.Point(83, 330);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(225, 47);
            this.btnOdemeSil.TabIndex = 1;
            this.btnOdemeSil.Text = "Seçili Ödemeyi Sil";
            this.btnOdemeSil.UseVisualStyleBackColor = true;
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // lstOdemeSil
            // 
            this.lstOdemeSil.FormattingEnabled = true;
            this.lstOdemeSil.ItemHeight = 16;
            this.lstOdemeSil.Location = new System.Drawing.Point(0, 0);
            this.lstOdemeSil.Name = "lstOdemeSil";
            this.lstOdemeSil.Size = new System.Drawing.Size(391, 324);
            this.lstOdemeSil.TabIndex = 0;
            // 
            // pnlOdemeDuzenle
            // 
            this.pnlOdemeDuzenle.Controls.Add(this.label6);
            this.pnlOdemeDuzenle.Controls.Add(this.label5);
            this.pnlOdemeDuzenle.Controls.Add(this.label4);
            this.pnlOdemeDuzenle.Controls.Add(this.btnOdemeGuncelle);
            this.pnlOdemeDuzenle.Controls.Add(this.dtpTarihDuzenle);
            this.pnlOdemeDuzenle.Controls.Add(this.txtTutarDuzenle);
            this.pnlOdemeDuzenle.Controls.Add(this.txtDaireNoDuzenle);
            this.pnlOdemeDuzenle.Controls.Add(this.lstOdemeDuzenle);
            this.pnlOdemeDuzenle.Location = new System.Drawing.Point(215, 22);
            this.pnlOdemeDuzenle.Name = "pnlOdemeDuzenle";
            this.pnlOdemeDuzenle.Size = new System.Drawing.Size(391, 380);
            this.pnlOdemeDuzenle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Daire No:";
            // 
            // btnOdemeGuncelle
            // 
            this.btnOdemeGuncelle.Location = new System.Drawing.Point(110, 339);
            this.btnOdemeGuncelle.Name = "btnOdemeGuncelle";
            this.btnOdemeGuncelle.Size = new System.Drawing.Size(184, 37);
            this.btnOdemeGuncelle.TabIndex = 4;
            this.btnOdemeGuncelle.Text = "Seçili Ödemeyi Düzenle";
            this.btnOdemeGuncelle.UseVisualStyleBackColor = true;
            this.btnOdemeGuncelle.Click += new System.EventHandler(this.btnOdemeGuncelle_Click);
            // 
            // dtpTarihDuzenle
            // 
            this.dtpTarihDuzenle.Location = new System.Drawing.Point(83, 311);
            this.dtpTarihDuzenle.Name = "dtpTarihDuzenle";
            this.dtpTarihDuzenle.Size = new System.Drawing.Size(305, 22);
            this.dtpTarihDuzenle.TabIndex = 3;
            // 
            // txtTutarDuzenle
            // 
            this.txtTutarDuzenle.Location = new System.Drawing.Point(83, 283);
            this.txtTutarDuzenle.Name = "txtTutarDuzenle";
            this.txtTutarDuzenle.Size = new System.Drawing.Size(305, 22);
            this.txtTutarDuzenle.TabIndex = 2;
            this.txtTutarDuzenle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDaireNoDuzenle
            // 
            this.txtDaireNoDuzenle.Location = new System.Drawing.Point(83, 255);
            this.txtDaireNoDuzenle.Name = "txtDaireNoDuzenle";
            this.txtDaireNoDuzenle.Size = new System.Drawing.Size(305, 22);
            this.txtDaireNoDuzenle.TabIndex = 1;
            // 
            // lstOdemeDuzenle
            // 
            this.lstOdemeDuzenle.FormattingEnabled = true;
            this.lstOdemeDuzenle.ItemHeight = 16;
            this.lstOdemeDuzenle.Location = new System.Drawing.Point(3, 3);
            this.lstOdemeDuzenle.Name = "lstOdemeDuzenle";
            this.lstOdemeDuzenle.Size = new System.Drawing.Size(388, 244);
            this.lstOdemeDuzenle.TabIndex = 0;
            this.lstOdemeDuzenle.SelectedIndexChanged += new System.EventHandler(this.lstOdemeDuzenle_SelectedIndexChanged);
            // 
            // cmbDaireNoOdeme
            // 
            this.cmbDaireNoOdeme.FormattingEnabled = true;
            this.cmbDaireNoOdeme.Location = new System.Drawing.Point(129, 30);
            this.cmbDaireNoOdeme.Name = "cmbDaireNoOdeme";
            this.cmbDaireNoOdeme.Size = new System.Drawing.Size(259, 24);
            this.cmbDaireNoOdeme.TabIndex = 7;
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 414);
            this.Controls.Add(this.pnlOdemeDuzenle);
            this.Controls.Add(this.pnlOdemeSil);
            this.Controls.Add(this.pnlOdemeListele);
            this.Controls.Add(this.pnlOdemeEkle);
            this.Controls.Add(this.btnOdemeDuzenle);
            this.Controls.Add(this.btnOdemeCikart);
            this.Controls.Add(this.btnOdemeListele);
            this.Controls.Add(this.btnOdemeEkle);
            this.Name = "FormOdeme";
            this.Text = "FormOdeme";
            this.Load += new System.EventHandler(this.FormOdeme_Load);
            this.pnlOdemeEkle.ResumeLayout(false);
            this.pnlOdemeEkle.PerformLayout();
            this.pnlOdemeListele.ResumeLayout(false);
            this.pnlOdemeSil.ResumeLayout(false);
            this.pnlOdemeDuzenle.ResumeLayout(false);
            this.pnlOdemeDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdemeEkle;
        private System.Windows.Forms.Button btnOdemeListele;
        private System.Windows.Forms.Button btnOdemeCikart;
        private System.Windows.Forms.Button btnOdemeDuzenle;
        private System.Windows.Forms.Panel pnlOdemeEkle;
        private System.Windows.Forms.Button btnOdemeKaydet;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOdemeListele;
        private System.Windows.Forms.Button btnYenileOdeme;
        private System.Windows.Forms.ListBox lstOdemeler;
        private System.Windows.Forms.Panel pnlOdemeSil;
        private System.Windows.Forms.Button btnOdemeSil;
        private System.Windows.Forms.ListBox lstOdemeSil;
        private System.Windows.Forms.Panel pnlOdemeDuzenle;
        private System.Windows.Forms.Button btnOdemeGuncelle;
        private System.Windows.Forms.DateTimePicker dtpTarihDuzenle;
        private System.Windows.Forms.TextBox txtTutarDuzenle;
        private System.Windows.Forms.TextBox txtDaireNoDuzenle;
        private System.Windows.Forms.ListBox lstOdemeDuzenle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDaireNoOdeme;
    }
}