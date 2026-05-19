using BackendProductos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackendProductos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}