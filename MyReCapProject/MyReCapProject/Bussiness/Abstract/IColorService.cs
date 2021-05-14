using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetCarsByColorId(int id);
        void Add(Color color);
    }
}
