using CoreEscuela.Entidades;
using Etapa1;
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
        //Diccionarios
        //Este metodo crea un diccionario que contiene la escuela y las clases en dos espacios separados dentro de la variable, pero el metodo recibe un objeto escuela que no es compatible con el objeto cursos que le estamos dando, por esta razon se utiliza un cast para poder convertir estos tipos ya que sabemos que si son compatibles por medio de polimorfismo
        public Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaClase>> ObtenerDiccionarioObjetos(){
            
            var dicccionario = new Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaClase>>();
            dicccionario.Add(LlavesDiccionario.Escuela, new[] {Escuela});
            dicccionario.Add(LlavesDiccionario.Cursos, Escuela.Cursos.Cast<ObjetoEscuelaClase>());
            return dicccionario;
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
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            bool traeCursos = true,
            bool traeAsignaturas = true,
            bool traeAlumnos = true,
            bool traeEvaluaciones = true
            )
        {return ObtenerObjetosEscuela(out int dummy, out dummy, out dummy, out dummy);}
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            out int conteoEvaluaciones,
            bool traeCursos = true,
            bool traeAsignaturas = true,
            bool traeAlumnos = true,
            bool traeEvaluaciones = true
            )
        {return ObtenerObjetosEscuela(out conteoEvaluaciones, out int dummy, out dummy, out dummy);}
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoAsignaturas,
            bool traeCursos = true,
            bool traeAsignaturas = true,
            bool traeAlumnos = true,
            bool traeEvaluaciones = true
            )
        {return ObtenerObjetosEscuela(out conteoEvaluaciones, out conteoAsignaturas, out int dummy, out dummy);}
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoAsignaturas,
            out int conteoCursos,
            bool traeCursos = true,
            bool traeAsignaturas = true,
            bool traeAlumnos = true,
            bool traeEvaluaciones = true
            )
        {return ObtenerObjetosEscuela(out conteoEvaluaciones, out conteoAsignaturas, out conteoCursos, out int dummy);}
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoAsignaturas,
            out int conteoCursos,
            out int conteoAlumnos
            )
        {return ObtenerObjetosEscuela(out conteoEvaluaciones, out conteoAsignaturas, out conteoCursos, out conteoAlumnos);}
        public IReadOnlyList<ObjetoEscuelaClase> ObtenerObjetosEscuela(
            out int conteoCursos,
            out int conteoAsignaturas,
            out int conteoAlumnos,
            out int conteoEvaluaciones,
            bool traeCursos = true,
            bool traeAsignaturas = true,
            bool traeAlumnos = true,
            bool traeEvaluaciones = true
            )
        {
            conteoCursos = conteoAsignaturas = conteoAlumnos = conteoEvaluaciones = 0;

            var listaObj = new List<ObjetoEscuelaClase>();
            //"Add" agrega un objeto, y "AddRange" agrega una lista de objetos
            listaObj.AddRange(Escuela);

            if(traeCursos){
                listaObj.AddRange(Escuela.Cursos);
                conteoCursos += Escuela.Cursos.Count;
                foreach (var curso in Escuela.Cursos)
                {
                    if(traeAsignaturas){
                        listaObj.AddRange(curso.Asignaturas);
                        conteoAsignaturas += curso.Asignaturas.Count;
                    }
                    if(traeAlumnos){
                        listaObj.AddRange(curso.Alumno);
                        conteoAlumnos += curso.Alumno.Count;
                    }
                    if(traeEvaluaciones){
                        foreach (var alumno in curso.Alumno)
                        {
                            listaObj.AddRange(alumno.Evaluacion);
                            conteoEvaluaciones += alumno.Evaluacion.Count;
                        }
                    }
                }
            }
            return listaObj.AsReadOnly();
        }
        #region Metodos de carga
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
        #endregion
    }
}