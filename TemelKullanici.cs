namespace KutuphaneProjesi
{
    // TemelKullanıcı adında bir Abstract Class oluşturuldu.
    public abstract class TemelKullanici : IKullanici
    {
        public string Id { get; set; }
        public string Isim { get; set; }

        // Metot overriding (Polymorphism) için abstract metot.
        public abstract void BilgiGoruntule();
    }
}