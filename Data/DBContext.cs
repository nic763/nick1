using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_nicol.Models;

namespace proyecto_nicol.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<USUARIOMODEMN> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USUARIOMODEMN>().HasKey(U => U.Asuario_Id);
            modelBuilder.Entity<USUARIOMODEMN>().Property(U => U.Asuario_Id).ValueGeneratedOnAdd();
        }

    }
}
