using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Engin Demigrog";
            kurs1.IzlenmeOrani = 34;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.KursunEgitmeni = "umut hoca";
            kurs2.IzlenmeOrani = 23;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "sql";
            kurs3.KursunEgitmeni = "Erkan hoca";
            kurs3.IzlenmeOrani = 12;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni + " %" + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni + " %" + kurs.IzlenmeOrani );

            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
