using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length >= 3 && user.LastName.Length >= 3)
            {
                return new SuccessResult(Messages.Added);
            }
            _userDal.Add(user);
            return new ErrorResult(Messages.UserAddedError);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<User>> GetCarsByUserId(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.UserId == id));
        }
    }
}
