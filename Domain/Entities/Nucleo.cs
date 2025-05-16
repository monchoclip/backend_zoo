csharp
// Domain/Entities/Nucleo.cs
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Nucleo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int GranjaId { get; set; }

        // Relación: Un Núcleo pertenece a una Granja
        public Granja Granja { get; set; }

        // Relación: Un Núcleo puede tener muchos Galpones
        public ICollection<Galpon> Galpones { get; set; }
    }
}