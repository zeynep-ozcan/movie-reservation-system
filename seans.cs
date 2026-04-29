public class Seans
{
    public int SeansId {get; private set;}
    public Film Film {get; private set;}
    public Salon Salon {get; private set;}
    public string Tarih {get; private set;}
    public string Saat {get; private set;}
    public decimal Fiyat {get; private set;}

    public Seans(int seansId,Film film,Salon salon,string tarih,string saat,decimal fiyat)
    {
        if (film == null)
        {
            throw new ArgumentException("Film boş olamaz.");

        }
        if (salon==null)
        {
            throw new ArgumentException("Salon boş olamaz.");   

        }
        if (string.IsNullOrWhiteSpace(tarih))
        {
            throw new ArgumentException("Tarih boş olamaz.");
        }
        if (string.IsNullOrWhiteSpace(saat))
        {
            throw new ArgumentException("Saat boş olamaz.");

        }
        if (fiyat <= 0)
        {
            throw new ArgumentException("Fiyat 0'dan büyük olmalıdır.");

        }
SeansId=seansId;
Film=film;
Salon=salon;
Tarih=tarih;
Saat=saat;
Fiyat=fiyat;
    }
    public void BilgiGoster()
    {
        Console.WriteLine($"Seans ID: {SeansId}");
        Console.WriteLine($"Film: {Film.Ad}");
        Console.WriteLine($"Salon: {Salon.SalonAdi}");
        Console.WriteLine($"Tarih: {Tarih}");
        Console.WriteLine($"Saat: {Saat}");
        Console.WriteLine($"Fiyat: {Fiyat} TL");

    }
    public void TarihGuncelle(string yeniTarih)
    {
        if (string.IsNullOrWhiteSpace(yeniTarih))
        {
            throw new ArgumentException("Yeni tarih boş olamaz.");

        }
Tarih=yeniTarih;

    }
    public void SaatGuncelle(string yeniSaat)
    {
        if (string.IsNullOrWhiteSpace(yeniSaat))
        {
            throw new ArgumentException("Yeni saat boş olamaz.");
        }
        Saat=yeniSaat;
    }
    public void FiyatGuncelle(decimal yeniFiyat)
    {
        if (yeniFiyat <= 0)
        {
            throw new ArgumentException("Yeni fiyat 0'dan büyük olmalıdır.");

        }
        Fiyat=yeniFiyat;
    }
}