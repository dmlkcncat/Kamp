using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Hakan";
            musteri1.MusteriTc = "111111111";
            musteri1.MusteriTel = "053211111";
            musteri1.MusteriAdres = "Zonguldak";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Melis";
            musteri2.MusteriSoyadi = "Pinar";
            musteri2.MusteriTc = "222222222";
            musteri2.MusteriTel = "0532222222";
            musteri2.MusteriAdres = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Deniz";
            musteri3.MusteriSoyadi = "Akdeniz";
            musteri3.MusteriTc = "333333333";
            musteri3.MusteriTel = "0532333333";
            musteri3.MusteriAdres = "Istanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriListeleme(musteri3);

            Console.WriteLine("-----------------------------------");

            musteriManager.MusteriEkle("Selin", "Helin", "444444444", "05324444444", "Bolu");

            Console.WriteLine("------------------------------------");

            musteriManager.MusteriSil("11111111111");

            Console.ReadLine();
        }
    }
}
