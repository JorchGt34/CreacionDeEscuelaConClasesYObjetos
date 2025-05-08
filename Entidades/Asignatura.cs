namespace Etapa1.Entidades
{
    public class Asignatura
    {
        public string? UniqueId { get; set;}
        public string Nombre { get; set ;} = Guid.NewGuid().ToString();
    }
}