namespace Etapa1.Entidades
{
    public class Alumnos
    {
        public string? UniqueId { get; set;}
        public string Nombre { get; set ;} = Guid.NewGuid().ToString();
        public List<Evaluaciones>? Evaluacion { get; set;}
    }
}