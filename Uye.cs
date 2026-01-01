using System;
using System.Collections.Generic;

namespace KutuphaneProjesi
{
    public class Uye : TemelKullanici
    {
        public string UyelikTipi { get; set; }
        public double Ucret { get; set; }
        // Ödünç alınan kitaplar dictionary kullanılarak oluşturuldu.
        public Dictionary<string, string> OduncKitaplar = new Dictionary<string, string>();

        public override void BilgiGoruntule()
        {
            Console.WriteLine("Üye: " + Isim + " | ID: " + Id + " | Tip: " + UyelikTipi + " | Borç: " + Ucret);
        }

        public void OduncAl(Kitap kitap)
        {
            OduncKitaplar.Add(kitap.ISBN, kitap.KitapAdi);
            Ucret += kitap.UcretHesapla();
        }

        public void IadeEt(string isbn)
        {
            if (OduncKitaplar.ContainsKey(isbn))
            {
                OduncKitaplar.Remove(isbn);
            }
        }
    }
}