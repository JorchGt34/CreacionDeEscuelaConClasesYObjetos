using Etapa1;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Cursos: ObjetoEscuelaClase
    {
        public TiposJornadas Jornada { get; set; }
        public List<Asignaturas> Asignaturas { get; set; }
        public List<Alumnos> Alumno { get; set; }
        }
}