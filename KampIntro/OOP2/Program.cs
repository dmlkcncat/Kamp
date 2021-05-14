using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.TcNo = "1234";
            musteri1.Ad = "Damla";
            musteri1.Soyad = "Akcin";
            musteri1.TcNo = "121111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "bülentecevit";
            musteri2.MusteriNo = "1233";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


            Console.ReadLine();
        }
    }
}
