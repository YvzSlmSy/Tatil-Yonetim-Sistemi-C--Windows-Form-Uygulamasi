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
    public class Odeme
    {
        public int DaireNo { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }

        public override string ToString()
        {
            return $"{DaireNo},{Tutar},{Tarih.ToShortDateString()}";
        }
    }

}
