public class Film
{
    public int  FilmId { get; private set; }
    public string Ad{get; private set; }
    public string Tur{get; private set; }
    public int Sure {get; private set; }

    public Film(int filmId,string ad,string tur,int sure)
    {
        if (string.IsNullOrWhiteSpace(ad))
        {
            throw new ArgumentExpection("Film adı boş olamaz.");
        }
        if (string.IsNullOrWhiteSpace(tur))
        {
            throw new ArgumentExpection ("Film türü bos olamaz.");

        }
        if (sure <= 0)
        {
            throw new ArgumentExpection("Film süresi 0'dan büyük olmalıdır.");

        }
FilmId=filmId;
Ad=ad;
Tur=tur;
Sure=sure;


    }
    public void BilgiGoster()
    {
        ConsoleWriteLine($"Film ID:{FilmId}");
        ConsoleWriteLine($"Ad:{Ad}");
        ConsoleWriteLine($"Tür:{Tur}");
        ConsoleWriteLine($"Süre:{Sure} dakika");

    }
 
 public void AdGuncelle(string yeniAd){
 if (string.IsNullOrWhiteSpace(yeniAd))
    {
        throw new ArgumentExpections("Yeni film adı boş olamaz.");

    }
Ad=yeniAd;
}
public void TurGuncelle(string yeniTur)
    {
        if (string.IsNullOrWhiteSpace)



    }


}
