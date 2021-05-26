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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length >= 3)
            {
                return new SuccessResult(Messages.ColorAdded);
            }
            _colorDal.Add(color);
            return new ErrorResult(Messages.ColorAddedError);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
        }

        public IDataResult<List<Color>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(p => p.ColorId == id));
        }
    }
}
