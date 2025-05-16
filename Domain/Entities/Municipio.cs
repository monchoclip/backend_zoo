csharp
// Domain/Entities/Municipio.cs
namespace Domain.Entities
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoId { get; set; }

        // Relación: Un Municipio pertenece a un Departamento
        public Departamento Departamento { get; set; }
    }
}