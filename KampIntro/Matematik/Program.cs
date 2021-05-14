using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(2, 3);
            dortIslem.Topla(5, 7);

            Console.ReadLine();
        }
    }
}
