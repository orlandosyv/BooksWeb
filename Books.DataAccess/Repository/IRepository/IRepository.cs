﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Books.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T,bool>> filter, string? includeProperties = null);

        // Add, Remove, Remove all in the Repository Interface.
        // Update does not come here because it is complex for different classes
        // update goes in other place.

        void Add(T entity);
        //void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
