namespace Etapa1.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; set;}
        public string Nombre { get; set ;} 
        public Alumnos Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public double Nota { get; set; }
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}