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

            // Aunque Objetovar obj = new ObjetoEscuelaClase();
            Printer.DibujarLinea(20);
            Printer.DibujarTitulo("Pruebas de Polimorfimo");
            Printer.DibujarLinea(20);
            var alumnoTest = new Alumnos(){
                Nombre = "Cicops"
            };

            //Como alumnoTest es heredado de ObjetoEscuelaClase es posible hacer la siguiente asignación
            ObjetoEscuelaClase ob = alumnoTest;
            Printer.DibujarTitulo("Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine(alumnoTest.UniqueId);
            WriteLine(alumnoTest.GetType);

            var objDummy = new ObjetoEscuelaClase(){
                Nombre = "Frank Underwood"
            };

            Printer.DibujarTitulo("Dummy");
            WriteLine($"Alumno: {objDummy.Nombre}");
            WriteLine(objDummy.UniqueId);
            WriteLine(objDummy.GetType);

            //Esto no es posible ya que el padre que hereda no puede ser asignado a un hijo, pero un objeto creado desde el padre se le puede asignar un hijo
            //alumnoTest = objDummy;
            //Si se intenta asignar un objeto padre como hijo:
            //alumnoTest = (Alumnos)objDummy
            //Avanzara en el compilador, pero en ejecución aparecerá un error

            var evaluación = new Evaluaciones(){
                Nombre = "Evaluación de Math",
                Nota = 4.5f
            };
            
            Printer.DibujarTitulo("Evaluación");
            WriteLine($"Evaluación: {evaluación.Nombre}");
            WriteLine($"Nota: {evaluación.Nota}");
            WriteLine(evaluación.UniqueId);
            WriteLine(evaluación.GetType);

            //Al ser el mismo objeto es polimorfismo, por esta razón contienen el mismo ID unico
            Printer.DibujarTitulo("Objeto Escuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine(ob.UniqueId);
            WriteLine(ob.GetType);


            ob = evaluación;
            Printer.DibujarTitulo("Objeto Escuela con evaluación");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine(ob.UniqueId);
            WriteLine(ob.GetType);

            //A pesar de que un objeto padre puede contener un hijo alumno y un hijo evaluación, un objeto alumno no puede tener asignado una evaluación y viceversa.
            //alumnoTest = evaluación;
            //Aunque se haga la conversión, una vez el programa sea ejecutado, un problema surgia
            //alumnoTest = (Alumnos)evaluación;

            //En si el polimorfismo permite que padres obtengan información de sus hijos
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