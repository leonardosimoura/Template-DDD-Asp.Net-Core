using AppTemplate.Domain.Entities;
using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.AppService.Service
{
    public class UserService : ServiceBase<Usuario>, IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        Usuario IServiceBase<Usuario>.Add(Usuario obj)
        {
           obj.Registrar();

           return  _repository.Add(obj);
        }

        //void IServiceBase<Usuario>.Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<Usuario> IServiceBase<Usuario>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //Usuario IServiceBase<Usuario>.GetById(object id)
        //{
        //    throw new NotImplementedException();
        //}

        //void IServiceBase<Usuario>.Remove(Usuario obj)
        //{
        //    throw new NotImplementedException();
        //}

        //void IServiceBase<Usuario>.Update(Usuario obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
