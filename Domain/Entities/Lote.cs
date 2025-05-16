csharp
namespace Domain.Entities
{
    public class Lote
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int GalponId { get; set; }
        public Galpon Galpon { get; set; }
    }
}