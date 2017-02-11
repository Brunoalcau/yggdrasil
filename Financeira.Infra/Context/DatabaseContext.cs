using Microsoft.EntityFrameworkCore;
using Financeira.Domain.Entities;
using Financeira.Infra.Mapper;
using System.IO;

namespace Financeira.Infra.Context
{
    public class DatabaseContext: DbContext
    {
        public virtual DbSet<Business> Business  { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new BusinessMap(builder.Entity<Business>());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseMySql(@"Server=localhost;database=Financeira;uid=root;pwd=root;");
        }   
    }
}
