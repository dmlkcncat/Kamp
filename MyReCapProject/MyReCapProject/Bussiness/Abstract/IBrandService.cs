using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetCarsByBrandId(int id);
        void Add(Brand brand);
    }
}
