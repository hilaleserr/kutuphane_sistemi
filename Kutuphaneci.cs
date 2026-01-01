using System;

namespace KutuphaneProjesi
{
    public class Kutuphaneci : TemelKullanici
    {
        public double Maas { get; set; }
        public string Uzmanlik { get; set; }

        public override void BilgiGoruntule()
        {
            Console.WriteLine("Kütüphaneci Adı: " + Isim + " | ID: " + Id + " | Uzmanlık: " + Uzmanlik + " | Maaş: " + Maas);
        }
    }
}