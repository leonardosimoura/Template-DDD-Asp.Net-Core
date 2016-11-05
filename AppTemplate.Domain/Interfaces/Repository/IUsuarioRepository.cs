using AppTemplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {

        Usuario Autenticar(string usuario, string senha);
    }
}
