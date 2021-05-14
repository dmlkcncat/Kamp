using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Eren", "Umut", "Damla", "Hilal" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Eren" , "Umut", "Damla", "Hilal"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Selin");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);

            Console.ReadLine();
        }
    }
}
