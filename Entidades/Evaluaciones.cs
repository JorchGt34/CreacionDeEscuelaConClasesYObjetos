namespace Etapa1.Entidades
{
    public class Evaluaciones: ObjetoEscuelaClase
    {
        public Alumnos Alumno { get; set; }
        public Asignaturas Asignatura { get; set; }
        public double Nota { get; set; }
        public override string ToString()
        {
            return $"Nota: {Nota}, Alumno: {Alumno.Nombre}, Asignatura: {Asignatura.Nombre}";
        }
    }
}