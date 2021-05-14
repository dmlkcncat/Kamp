using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sehirler = new Dictionary<string, int> ();
            sehirler.Add("Ankara", 06);
            sehirler.Add("Zonguldak", 67);

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(sehirler.Count);

            MyDictonary<string, int> sehirler2 = new MyDictonary<string, int>();
            sehirler2.Add("Istanbul", 34);
            sehirler2.Add("Bolu", 14);
            sehirler2.Add("Izmit", 41);


           

            Console.ReadLine();
        }
    }
}
