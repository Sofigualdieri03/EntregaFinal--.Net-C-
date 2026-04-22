namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public int ProductoId { get; set; } // FK
        public Producto Producto { get; set; } // navegación

        public int SucursalId { get; set; }

        
        public Sucursal Sucursal { get; set; }
    }
}
