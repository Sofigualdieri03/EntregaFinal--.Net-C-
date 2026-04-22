using EntregaFinal___carrito_compras_dotnet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntregaFinal___carrito_compras_dotnet.Data
{
    // Configura el modelo de Entity Framework. Se utiliza para indicar que las propiedades
    // Subtotal de Carrito y CarritoItem no deben persistirse en la base de datos,
    // ya que son valores calculados en tiempo de ejecución y no datos almacenados.
    //dbContex declara tablas, se agregarn a la base de datos, se configura el modelo
    public class CarritoDbContext : DbContext
    {
        public CarritoDbContext(DbContextOptions<CarritoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<CarritoItem> CarritoItems { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<StockItem> StockItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarritoItem>()
                .Ignore(ci => ci.Subtotal);

            modelBuilder.Entity<Carrito>()
                .Ignore(c => c.Subtotal);
        }
    }
}