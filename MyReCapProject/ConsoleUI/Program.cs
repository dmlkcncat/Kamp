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
            // BrandTest();
            // ColorTest();
            //CustomerTest();
            // UserTest();
            RentalTest();

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

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in customerManager.GetByCustomerId(3).Data)
                {
                    Console.WriteLine(item.CustomerId + " / " + item.CompanyName);
                }
            }
            else { Console.WriteLine(result.Message); }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EFUserDal());
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in userManager.GetCarsByUserId(3).Data)
                {
                    Console.WriteLine(item.UserId + " / " + item.FirstName + " " + item.LastName + " " + item.Email);
                }
            }
            else { Console.WriteLine(result.Message); }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in rentalManager.GetRentalsByUserId(3).Data)
                {
                    Console.WriteLine(item.RentalId + " / " + item.RentDate + " " + item.ReturnDate);
                }
            }
            else { Console.WriteLine(result.Message); }
        }


    }
}
