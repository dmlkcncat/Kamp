using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 1300, Description = "Sedan Otomatik", ModelYear = "2020" },
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 1700, Description = "HatchBack Otomatik", ModelYear = "2021" },
                new Car{CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 950, Description = "HatchBack Otomatik", ModelYear = "2016" },
                new Car{CarId = 4, BrandId = 2, ColorId = 1, DailyPrice = 1150, Description = "Sedan Manuel", ModelYear = "2018" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
