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
using TatilSitesiYonetimi.Classes;

namespace TatilSitesiYonetimi
{
    public partial class FormKisi: Form
    {
        public FormKisi()
        {
            InitializeComponent();
        }

        private void FormKisi_Load(object sender, EventArgs e)
        {
            cmbTipKisi.Items.AddRange(new string[] { "AileReisi", "Misafir" });

            // Arka plan resmi
            string resimYolu = Path.Combine(Application.StartupPath, "Images\\resim1.png");
            this.BackgroundImage = Image.FromFile(resimYolu);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Buton stili
            void ButonStilUygula(Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            ButonStilUygula(btnKisiEkle);
            ButonStilUygula(btnKisiListele);
            ButonStilUygula(btnSil);
            ButonStilUygula(btnKisiDuzenle);
        }

        private void PanelleriGizle()
        {
            pnlKisiEkle.Visible = false;
            pnlKisiSil.Visible = false;
            pnlKisiListe.Visible = false;
            pnlKisiDuzenle.Visible = false;
        }


        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            PanelleriGizle();
            pnlKisiEkle.Visible = true;

            cmbTipKisi.Items.Clear();
            cmbTipKisi.Items.AddRange(new string[] { "AileReisi", "Misafir" });

            // Temizle
            txtTc.Clear();
            txtAdSoyad.Clear();
            txtDaireNo.Clear();
        }

        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string tip = cmbTipKisi.SelectedItem?.ToString();
                long tc = long.Parse(txtTc.Text.Trim());
                string adSoyad = txtAdSoyad.Text.Trim();
                int daire = int.Parse(txtDaireNo.Text.Trim());

                if (string.IsNullOrEmpty(tip) || string.IsNullOrEmpty(adSoyad))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                Oturan yeniKisi = null;

                if (tip == "AileReisi")
                    yeniKisi = new AileReisi { TcKimlik = tc, AdSoyad = adSoyad, DaireId = daire };
                else if (tip == "Misafir")
                    yeniKisi = new Misafir { TcKimlik = tc, AdSoyad = adSoyad, DaireId = daire };

                if (yeniKisi != null)
                {
                    DosyaYonetici.SatirEkle("Data/Data.txt", yeniKisi.ToString());
                    MessageBox.Show("Kişi başarıyla eklendi!");

                    // Alanları temizle
                    cmbTipKisi.SelectedIndex = -1;
                    txtTc.Clear();
                    txtAdSoyad.Clear();
                    txtDaireNo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void KisileriListele()
        {
            lstKisiler.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");

            foreach (string satir in satirlar)
            {
                lstKisiler.Items.Add(satir);
            }

            if (satirlar.Count == 0)
                MessageBox.Show("Kayıtlı kişi bulunamadı.");
        }

        private void btnKisiListele_Click(object sender, EventArgs e)
        {
            PanelleriGizle();
            pnlKisiListe.Visible = true;
            KisileriListele();
        }

        private void btnYenileKisi_Click(object sender, EventArgs e)
        {
            KisileriListele();
        }

        private void pnlKisiListe_Paint(object sender, PaintEventArgs e)
        {

        }
        private void KisileriSilPanelindeGoster()
        {
            lstKisiSil.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");

            foreach (string satir in satirlar)
            {
                lstKisiSil.Items.Add(satir);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PanelleriGizle();
            pnlKisiSil.Visible = true;
            KisileriSilPanelindeGoster();
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (lstKisiSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kişiyi seçin.");
                return;
            }

            string secilen = lstKisiSil.SelectedItem.ToString().Trim();
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");

            int silinen = satirlar.RemoveAll(s => s.Trim() == secilen);

            if (silinen > 0)
            {
                DosyaYonetici.SatirlariYaz("Data/Data.txt", satirlar);
                MessageBox.Show("Kişi silindi.");
                KisileriSilPanelindeGoster(); // listeyi yenile
            }
            else
            {
                MessageBox.Show("Seçilen kayıt bulunamadı.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void KisileriDuzenlePanelindeGoster()
        {
            lstKisiDuzenle.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");

            foreach (string satir in satirlar)
            {
                lstKisiDuzenle.Items.Add(satir);
            }
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            PanelleriGizle();
            pnlKisiDuzenle.Visible = true;

            cmbTipDuzenleKisi.Items.Clear();
            cmbTipDuzenleKisi.Items.AddRange(new string[] { "AileReisi", "Misafir" });

            KisileriDuzenlePanelindeGoster();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiDuzenle.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            string eskiKayit = lstKisiDuzenle.SelectedItem.ToString();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");
            satirlar.RemoveAll(s => s.Trim() == eskiKayit.Trim());

            string yeniTip = cmbTipDuzenleKisi.Text.Trim();
            string yeniTc = txtTcDuzenle.Text.Trim();
            string yeniAd = txtAdSoyadDuzenle.Text.Trim();
            string yeniDaire = txtDaireNoDuzenle.Text.Trim();

            string yeniSatir = $"{yeniTip},{yeniTc},{yeniAd},{yeniDaire}";
            satirlar.Add(yeniSatir);

            DosyaYonetici.SatirlariYaz("Data/Data.txt", satirlar);
            MessageBox.Show("Kayıt başarıyla güncellendi.");
            KisileriDuzenlePanelindeGoster(); // Listeyi yenile
        }

        private void lstKisiDuzenle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiDuzenle.SelectedItem == null) return;

            string satir = lstKisiDuzenle.SelectedItem.ToString();
            string[] parcalar = satir.Split(',');

            if (parcalar.Length >= 4)
            {
                cmbTipDuzenleKisi.SelectedItem = parcalar[0];
                txtTcDuzenle.Text = parcalar[1];
                txtAdSoyadDuzenle.Text = parcalar[2];
                txtDaireNoDuzenle.Text = parcalar[3];
            }
        }

        private void txtDaireNoDuzenle_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlKisiDuzenle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
