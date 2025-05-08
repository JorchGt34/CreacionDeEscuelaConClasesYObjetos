using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposDeEscuela.Preparatoria, ciudad: "Bogotá");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura(){Nombre = "Matemáticas"},
                    new Asignatura(){Nombre = "Educación Física"},
                    new Asignatura(){Nombre = "Español"},
                    new Asignatura(){Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private IEnumerable<Alumnos> GenerarAlumnosAlAzar(int cantidadAlumnos)
        {
            string[] nombre1 = { "Jorge", "Leonel", "Eduardo", "Adrian", "Carolina" };
            string[] apellido1 = { "Ruiz", "Fragoso", "Andrade", "Naranjo", "Montoya" };
            string[] nombre2 = { "Antonio", "Alan", "Joaquin", "Manuel", "Jesus" };

            //Lenguaje integrado de consultas
            //Esta función embebida de Linq que en esta versión de C# ya viene incluido y se puede usar sin declarar explicitamente la libreria
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumnos { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidadAlumnos);
        }

        private void CargarCursos()
        {

            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "202", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "303", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "502", Jornada = TiposJornada.Tarde}
            };
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                curso.Alumno = GenerarAlumnosAlAzar(cantidadRandom).ToList();
            }
        }
    }
}