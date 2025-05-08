namespace Etapa1.Entidades
{
    public class Evaluaciones
    {
        public string? UniqueId { get; set;}
        public string Nombre { get; set ;} = Guid.NewGuid().ToString();
        public Alumnos? Alumno { get; set; }
        public Asignatura? Asignatura { get; set; }
        public float Nota { get; set; }
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}