public class Musteri : Kisi
{
    public string Telefon {get; private set;}
    public Musteri(int id,string ad,string soyad,string telefon)
    : base(id, ad, soyad)
    {
        if (string.IsNullOrWhiteSpace(telefon))
        {
            throw new ArgumentException("Telefon boş olamaz.");

        }
        Telefon=telefon;
    }
    public override void BilgiGoster()
    {
        base.BilgiGoster();
        Console.WritLine($"Telefon:{Telefon}");

    }
    public void TelefonGuncelle(string yeniTelefon)
    {
        if (string.IsNullOrWhiteSpace(yeniTelefon))
        {
            throw new ArgumentException("Yeni telefon boş olamaz.");

        }
        Telefon=yeniTelefon;
    }
}