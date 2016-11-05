using AppTemplate.Infra.MSIdentity.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AppTemplate.Infra.MSIdentity
{
    public class RegisterDI
    {
        public static void Register(IServiceCollection services)
        {
            services.AddEntityFramework()
        .AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(@"Server=LEONARDONOTE\SQL2016;Database=EntityCore;Trusted_Connection=True;"));

            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}
