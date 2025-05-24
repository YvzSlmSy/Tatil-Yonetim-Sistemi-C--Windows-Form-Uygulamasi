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
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TatilSitesiYonetimi.Classes
{
    public class Oturan
    {
        public long TcKimlik { get; set; }
        public string AdSoyad { get; set; }
        public int DaireId { get; set; }

        public virtual string Tip => "Oturan";

        public override string ToString()
        {
            return $"{Tip},{TcKimlik},{AdSoyad},{DaireId}";
        }
    }
}
