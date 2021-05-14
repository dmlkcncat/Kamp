using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "java", "c#", "c++" , "python"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
            Console.ReadLine();
        }
    }
}
