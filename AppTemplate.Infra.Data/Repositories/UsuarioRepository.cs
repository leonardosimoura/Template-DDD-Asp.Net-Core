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

        public override IQueryable<Usuario> Query()
        {
            var list = new List<Usuario>() { new Usuario { Nome = "Leonardo", Email = "leonardosimoura@gmail.com" , Senha = "123456" , IdUsuario = 1 ,DataRegistro=DateTime.Now } };
            //return base.Query();
            return list.AsQueryable();
        }

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
