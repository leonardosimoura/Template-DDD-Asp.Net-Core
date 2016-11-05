using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.AppService.Service
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repostory;
        public ServiceBase(IRepositoryBase<T> repostory)
        {
            _repostory = repostory;
        }
        public T Add(T obj)
        {
            return _repostory.Add(obj);
        }

        public IQueryable<T> Query()
        {
            return _repostory.Query();
        }

        public T GetById(object id)
        {
            return _repostory.GetById(id);
        }

        public void Remove(T obj)
        {
            _repostory.Remove(obj);
        }

        public void Update(T obj)
        {
            _repostory.Update(obj);
        }

        public void Dispose()
        {
            _repostory.Dispose();
        }

    }
}
