using System.Collections.Generic;

namespace KutuphaneProjesi
{
    public class Kutuphane
    {
        public List<Kitap> kitaplar = new List<Kitap>();
        public List<Uye> uyeler = new List<Uye>();
        public List<Kutuphaneci> kutuphaneciler = new List<Kutuphaneci>();

        public void KitapEkle(Kitap k)
        {
            KutuphaneciyiKitabaAta(k);
            kitaplar.Add(k);
        }

        public void KutuphaneciyiKitabaAta(Kitap k)
        {
            foreach (var calisan in kutuphaneciler)
            {
                if (calisan.Uzmanlik == k.Tur)
                {
                    k.AtanmisKutuphaneci = calisan;
                }
            }
        }
    }
}