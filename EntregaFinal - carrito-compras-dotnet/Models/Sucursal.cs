namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activa { get; set; } = true;
        public List<Compra> Compras { get; set; } = new();

        public List<StockItem> StockItems { get; set; } = new List<StockItem>();
    }
}
