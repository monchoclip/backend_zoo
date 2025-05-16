csharp
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Compania
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string TipoDocumento { get; set; }

        // Relación: Una Compañía puede tener muchas Granjas
        public ICollection<Granja> Granjas { get; set; }
    }
}