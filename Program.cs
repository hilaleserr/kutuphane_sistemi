using System;

namespace KutuphaneProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane yonetim = new Kutuphane();
            string secim = "";

            while (secim != "0")
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1-Kitap Ekle | 2-Üye Ekle | 3-Kütüphaneci Ekle | 4-Ödünç | 5-İade | 6-Listele | 0-Çıkış");
                Console.Write("Seçim: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Kitap k = new Kitap();
                        Console.Write("Ad: "); k.KitapAdi = Console.ReadLine();
                        Console.Write("Tür: "); k.Tur = Console.ReadLine();
                        Console.Write("ISBN: "); k.ISBN = Console.ReadLine();
                        k.StokDurumu = true;
                        yonetim.KitapEkle(k);
                        break;
                    case "2":
                        Uye u = new Uye();
                        Console.Write("İsim: "); u.Isim = Console.ReadLine();
                        Console.Write("ID: "); u.Id = Console.ReadLine();
                        Console.Write("Tip: "); u.UyelikTipi = Console.ReadLine();
                        yonetim.uyeler.Add(u);
                        break;
                    case "3":
                        Kutuphaneci kt = new Kutuphaneci();
                        Console.Write("İsim: "); kt.Isim = Console.ReadLine();
                        Console.Write("ID: "); kt.Id = Console.ReadLine();
                        Console.Write("Uzmanlık: "); kt.Uzmanlik = Console.ReadLine();
                        Console.Write("Maaş: "); kt.Maas = Convert.ToDouble(Console.ReadLine());
                        yonetim.kutuphaneciler.Add(kt);
                        break;
                    case "4":
                        Console.Write("Üye ID: "); string uid = Console.ReadLine();
                        Console.Write("ISBN: "); string isbn = Console.ReadLine();
                        Uye uBul = yonetim.uyeler.Find(x => x.Id == uid);
                        Kitap kBul = yonetim.kitaplar.Find(x => x.ISBN == isbn);
                        if (uBul != null && kBul != null && kBul.StokDurumu)
                        {
                            kBul.StokDurumu = false;
                            uBul.OduncAl(kBul);
                        }
                        break;
                    case "5":
                        Console.Write("Üye ID: "); string iadeId = Console.ReadLine();
                        Console.Write("ISBN: "); string iadeIsbn = Console.ReadLine();
                        Uye uIade = yonetim.uyeler.Find(x => x.Id == iadeId);
                        Kitap kIade = yonetim.kitaplar.Find(x => x.ISBN == iadeIsbn);
                        if (uIade != null && kIade != null)
                        {
                            uIade.IadeEt(iadeIsbn);
                            kIade.StokDurumu = true;
                        }
                        break;
                    case "6":
                        foreach (var kitap in yonetim.kitaplar) kitap.KitapBilgiGoruntule();
                        break;
                    case "7":
                        foreach (var uye in yonetim.uyeler) uye.BilgiGoruntule();
                        break;
                }
            }
        }
    }
}