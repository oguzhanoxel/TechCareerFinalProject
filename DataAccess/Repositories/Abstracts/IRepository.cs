﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Abstracts
{
    public interface IRepository<T> where T : class, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
