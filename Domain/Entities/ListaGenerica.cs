csharp
// Domain/Entities/ListaGenerica.cs
namespace Domain.Entities
{
    public class ListaGenerica
    {
        public int Id { get; set; }
        public string TipoLista { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public int Orden { get; set; }
        public bool Activo { get; set; }
    }
}