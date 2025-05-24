namespace TatilSitesiYonetimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMekan = new System.Windows.Forms.Button();
            this.btnKisiYonetimi = new System.Windows.Forms.Button();
            this.btnOdemeIslemleri = new System.Windows.Forms.Button();
            this.btnHavuzFitnessKullanimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMekan
            // 
            this.btnMekan.Location = new System.Drawing.Point(112, 182);
            this.btnMekan.Name = "btnMekan";
            this.btnMekan.Size = new System.Drawing.Size(216, 72);
            this.btnMekan.TabIndex = 0;
            this.btnMekan.Text = "Mekan Yönetimi";
            this.btnMekan.UseVisualStyleBackColor = true;
            this.btnMekan.Click += new System.EventHandler(this.btnMekan_Click);
            // 
            // btnKisiYonetimi
            // 
            this.btnKisiYonetimi.Location = new System.Drawing.Point(421, 182);
            this.btnKisiYonetimi.Name = "btnKisiYonetimi";
            this.btnKisiYonetimi.Size = new System.Drawing.Size(218, 72);
            this.btnKisiYonetimi.TabIndex = 1;
            this.btnKisiYonetimi.Text = "Kişi Yönetimi";
            this.btnKisiYonetimi.UseVisualStyleBackColor = true;
            this.btnKisiYonetimi.Click += new System.EventHandler(this.btnKisiYonetimi_Click);
            // 
            // btnOdemeIslemleri
            // 
            this.btnOdemeIslemleri.Location = new System.Drawing.Point(112, 293);
            this.btnOdemeIslemleri.Name = "btnOdemeIslemleri";
            this.btnOdemeIslemleri.Size = new System.Drawing.Size(216, 79);
            this.btnOdemeIslemleri.TabIndex = 2;
            this.btnOdemeIslemleri.Text = "Ödeme İşlemleri";
            this.btnOdemeIslemleri.UseVisualStyleBackColor = true;
            this.btnOdemeIslemleri.Click += new System.EventHandler(this.btnOdemeIslemleri_Click);
            // 
            // btnHavuzFitnessKullanimi
            // 
            this.btnHavuzFitnessKullanimi.Location = new System.Drawing.Point(421, 293);
            this.btnHavuzFitnessKullanimi.Name = "btnHavuzFitnessKullanimi";
            this.btnHavuzFitnessKullanimi.Size = new System.Drawing.Size(218, 74);
            this.btnHavuzFitnessKullanimi.TabIndex = 3;
            this.btnHavuzFitnessKullanimi.Text = "Havuz/Fitness Kullanımı";
            this.btnHavuzFitnessKullanimi.UseVisualStyleBackColor = true;
            this.btnHavuzFitnessKullanimi.Click += new System.EventHandler(this.btnHavuzFitnessKullanimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TATİL YÖNETİM SİSTEMİNE HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHavuzFitnessKullanimi);
            this.Controls.Add(this.btnOdemeIslemleri);
            this.Controls.Add(this.btnKisiYonetimi);
            this.Controls.Add(this.btnMekan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMekan;
        private System.Windows.Forms.Button btnKisiYonetimi;
        private System.Windows.Forms.Button btnOdemeIslemleri;
        private System.Windows.Forms.Button btnHavuzFitnessKullanimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

