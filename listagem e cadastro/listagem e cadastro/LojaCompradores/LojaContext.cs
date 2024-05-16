using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace LojaCompradores
{
    public class LojaContext : DbContext
    {
        public DbSet<Comprador> Compradores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=loja;Uid=root;Pwd=sua_senha;",
                                    new MySqlServerVersion(new Version(8, 0, 0)));
        }
    }
}
