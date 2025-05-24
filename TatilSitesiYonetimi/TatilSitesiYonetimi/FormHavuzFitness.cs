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
    public partial class FormHavuzFitness: Form
    {
        public FormHavuzFitness()
        {
            InitializeComponent();
        }

        private void FormHavuzFitness_Load(object sender, EventArgs e)
        {
            // Hizmet türlerini yükle
            cmbHizmet.Items.AddRange(new string[] { "Havuz", "Fitness" });

            // Data.txt'den TC’leri yükle
            List<string> satirlar = DosyaYonetici.SatirlariOku("Data/Data.txt");
            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');
                if (parcalar.Length >= 2)
                {
                    cmbTc.Items.Add(parcalar[1]); // TCKimlik = 2. alan
                }
            }
            lblSonucHavuz.Font = new Font("Segoe UI", 11F, FontStyle.Bold); // Daha büyük ve butonlarla aynı stil
            lblSonucHavuz.BackColor = Color.White;                          // Arka planı beyaz
            lblSonucHavuz.ForeColor = Color.DarkGreen;                      // Varsayılan renk
            lblSonucHavuz.TextAlign = ContentAlignment.MiddleCenter;       // Yazı ortalansın
            lblSonucHavuz.AutoSize = false;                                 // Manuel boyut verelim
            lblSonucHavuz.Size = new Size(300, 40);                         // Geniş ve yüksek
            lblSonucHavuz.BorderStyle = BorderStyle.FixedSingle;            // Göz alıcı bir çerçeve
            lblSonucHavuz.Visible = false;                                  // Başlangıçta gizli

            // Arka plan resmi
            string resimYolu = Path.Combine(Application.StartupPath, "Images\\resim2.png");
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

            ButonStilUygula(btnHavuzKullan);

            // TC Label
            lblTcSec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTcSec.BackColor = Color.White;
            lblTcSec.ForeColor = Color.Black;

            // Hizmet Label
            lblHizmetSec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHizmetSec.BackColor = Color.White;
            lblHizmetSec.ForeColor = Color.Black;
            lblTcSec.BorderStyle = BorderStyle.FixedSingle;
            lblHizmetSec.BorderStyle = BorderStyle.FixedSingle;

            lblSonucHavuz.Visible = false;

        }
        private void btnHavuzKullan_Click(object sender, EventArgs e)
        {
            string secilenTc = cmbTc.SelectedItem?.ToString();
            string secilenHizmet = cmbHizmet.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(secilenTc) || string.IsNullOrEmpty(secilenHizmet))
            {
                lblSonucHavuz.Text = "Lütfen TC ve Hizmet türünü seçin.";
                lblSonucHavuz.ForeColor = Color.DarkRed;
                lblSonucHavuz.Visible = true;
                return;
            }

            var kisiler = DosyaYonetici.SatirlariOku("Data/Data.txt");
            string satir = kisiler.FirstOrDefault(k =>
            {
                var fields = k.Split(',');
                return fields.Length >= 2 && fields[1] == secilenTc;
            });

            if (satir == null)
            {
                lblSonucHavuz.Text = "Kişi bulunamadı.";
                lblSonucHavuz.ForeColor = Color.DarkRed;
                lblSonucHavuz.Visible = true;
                return;
            }

            string[] parca = satir.Split(',');
            string tip = parca[0];
            string adSoyad = parca[2];
            string daireNo = parca[3];

            bool kullanildi = true;
            string durum = "Kullandırıldı";

            if (tip == "AileReisi")
            {
                List<string> odemeler = DosyaYonetici.SatirlariOku("Data/Odeme.txt");
                var daireOdemeleri = odemeler.Where(x => x.StartsWith(daireNo + ",")).ToList();

                decimal toplamOdeme = 0;
                foreach (var odeme in daireOdemeleri)
                {
                    string[] o = odeme.Split(',');
                    if (decimal.TryParse(o[1], out decimal tutar))
                        toplamOdeme += tutar;
                }

                if (toplamOdeme < 500)
                {
                    kullanildi = false;
                    durum = "Kullandırılmadı";
                }
            }

            // ✔️ Renk kararını buraya alıyoruz:
            if (kullanildi)
            {
                lblSonucHavuz.ForeColor = Color.DarkGreen; // Kullandırıldıysa yeşil
            }
            else
            {
                lblSonucHavuz.ForeColor = Color.DarkRed; // Borç varsa kırmızı
            }

            lblSonucHavuz.Text = $"İşlem tamamlandı: {durum}";
            lblSonucHavuz.Visible = true;

            // Kayıt satırı
            string kayit = $"{secilenTc},{adSoyad},{daireNo},{secilenHizmet},{durum}";
            string hedefDosya = secilenHizmet == "Havuz" ? "Data/HavuzKul.txt" : "Data/Fitness.txt";

            DosyaYonetici.SatirEkle(hedefDosya, kayit);
        }


    }
}
