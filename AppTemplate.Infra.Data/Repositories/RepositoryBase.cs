using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Infra.Data.Contexts;
using Microsoft.Data.Entity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Infra.Data.Repositories
{


    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private MainContext context = new MainContext();

        public RepositoryBase()
        {
            
        }
        T IRepositoryBase<T>.Add(T obj)
        {
            context.Set<T>().Add(obj);
            return obj;
        }

        void IRepositoryBase<T>.Dispose()
        {
            //throw new NotImplementedException();
        }

        IQueryable<T> IRepositoryBase<T>.Query()
        {
            return context.Set<T>().AsQueryable();
        }

        T IRepositoryBase<T>.GetById(object id)
        {
            return context.Set<T>().Find(id);
        }

        void IRepositoryBase<T>.Remove(T obj)
        {
            context.Set<T>().Remove(obj);
        }

        void IRepositoryBase<T>.Update(T obj)
        {
            context.Set<T>().Update(obj);
        }
    }
}
