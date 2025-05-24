# 🏠 Tatil Sitesi Yönetim Sistemi

Bu proje, apartman ve tatil sitesi gibi toplu yaşam alanlarında mekan (daire, havuz, fitness), oturan (aile reisi, misafir) ve ödeme işlemlerinin yönetilmesini sağlayan bir Windows Forms (C#) uygulamasıdır.

---

## 🧩 Proje Özellikleri

🔹 **Mekan Yönetimi**
- Daire, Havuz ve Fitness mekanları ekleme/silme/düzenleme
- Mekan bilgilerini listeleme

🔹 **Kişi Yönetimi**
- Aile Reisi ve Misafir kayıtları
- Kişi ekleme, silme, düzenleme
- Daire bağlantısı ile sakini belirleme

🔹 **Ödeme Takibi**
- Daire bazlı ödeme (aidat vb.) girişleri
- Kayıt listeleme, silme, güncelleme
- Borç kontrolü

🔹 **Havuz ve Fitness Kullanımı**
- Aile Reisi → borç kontrolü ile kullanım (borç varsa "Kullandırılmadı")
- Misafir → her zaman kullanabilir
- Kullanım kayıtları `HavuzKul.txt` ve `Fitness.txt` dosyalarına yazılır

---

## 🗂️ Dosya Yapısı
📁 TatilSitesiYonetimi
┣ 📁 Classes
┃ ┣ Mekan.cs
┃ ┣ Daire.cs / Havuz.cs / Fitness.cs
┃ ┣ Oturan.cs / AileReisi.cs / Misafir.cs
┃ ┣ Odeme.cs
┃ ┣ DosyaYonetici.cs
┣ 📁 Forms
┃ ┣ FormMekan.cs
┃ ┣ FormKisi.cs
┃ ┣ FormOdeme.cs
┃ ┣ FormHavuzFitness.cs
┣ 📁 bin/Debug/Data
┃ ┣ Mekan.txt / Data.txt / Odeme.txt / HavuzKul.txt / Fitness.txt



---

## 📷 Ekran Görüntüsü

![Uygulama Ana Sayfa](ekran-goruntuleri/main-screen.png)

---

## 🔧 Kullanılan Teknolojiler

- 🖥️ C# (.NET Framework)
- 💻 Windows Forms (GUI)
- 📄 Dosya tabanlı veri yönetimi (txt)

---

## 📜 UML Sınıf Diyagramı

![image](https://github.com/user-attachments/assets/9ef1a544-a353-4767-96f9-90c326fb7c84)

---

## 🧠 Katkıda Bulunanlar

- **Yavuz Selim Say**   :D
  Sakarya Üniversitesi – Bilgisayar Mühendisliği  
  Nesneye Dayalı Programlama 

---

## ⚠️ Not

Bu proje, eğitim amaçlı hazırlanmıştır. Gerçek bir site yönetim sistemi için daha kapsamlı güvenlik, veritabanı ve yetkilendirme katmanları gereklidir.

