using static System.Console; //Un espacio de nombre que solo ocupa que escribamos WriteLine
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using Etapa1;
using Etapa1.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toda la logica del programa se pasa a EscuelaEngine para una mejor organización, ahora se crea un nuevo objeto de EscuelaEngine para poder seguir usando las propiedades en este archivo
            var engine = new EscuelaEngine();

            //Usamos el metodo de inicializar para asignar los valores
            engine.Inicializar();

            //Hacemos una clase que funciona como objeto por si misma para imprimir lineas segun la longitud que eligamos, por defecto lleva 10 de longitud
            Printer.DibujarLinea();

            //También se le puede asignar un tamaño diferente
            Printer.DibujarLinea(20);

            //Ya una vez que la escuela de engine tiene iniciado los valores, es posible usarlos
            ImprimirCursosEscuela(engine.Escuela);

            //var listaDeObj = engine.ObtenerObjetosEscuela(traeEvaluaciones: false);
            var listaDeObj = engine.ObtenerObjetosEscuela(
            out int conteoCursos,
            out int conteoAsignaturas,
            out int conteoAlumnos,
            out int conteoEvaluaciones
            );
            WriteLine("Pausa");

            
        }
        //Se crean las funciones con las diferentes formas de uso
        private static void ImprimirCursosEscuela(Escuelas escuela) //Se pasa el valor de la variable escuela entera
        {
            WriteLine("\n");
            Printer.DibujarTitulo("Bienvenidos a la escuela");
            WriteLine("\n");
            Printer.DibujarTitulo("Cursos de la escuela");

            if (escuela.Cursos == null || escuela == null)
            {
                return;
            }
            else
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre del curso: {curso.Nombre}, con un ID {curso.UniqueId}");
                }
            }
        }
    }
}