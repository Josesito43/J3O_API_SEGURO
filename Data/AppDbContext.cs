using System.Collections.Generic;
using J30_API_SEGURO.Models;
using Microsoft.EntityFrameworkCore;

namespace J30_API_SEGURO.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Seguro> Seguros { get; set; }

    }
}
