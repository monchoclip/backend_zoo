csharp
// Domain/Entities/Pais.cs
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación: Un País puede tener muchos Departamentos
        public ICollection<Departamento> Departamentos { get; set; }
    }
}