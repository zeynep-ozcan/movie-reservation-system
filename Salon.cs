public class Salon
{
    public int SalonId {get; private set;}
    public string SalonAdi{get; private set;}
    public int Kapasite { get; private set;}

    public Salon (int salonId,string salonAdi , int kapasite)
    {
        if (string.IsNullOrWhiteSpace(salonAdi))
        {
            throw new ArgumentException("Salon adı boş olamaz.");

        }
        if (kapasite <= 0)
        {
            throw new ArgumentException("Kapasite 0'dan büyük olamaz.");

        }
SalonId=salonId;
SalonAdi=salonAdi;
Kapasite=kapasite;

    }
    public void BilgiGoster()
    {
        ConsoleWriteLine($"Salon ID:{SalonId}");
        ConsoleWriteLine($"Salon Adı:{SalonAdi}");
        ConsoleWriteLine($"Kapasite:{Kapasite}");
    }
    public void SalonAdiGuncelle(string yeniAd)
    {
        if (string.IsNullOrWhiteSpace(yeniAd))
        {
            throw new ArgumentException("Yeni salon adı boş olamaz.");

        }
        SalonAdi=yeniAd;
    }
    public void KapasiteGuncelle(int yeniKapasite)
    {
        if (yeniKapasite <= 0)
        {
         throw new ArgumentException ("Kapasite 0'dan büyük olmalıdır.");

        }
        Kapasite=yeniKapasite;
    }


}