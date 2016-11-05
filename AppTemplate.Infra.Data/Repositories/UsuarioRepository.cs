using AppTemplate.Domain.Entities;
using AppTemplate.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {

        Usuario IUsuarioRepository.Autenticar(string usuario, string senha)
        {
            var usu = Query().FirstOrDefault(u => u.Email == usuario && u.Senha == senha);

            if (usu == null)
            {
                usu = Query().FirstOrDefault(u => u.Email == usuario);
                if (usu != null)
                {
                    throw new Exception("Senha incorreta.");
                }
                else
                {
                    throw new Exception("Usuário e/ou senha incorretos;");
                }
            }

            return usu;
        }
    }
}
