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
    public partial class FormOdeme: Form
    {

        public FormOdeme()
        {
            InitializeComponent();
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            DaireleriYukle();

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

            ButonStilUygula(btnOdemeEkle);
            ButonStilUygula(btnOdemeListele);
            ButonStilUygula(btnOdemeCikart);
            ButonStilUygula(btnOdemeDuzenle);

        }
        private void DaireleriYukle()
        {
            List<string> kisiler = DosyaYonetici.SatirlariOku("Data/Data.txt");

            var daireNumaralari = kisiler
                .Select(k => k.Split(','))
                .Where(k => k.Length >= 4)
                .Select(k => k[3]) // DaireNo
                .Distinct()
                .ToList();

            cmbDaireNoOdeme.Items.Clear();
            cmbDaireNoOdeme.Items.AddRange(daireNumaralari.ToArray());
        }



        private void btnOdemeKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDaireNoOdeme.SelectedItem == null || string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                MessageBox.Show("Lütfen daire seçin ve tutar girin.");
                return;
            }

            int daireNo = int.Parse(cmbDaireNoOdeme.SelectedItem.ToString());
            decimal tutar = decimal.Parse(txtTutar.Text.Trim());
            DateTime tarih = dtpTarih.Value;

            Odeme odeme = new Odeme
            {
                DaireNo = daireNo,
                Tutar = tutar,
                Tarih = tarih
            };

            DosyaYonetici.SatirEkle("Data/Odeme.txt", odeme.ToString());

            MessageBox.Show("Ödeme başarıyla kaydedildi!");

            // Temizle
            cmbDaireNoOdeme.SelectedIndex = -1;
            txtTutar.Clear();
            dtpTarih.Value = DateTime.Today;
        }

        private void OdemePanelleriniGizle()
        {
            pnlOdemeEkle.Visible = false;
            pnlOdemeListele.Visible = false;
            pnlOdemeSil.Visible = false;
            pnlOdemeDuzenle.Visible = false;
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            OdemePanelleriniGizle();
            pnlOdemeEkle.Visible = true;
            DaireleriYukle(); // ✅ BURAYA EKLİYORSUN

            // Giriş alanlarını temizle
            txtTutar.Clear();
            dtpTarih.Value = DateTime.Today;
        }
        private void OdemeleriListele()
        {
            lstOdemeler.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Odeme.txt");

            foreach (string satir in satirlar)
            {
                lstOdemeler.Items.Add(satir);
            }

            if (satirlar.Count == 0)
                MessageBox.Show("Kayıtlı ödeme bulunamadı.");
        }

        private void btnOdemeListele_Click(object sender, EventArgs e)
        {
            OdemePanelleriniGizle();
            pnlOdemeListele.Visible = true;
            OdemeleriListele();
        }

        private void btnYenileOdeme_Click(object sender, EventArgs e)
        {
            OdemeleriListele();
        }
        private void OdemeleriSilPanelindeGoster()
        {
            lstOdemeSil.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Odeme.txt");

            foreach (string satir in satirlar)
            {
                lstOdemeSil.Items.Add(satir);
            }
        }

        private void btnOdemeCikart_Click(object sender, EventArgs e)
        {
            OdemePanelleriniGizle();
            pnlOdemeSil.Visible = true;
            OdemeleriSilPanelindeGoster();
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            if (lstOdemeSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek ödemeyi seçin.");
                return;
            }

            string secilen = lstOdemeSil.SelectedItem.ToString().Trim();
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Odeme.txt");

            int silinen = satirlar.RemoveAll(s => s.Trim() == secilen);

            if (silinen > 0)
            {
                DosyaYonetici.SatirlariYaz("Data/Odeme.txt", satirlar);
                MessageBox.Show("Ödeme başarıyla silindi.");
                OdemeleriSilPanelindeGoster(); // Listeyi güncelle
            }
            else
            {
                MessageBox.Show("Seçilen kayıt dosyada bulunamadı.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void OdemeleriDuzenlePanelindeGoster()
        {
            lstOdemeDuzenle.Items.Clear();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Odeme.txt");

            foreach (string satir in satirlar)
            {
                lstOdemeDuzenle.Items.Add(satir);
            }
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            OdemePanelleriniGizle();
            pnlOdemeDuzenle.Visible = true;
            OdemeleriDuzenlePanelindeGoster();
        }

        private void lstOdemeDuzenle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOdemeDuzenle.SelectedItem == null) return;

            string[] parca = lstOdemeDuzenle.SelectedItem.ToString().Split(',');

            if (parca.Length >= 3)
            {
                txtDaireNoDuzenle.Text = parca[0];
                txtTutarDuzenle.Text = parca[1];
                dtpTarihDuzenle.Value = DateTime.Parse(parca[2]);
            }
        }

        private void btnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOdemeDuzenle.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            string eskiSatir = lstOdemeDuzenle.SelectedItem.ToString();

            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Odeme.txt");
            satirlar.RemoveAll(s => s.Trim() == eskiSatir.Trim());

            string yeniDaire = txtDaireNoDuzenle.Text.Trim();
            string yeniTutar = txtTutarDuzenle.Text.Trim();
            string yeniTarih = dtpTarihDuzenle.Value.ToShortDateString();

            string yeniSatir = $"{yeniDaire},{yeniTutar},{yeniTarih}";
            satirlar.Add(yeniSatir);

            DosyaYonetici.SatirlariYaz("Data/Odeme.txt", satirlar);
            MessageBox.Show("Ödeme başarıyla güncellendi.");

            OdemeleriDuzenlePanelindeGoster(); // Listeyi yenile
        }

    }
}
