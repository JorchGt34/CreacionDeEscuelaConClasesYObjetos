using static System.Console; //Un espacio de nombre que solo ocupa que escribamos WriteLine
using CoreEscuela.Entidades;

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

            //Ya una vez que la escuela de engine tiene iniciado los valores, es posible usarlos
            ImprimirCursosEscuela(engine.Escuela);
        }
        //Se crean las funciones con las diferentes formas de uso
        private static void ImprimirCursosEscuela(Escuela escuela) //Se pasa el valor de la variable escuela entera
        {
            WriteLine("\n===============\n");
            WriteLine("Cursos de la escuela");
            WriteLine("\n===============\n");

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