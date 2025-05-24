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

namespace TatilSitesiYonetimi.Classes
{
    public abstract class Mekan
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        public abstract string Tip { get; }

        public override string ToString()
        {
            return $"{Tip},{Id},{Adres}";
        }
    }
}
