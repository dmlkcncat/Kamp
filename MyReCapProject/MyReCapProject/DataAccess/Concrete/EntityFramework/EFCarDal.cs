using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Car
                             join b in context.Brand on c.BrandId equals b.BrandId
                             join a in context.Color on c.ColorId equals a.ColorId
                             select new CarDetailsDto {  BrandName = b.BrandName, ColorName = a.ColorName, DailyPrice = c.DailyPrice };

                return result.ToList();

            }
        }
    }
}
