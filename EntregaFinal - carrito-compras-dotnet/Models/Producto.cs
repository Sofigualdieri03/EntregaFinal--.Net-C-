using System.ComponentModel.DataAnnotations;

namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Producto
    {
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        [Required]
        public decimal PrecioVigente { get; set; }
        public string? Imagen { get; set; }
        public bool Activo { get; set; }

        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }

        public Marca? Marca { get; set; }
        public Categoria Categoria { get; set; }

        public List<StockItem> StockItems { get; set; } = new List<StockItem>();
    }
}
