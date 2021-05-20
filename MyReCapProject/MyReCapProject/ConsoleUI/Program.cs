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
            // CarTest();
             BrandTest();
            // ColorTest();

            Console.ReadLine();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success == true)
            {
                foreach (var item in carManager.GetCarDetails().Data)
                 {
                Console.WriteLine( item.BrandName + " / " + item.ColorName + " / " + item.DailyPrice );
                 }
            }
            else { Console.WriteLine(result.Message); }
            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in brandManager.GetAll().Data)
                {
                    Console.WriteLine(item.BrandId + " / " + item.BrandName);
                }
            }
            else { Console.WriteLine(result.Message);  }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
              foreach (var item in colorManager.GetCarsByColorId(3).Data)
               {
                Console.WriteLine(item.ColorId + " / " + item.ColorName);
               }
            }
            else { Console.WriteLine(result.Message); }
        }


    }
}
