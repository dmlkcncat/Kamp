using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Tc: " + musteri.MusteriTc + " Tel: " + musteri.MusteriTel + " Adrtes: " + musteri.MusteriAdres);

        }

        public void MusteriEkle(string musteriAdi, string musteriSoyadi, string musteriTc, string musteriTel, string musteriAdres)
        {
            Console.WriteLine(musteriAdi + " " + musteriSoyadi + " Tc: " + musteriTc + " Tel: " + musteriTel + " Adres: " + musteriAdres);
            Console.WriteLine("Yeni musteri eklendi!");
        }

        public void MusteriSil (string musteriTc)
        {
            Console.WriteLine(musteriTc + " Tc sahip müsteri silindi!");
        }
    }
}
