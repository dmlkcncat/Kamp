using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
           
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + "/" + item.CategoryName);
            }
        }
    }
}
