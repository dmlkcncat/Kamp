using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyat = 80;
            urun2.Aciklama = "Diyarbarkır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.UrunAdi + " " + item.UrunFiyat + " " + item.Aciklama);
            }

            Console.WriteLine("-------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            

            

            Console.ReadLine();
        }
    }
}
