namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }

        public int ClienteId { get; set; }
        public int CarritoId { get; set; }
        public int SucursalId { get; set; }

        public Cliente Cliente { get; set; }
        public Carrito Carrito { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
