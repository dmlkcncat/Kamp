using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public  int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //ürünün fiyatı
        public double UnitPrice { get; set; }
        //ürün stok
        public int UnitInStock { set; get; }
    }
}
