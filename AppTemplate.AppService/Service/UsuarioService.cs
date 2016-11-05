using AppTemplate.Domain.Entities;
using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.AppService.Service
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        Usuario IServiceBase<Usuario>.Add(Usuario obj)
        {
           obj.Registrar();

           return  _repository.Add(obj);
        }

        Usuario IUsuarioService.Autenticar(string usuario, string senha)
        {
            return _repository.Autenticar(usuario, senha);
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
