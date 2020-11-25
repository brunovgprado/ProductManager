using Microsoft.EntityFrameworkCore;
using ProductManager.Domain.Entities;
using ProductManager.Infrastructure.Persistence.Mapping;
using System;

namespace ProductManager.Infrastructure.Persistence.Repositories
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("CONNECTIO_STRING"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        public DbSet<Produto> Produtos { get; }
    }
}
