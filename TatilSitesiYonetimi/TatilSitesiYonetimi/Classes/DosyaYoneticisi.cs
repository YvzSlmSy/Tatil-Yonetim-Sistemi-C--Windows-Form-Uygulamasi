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
using System.IO;

namespace TatilSitesiYonetimi.Classes
{
    public static class DosyaYonetici
    {
        public static void SatirEkle(string dosya, string satir)
        {
            string klasor = Path.GetDirectoryName(dosya);
            if (!Directory.Exists(klasor))
                Directory.CreateDirectory(klasor);

            if (!File.Exists(dosya))
                File.Create(dosya).Close();

            using (StreamWriter sw = new StreamWriter(dosya, true, Encoding.UTF8))
            {
                sw.WriteLine(satir);
            }
        }


        public static List<string> SatirlariOku(string path)
        {
            if (!File.Exists(path)) return new List<string>();
            return new List<string>(File.ReadAllLines(path));
        }

        public static void SatirlariYaz(string path, List<string> satirlar)
        {
            File.WriteAllLines(path, satirlar);
        }
    }
}
