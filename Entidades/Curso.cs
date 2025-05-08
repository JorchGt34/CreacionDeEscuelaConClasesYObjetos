using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumnos> Alumno { get; set; }
        public Curso()
        {
            //Esto crea un Id aleatorio pero unico
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}