using AppTemplate.AppService.Service;
using AppTemplate.Domain.Interfaces.Repository;
using AppTemplate.Domain.Interfaces.Service;
using AppTemplate.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace AppTemplate.Infra.CrossCutting
{
    public class RegisterDI
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            
            services.AddSingleton(typeof(IServiceBase<>), typeof(ServiceBase<>));

            //services.AddIdentity<Usuario, IdentityRole>()
            //.AddEntityFrameworkStores<MainContext>()
            //.AddDefaultTokenProviders();

            //services.Configure<IdentityOptions>(options =>
            //{
            //    // Password settings
            //    options.Password.RequireDigit = false;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequireLowercase = false;

            //    // Lockout settings
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
            //    options.Lockout.MaxFailedAccessAttempts = 10;

            //    // Cookie settings
            //    options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromDays(150);
            //    options.Cookies.ApplicationCookie.LoginPath = "/Conta/LogIn";
            //    options.Cookies.ApplicationCookie.LogoutPath = "/Conta/LogOff";

            //    // User settings
            //    options.User.RequireUniqueEmail = true;
            //});

            //services.AddDbContext<MainContext>();

            UsuarioDI.Register(services);
        }
    }
}
