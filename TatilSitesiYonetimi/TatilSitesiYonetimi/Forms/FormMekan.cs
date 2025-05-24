/****************************************************************************
**				SAKARYA ÜNİVERSİTESİ
**		BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**		    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**		   NESNEYE DAYALI PROGRAMLAMA DERSİ
**			2024-2025 BAHAR DÖNEMİ
**	
**		ÖDEV NUMARASI..........:
**		ÖĞRENCİ ADI............:
**		ÖĞRENCİ NUMARASI.......:
**     DERSİN ALINDIĞI GRUP...:
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TatilSitesiYonetimi.Classes;
using TatilSitesiYonetimi.Forms; // GEREKLİ

namespace TatilSitesiYonetimi.Forms
{
    public partial class FormMekan : Form
    {
        string dosyaYolu = "Data/Mekan.txt";

        public FormMekan()
        {
            InitializeComponent();
        }

        private void FormMekan_Load(object sender, EventArgs e)
        {
            pnlEkle.Visible = false;
            pnlListele.Visible = false;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = false;
            cmbTipEkle.Items.AddRange(new string[] { "Daire", "Fitness", "Havuz" });
            cmbTipEkle.SelectedIndex = 0;
            MekanlariListele();

            // Arka plan resmi yükle
            string resimYolu = Path.Combine(Application.StartupPath, "Images\\resim1.png");
            this.BackgroundImage = Image.FromFile(resimYolu);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Modern buton stili
            void ButonStilUygula(Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(255, 255, 255); // Beyaz
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Size = new Size(140, 50);
            }

            // Uygulanacak butonlar
            ButonStilUygula(btnListele);
            ButonStilUygula(btnDuzenle);
            ButonStilUygula(btnEkle);
            ButonStilUygula(btnSil);


        }



        private void BtnEkle_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            pnlListele.Visible = true;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = false;

            try
            {
                int id = int.Parse(txtIdEkle.Text);
                string adres = txtAdresEkle.Text;
                string tip = cmbTipEkle.SelectedItem.ToString();

                Mekan mekan = null;

                if (tip == "Daire")
                {
                    mekan = new Daire { Id = id, Adres = adres };
                }
                else if (tip == "Fitness")
                {
                    mekan = new Fitness { Id = id, Adres = adres };
                }
                else if (tip == "Havuz")
                {
                    mekan = new Havuz { Id = id, Adres = adres };
                }

                if (mekan != null)
                {
                    DosyaYonetici.SatirEkle("Data/Mekan.txt", mekan.ToString());
                    MessageBox.Show("Mekan başarıyla eklendi.");
                    MekanlariListele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tip seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


        private void MekanlariListele()
        {
            lstMekanListe.Items.Clear();
            List<string> satirlar = DosyaYonetici.SatirlariOku(dosyaYolu);
            foreach (string satir in satirlar)
            {
                lstMekanListe.Items.Add(satir);
            }
        }

        private void MekanlariSilPanelindeGoster()
        {
            lstMekanSil.Items.Clear();
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");

            foreach (string satir in satirlar)
            {
                lstMekanSil.Items.Add(satir);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = false;
            pnlListele.Visible = false;
            pnlSil.Visible = true;
            pnlDuzenle.Visible = false;

            MekanlariSilPanelindeGoster();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = false;
            pnlListele.Visible = true;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = false;
            MekanlariListele();
            btnYenileListe.PerformClick(); // Otomatik yenile

        }
 
        private void Temizle()
        {


            txtIdEkle.Clear();
            txtAdresEkle.Clear();
            cmbTipEkle.SelectedIndex = 0;
        }

        private void pnlListele_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = false;
            pnlListele.Visible = true;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = true;
            cmbTipDuzenle.Items.Clear();
            cmbTipDuzenle.Items.AddRange(new string[] { "Daire", "Fitness", "Havuz" });
            MekanlariDuzenlePanelindeGoster(); // ListBox’a yaz


        }

        private void MekanlariDuzenlePanelindeGoster()
        {
            lstMekanDuzenle.Items.Clear();
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");

            foreach (string satir in satirlar)
            {
                lstMekanDuzenle.Items.Add(satir);
            }
        }

        private void btnYenileListe_Click(object sender, EventArgs e)
        {
            lstMekanListe.Items.Clear(); // Önce eski verileri temizle
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");

            foreach (string satir in satirlar)
            {
                lstMekanListe.Items.Add(satir);
            }

            if (satirlar.Count == 0)
                MessageBox.Show("Kayıtlı mekan bulunamadı.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstMekanDuzenle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMekanDuzenle.SelectedItem == null) return;

            string satir = lstMekanDuzenle.SelectedItem.ToString();
            string[] parcalar = satir.Split(',');

            if (parcalar.Length >= 3)
            {
                cmbTipDuzenle.SelectedItem = parcalar[0];
                txtIdDuzenle.Text = parcalar[1];
                txtAdresDuzenle.Text = parcalar[2];
            }
        }


        private void pnlDuzenle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMekanDuzenle.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            string eskiKayit = lstMekanDuzenle.SelectedItem.ToString();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");
            satirlar.Remove(eskiKayit); // Eskiyi kaldır

            // Yeni satır oluştur
            string yeniTip = cmbTipDuzenle.Text.Trim();
            string yeniId = txtIdDuzenle.Text.Trim();
            string yeniAdres = txtAdresDuzenle.Text.Trim();

            string yeniKayit = $"{yeniTip},{yeniId},{yeniAdres}";
            satirlar.Add(yeniKayit);

            // Dosyaya yaz
            DosyaYonetici.SatirlariYaz("Data/Mekan.txt", satirlar);

            MessageBox.Show("Kayıt güncellendi!");
            MekanlariDuzenlePanelindeGoster(); // listeyi yenile
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            pnlListele.Visible = false;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = false;
            pnlEkle.Visible = true;

            // Girişleri sıfırla
            cmbTipEkle.SelectedIndex = -1;
            txtIdEkle.Clear();
            txtAdresEkle.Clear();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            pnlListele.Visible = false;
            pnlSil.Visible = false;
            pnlDuzenle.Visible = false;
            pnlEkle.Visible = true;

            // Girişleri sıfırla
            cmbTipEkle.SelectedIndex = -1;
            txtIdEkle.Clear();
            txtAdresEkle.Clear();
        }

        private void btnKaydetEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string tip = cmbTipEkle.SelectedItem?.ToString();
                int id = int.Parse(txtIdEkle.Text.Trim());
                string adres = txtAdresEkle.Text.Trim();

                if (string.IsNullOrEmpty(tip) || string.IsNullOrEmpty(adres))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                Mekan yeniMekan = null;

                if (tip == "Daire")
                    yeniMekan = new Daire { Id = id, Adres = adres };
                else if (tip == "Fitness")
                    yeniMekan = new Fitness { Id = id, Adres = adres };
                else if (tip == "Havuz")
                    yeniMekan = new Havuz { Id = id, Adres = adres };

                if (yeniMekan != null)
                {
                    DosyaYonetici.SatirEkle("Data/Mekan.txt", yeniMekan.ToString());
                    MessageBox.Show("Yeni mekan başarıyla eklendi!");

                    // Giriş alanlarını temizle
                    cmbTipEkle.SelectedIndex = -1;
                    txtIdEkle.Clear();
                    txtAdresEkle.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSilMekan_Click(object sender, EventArgs e)
        {
            if (lstMekanSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek mekanı seçin.");
                return;
            }

            string secilen = lstMekanSil.SelectedItem.ToString();
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");

            if (satirlar.Contains(secilen))
            {
                satirlar.Remove(secilen);
                DosyaYonetici.SatirlariYaz("Data/Mekan.txt", satirlar);

                MessageBox.Show("Mekan silindi.");
                MekanlariSilPanelindeGoster(); // listeyi güncelle
            }
            else
            {
                MessageBox.Show("Seçilen kayıt bulunamadı.");
            }
        }

        private void pnlSil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstMekanSil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            if (lstMekanSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek mekanı seçin.");
                return;
            }

            string secilen = lstMekanSil.SelectedItem.ToString().Trim();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Mekan.txt");

            // Trim ve eşitlik kontrolü ile temiz silme
            int silinen = satirlar.RemoveAll(s => s.Trim() == secilen);

            if (silinen > 0)
            {
                DosyaYonetici.SatirlariYaz("Data/Mekan.txt", satirlar);
                MessageBox.Show("Mekan silindi.");
                MekanlariSilPanelindeGoster(); // listeyi güncelle
            }
            else
            {
                MessageBox.Show("Seçilen kayıt bulunamadı.");
            }
        }
    }
}
