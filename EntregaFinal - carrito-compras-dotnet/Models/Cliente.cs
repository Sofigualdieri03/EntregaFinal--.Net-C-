namespace EntregaFinal___carrito_compras_dotnet.Models
{
    public class Cliente : Persona
    {
        public List<Carrito> Carritos { get; set; } = new List<Carrito>();
        public List<Compra> Compras { get; set; } = new List<Compra>();
    }
}
