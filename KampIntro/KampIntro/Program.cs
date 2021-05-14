using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar düşmüş");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Çıkmış");
            
            }
            else
            {
                Console.WriteLine("Dolar aynı kaldı");
            }

            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
