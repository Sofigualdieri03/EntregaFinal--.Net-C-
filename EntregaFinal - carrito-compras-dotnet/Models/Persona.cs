using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Persona : IdentityUser<int>

    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string DNI { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now;

    }
}
