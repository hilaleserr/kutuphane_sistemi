using System;

namespace KutuphaneProjesi
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBN { get; set; }
        public string Tur { get; set; }
        public bool StokDurumu { get; set; }
        public Kutuphaneci AtanmisKutuphaneci { get; set; }

        // Kitap ücretlerini hesaplayan metot (kurgu=2, bilim=3, tarih=2, teknoloji=4).
        public double UcretHesapla()
        {
            if (Tur == "Kurgu") return 2;
            if (Tur == "Bilim") return 3;
            if (Tur == "Tarih") return 2;
            if (Tur == "Teknoloji") return 4;
            return 0;
        }

        public void KitapBilgiGoruntule()
        {
            string sorumlu = (AtanmisKutuphaneci != null) ? AtanmisKutuphaneci.Isim : "Atanmadı";
            Console.WriteLine("Kitap: " + KitapAdi + " | Tür: " + Tur + " | Sorumlu: " + sorumlu + " | Durum: " + (StokDurumu ? "Mevcut" : "Ödünçte"));
        }
    }
}