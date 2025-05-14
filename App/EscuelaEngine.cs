using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuelas? Escuela { get; set; }

        public void Inicializar()
        {
            Escuela = new Escuelas("Platzi Academy", 2012, TiposDeEscuelas.Preparatoria, ciudad: "Bogotá");

            CargarCursos();
            CargarAsignaturas();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignaturas> listaAsignaturas = new List<Asignaturas>(){
                    new Asignaturas(){Nombre = "Matemáticas"},
                    new Asignaturas(){Nombre = "Educación Física"},
                    new Asignaturas(){Nombre = "Español"},
                    new Asignaturas(){Nombre = "Ciencias Naturales"}
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

            Escuela.Cursos = new List<Cursos>(){
                new Cursos(){Nombre = "101", Jornada = TiposJornadas.Mañana},
                new Cursos(){Nombre = "202", Jornada = TiposJornadas.Mañana},
                new Cursos(){Nombre = "303", Jornada = TiposJornadas.Mañana},
                new Cursos(){Nombre = "401", Jornada = TiposJornadas.Tarde},
                new Cursos(){Nombre = "501", Jornada = TiposJornadas.Tarde},
                new Cursos(){Nombre = "502", Jornada = TiposJornadas.Tarde}
            };
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                curso.Alumno = GenerarAlumnosAlAzar(cantidadRandom).ToList();

                double min = 0.0;
                double max = 5.0;

                foreach (var Alum in curso.Alumno)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        double cantidadDoubleRandom = min + (rnd.NextDouble() * (max - min));
                        //Tambien funciona:
                        //double cantidadDoubleRandom = 5 * rnd.NextDouble() 
                        //Funciona ya que el minimo siempre sera 0
                        var evaluacion = new Evaluaciones()
                        {
                            Nombre = $"Nueva evaluación #{i} del 2025",
                            Alumno = Alum,
                            Asignatura = new Asignaturas()
                            {
                                Nombre = curso.Nombre.ToString()
                            },
                            Nota = cantidadDoubleRandom
                        };
                        Alum.Evaluacion.Add(evaluacion);
                    }
                }
            }
        }
    }
}