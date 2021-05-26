using Core.Utilies.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalsByUserId(int id);
        IResult Add(Rental rental);
    }
}
