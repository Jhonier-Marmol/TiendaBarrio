
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Datos
{
    public class TiendaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tienda.db");

        }
       
    }
}
