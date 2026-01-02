Kütüphane Yönetim Sistemi - NTP Final Projesi

Bu proje, Nesne Tabanlı Programlama (OOP) prensipleri kullanılarak C# dilinde geliştirilmiş bir Console uygulamasıdır.
Sistem; kitap, üye ve kütüphaneci yönetimini sağlayan dijital bir kütüphane otomasyonudur.


🛠 Kullanılan Teknolojiler ve Prensipler
Proje kapsamında aşağıdaki Nesne Tabanlı Programlama prensipleri uygulanmıştır:

Inheritance (Kalıtım): Kutuphaneci ve Uye sınıfları TemelKullanici abstract sınıfından miras almaktadır.

Abstract Class (Soyut Sınıf): Ortak özellikleri barındıran TemelKullanici sınıfı soyut bir yapıda tasarlanmıştır.

Interface (Arayüz): Kullanıcı kimlik bilgileri IKullanici interface'i üzerinden standartlaştırılmıştır.

Polymorphism (Çok Biçimlilik): BilgiGoruntule metodu miras alan sınıflarda override edilerek çok biçimlilik sağlanmıştır.

Encapsulation (Kapsülleme): Erişim belirleyiciler (Public, Private) kullanılarak doğru veri kapsüllemesi yapılmıştır.


📖 Sistem Özellikleri

Otomatik Kütüphaneci Ataması: Yeni eklenen kitaplar, türlerine göre ilgili uzmanlık alanındaki kütüphanecilere otomatik olarak atanır.

Dinamik Ücret Hesaplama: Kitap türlerine göre (Kurgu=2, Bilim=3, Tarih=2, Teknoloji=4) otomatik ücretlendirme yapılır.

Ödünç Alma ve İade: Üye ID ve ISBN üzerinden ödünç alma ve iade işlemleri gerçekleştirilir; süreç Dictionary yapısı ile takip edilir.

Kapsamlı Menü: Switch-case yapısı ile kitap, üye ve kütüphaneci ekleme ve listeleme işlemleri yönetilir.


🚀 Kurulum ve Çalıştırma
Bu repository'yi bilgisayarınıza indirin veya klonlayın.

Visual Studio üzerinde projeyi açın.

F5 tuşuna basarak uygulamayı çalıştırın.

Menü üzerinden kütüphaneci, kitap ve üye tanımlamalarını yaparak sistemi kullanmaya başlayın.

Geliştiren: Hilal Şuheda ESER

Ders: Nesne Tabanlı Programlama (Final Projesi)






