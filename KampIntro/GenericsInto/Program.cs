using System;

namespace GenericsInto
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string>  myList = new MyList <string>();
            myList.Add("Damla");

            Console.ReadLine();
        }
    }
}
