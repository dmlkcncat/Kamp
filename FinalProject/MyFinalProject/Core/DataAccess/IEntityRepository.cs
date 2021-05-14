
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constaint --> class derken referans tip olabilir --> 
    //IEntity veya IEntityden impelemente bir class olabilir
    //newlenebilirdir, IEntity interface olduğundan newlenemez

    public interface IEntityRepository <T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filte);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
