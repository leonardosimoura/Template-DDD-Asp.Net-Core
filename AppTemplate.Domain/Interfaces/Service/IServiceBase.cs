using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Domain.Interfaces.Service
{
    public interface IServiceBase<T> where T : class
    {
        IQueryable<T> Query();

        T GetById(object id);

        T Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
