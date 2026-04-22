using System.ComponentModel.DataAnnotations;

namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Empleado : Persona
    {
        [Required]
        public string Legajo { get; set; }

    }
}
