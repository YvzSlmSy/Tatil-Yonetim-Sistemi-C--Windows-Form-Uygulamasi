/****************************************************************************
**				SAKARYA ÜNİVERSİTESİ
**		BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**		    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**		   NESNEYE DAYALI PROGRAMLAMA DERSİ
**			2024-2025 BAHAR DÖNEMİ
**	
**		
**		ÖĞRENCİ ADI............: YAVUZ SELİM SAY
**		ÖĞRENCİ NUMARASI.......: B221210086
**      DERSİN ALINDIĞI GRUP...: 2. Öğretim A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatilSitesiYonetimi.Forms;

namespace TatilSitesiYonetimi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            string resimYolu = Path.Combine(Application.StartupPath, "Images\\resim1.png");
            this.BackgroundImage = Image.FromFile(resimYolu);
            this.BackgroundImageLayout = ImageLayout.Stretch; // veya Zoom / Tile / Center

            btnMekan.FlatStyle = FlatStyle.Flat;
            btnMekan.FlatAppearance.BorderSize = 0;
            btnMekan.BackColor = Color.FromArgb(255, 255, 255); // Beyaz
            btnMekan.ForeColor = Color.Black;
            btnMekan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMekan.Size = new Size(200, 60);  // Geniş ve şık

            btnKisiYonetimi.FlatStyle = FlatStyle.Flat;
            btnKisiYonetimi.FlatAppearance.BorderSize = 0;
            btnKisiYonetimi.BackColor = Color.FromArgb(255, 255, 255); // Beyaz
            btnKisiYonetimi.ForeColor = Color.Black;
            btnKisiYonetimi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKisiYonetimi.Size = new Size(200, 60);  // Geniş ve şık

            btnOdemeIslemleri.FlatStyle = FlatStyle.Flat;
            btnOdemeIslemleri.FlatAppearance.BorderSize = 0;
            btnOdemeIslemleri.BackColor = Color.FromArgb(255, 255, 255); // Beyaz
            btnOdemeIslemleri.ForeColor = Color.Black;
            btnOdemeIslemleri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOdemeIslemleri.Size = new Size(200, 60);  // Geniş ve şık

            btnHavuzFitnessKullanimi.FlatStyle = FlatStyle.Flat;
            btnHavuzFitnessKullanimi.FlatAppearance.BorderSize = 0;
            btnHavuzFitnessKullanimi.BackColor = Color.FromArgb(255, 255, 255); // Beyaz
            btnHavuzFitnessKullanimi.ForeColor = Color.Black;
            btnHavuzFitnessKullanimi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHavuzFitnessKullanimi.Size = new Size(200, 60);  // Geniş ve şık

            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black; // Yazı rengi siyah
            label1.BackColor = Color.White; // Arka plan beyaz
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Padding = new Padding(10); // Yazının kenarlarına boşluk


            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Black; // Yazı rengi siyah
            label2.BackColor = Color.White; // Arka plan beyaz
            label2.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void btnMekan_Click(object sender, EventArgs e)
        {
            new FormMekan().Show();

        }

        private void btnKisiYonetimi_Click(object sender, EventArgs e)
        {
            new FormKisi().Show();

        }


        private void btnOdemeIslemleri_Click(object sender, EventArgs e)
        {
            new FormOdeme().Show();

        }

        private void btnHavuzFitnessKullanimi_Click(object sender, EventArgs e)
        {
            new FormHavuzFitness().Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
