using Core.Utilies.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetCarsByUserId(int id);
        IResult Add(User user);
    }
}
