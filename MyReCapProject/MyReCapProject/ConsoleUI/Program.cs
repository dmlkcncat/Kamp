using Bussiness.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();
            // BrandTest();
            // ColorTest();

            Console.ReadLine();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine( item.BrandName + " / " + item.ColorName + " / " + item.DailyPrice );
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandId + " / " + item.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());

            foreach (var item in colorManager.GetCarsByColorId(3))
            {
                Console.WriteLine(item.ColorId + " / " + item.ColorName);
            }
        }


    }
}
