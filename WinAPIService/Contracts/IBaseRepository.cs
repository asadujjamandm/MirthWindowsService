﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Contracts
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetByID(object id);
        void Add(T item);
        Task Update(T item);
        void Delete(object id);
        Task Save();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Dispose();
    }
}
