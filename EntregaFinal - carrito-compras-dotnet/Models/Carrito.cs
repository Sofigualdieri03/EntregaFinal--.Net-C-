namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public bool Activo { get; set; }

        public Cliente Cliente { get; set; }
        public List<CarritoItem> CarritoItems { get; set; } = new List<CarritoItem>();
        // Calculado
        public decimal Subtotal => CarritoItems.Sum(ci => ci.Subtotal);
    }
}
