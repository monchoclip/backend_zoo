csharp
// Domain/Entities/Galpon.cs
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Galpon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NucleoId { get; set; }

        // Relación: Un Galpon pertenece a un Núcleo
        public Nucleo Nucleo { get; set; }

        // Relación: Un Galpon puede tener muchos Lotes
        public ICollection<Lote> Lotes { get; set; }
    }
}