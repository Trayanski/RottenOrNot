﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace RottenOrNot.Data.Contracts
{
    public interface IRepository<T> 
    {
        void InsertOrUpdate(T entity);

        void Insert(T entity);

        void Delete(T entity);

        T FindByPredicate(Expression<Func<T, bool>> predicate);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();

        T GetById(int id);
    }
}
