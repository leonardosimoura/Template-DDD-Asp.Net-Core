using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Domain.Interfaces.Service;
using AppTemplate.AppService.Service;
using AppTemplate.Infra.Data.Repositories;

namespace AppTemplate.Infra.CrossCutting
{
    public class UsuarioDI
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}


