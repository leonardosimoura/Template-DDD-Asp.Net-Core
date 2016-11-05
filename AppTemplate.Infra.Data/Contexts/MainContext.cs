using AppTemplate.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Infra.Data.Contexts
{
    
        public class MainContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LEONARDONOTE\SQL2016;Database=EntityCore;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Properties<string>()
            //   .Configure(p => p.HasColumnType("varchar"));

            //modelBuilder.Entity<Usuario>(entity =>
            //{
            //    entity.Property(e => e.DataRegistro).IsRequired().HasDefaultValueSql("getdate()");
            //});                   

            //modelBuilder.Entity<Post>(entity =>
            //{
            //    entity.HasOne(d => d.Blog)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.BlogId);
            //});
    }

        #region DbSet
                
        public virtual DbSet<Usuario> Teste { get; set; }

        #endregion
    }
}
