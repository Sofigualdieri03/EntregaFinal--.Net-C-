using System.ComponentModel.DataAnnotations;

namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string ?Descripcion { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
