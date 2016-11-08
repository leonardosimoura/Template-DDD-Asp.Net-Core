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
        public virtual T Add(T obj)
        {
            context.Set<T>().Add(obj);
            return obj;
        }

        public virtual void Dispose()
        {
            //throw new NotImplementedException();
        }

        public virtual IQueryable<T> Query()
        {
            return context.Set<T>().AsQueryable();
        }

        public virtual T GetById(object id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual void Remove(T obj)
        {
            context.Set<T>().Remove(obj);
        }

        public virtual void Update(T obj)
        {
            context.Set<T>().Update(obj);
        }
    }
}
