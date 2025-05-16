csharp
// Domain/Entities/Departamento.cs
namespace Domain.Entities
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PaisId { get; set; } // Clave foránea

        // Relación: Un Departamento pertenece a un País
        public Pais Pais { get; set; }

        // Relación: Un Departamento puede tener muchos Municipios
        public ICollection<Municipio> Municipios { get; set; }
    }
}