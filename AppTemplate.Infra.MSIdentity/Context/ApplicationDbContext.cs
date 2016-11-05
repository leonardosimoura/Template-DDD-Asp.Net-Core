using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppTemplate.Infra.MSIdentity.Context
{
    public class Usuario : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>()
            .ToTable("Usuario")
            .Property(p => p.Id)
            .HasColumnName("IdUsuario");

            builder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(p => p.Id)
                .HasColumnName("IdUsuario");
        }
    }
}
