csharp
// Domain/Entities/Granja.cs
using System.Collections.Generic; // Asegúrate de tener este using para ICollection

namespace Domain.Entities
{
    public class Granja
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int CompaniaId { get; set; } // Clave foránea
        public Compania Compania { get; set; } // Propiedad de navegación

        public ICollection<Nucleo> Nucleos { get; set; } // Relación one-to-many

        public Granja()
        {
            Nucleos = new HashSet<Nucleo>(); // Inicializa la colección
        }
    }
}