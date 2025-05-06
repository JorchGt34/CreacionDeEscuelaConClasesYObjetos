using static System.Console; //Un espacio de nombre que solo ocupa que escribamos WriteLine
using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de la escuela
            var escuela = new Escuela("uaa", 1980);
            escuela.País = "México";
            escuela.Ciudad = "Aguascalientes";
            escuela.TipoEscuela = TiposDeEscuela.Universidad; //Se usa un valor de tipo enumeración llamado tipos de escuela

            //Se imprimen los valores de la escuela
            WriteLine(escuela.Nombre);
            WriteLine(escuela.País);
            WriteLine(escuela);

            //Se crea un segundo objeto de escuela
            var escuelaDos = new Escuela("Platzi Academy", 2012, TiposDeEscuela.Preparatoria, ciudad: "Bogotá");//Los parametros opcionales pueden ser omitidos al poner el siguiente parametro seguudo de ":", o al no poner más parametros
            //Si no hay constructor, se pueden agregar valores de la siguiente manera

            //Uso de colecciones 
            //System.Collections se usa para hacer colecciones

            //La siguiente coleccion es generica y permite la eliminacion de espacios dentro de la coleccion, ó agregar espacios a la colección
            escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "202", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "303", Jornada = TiposJornada.Mañana}                
            };

            //A las colecciones se le pueden agregar más elementos
            escuela.Cursos.Add( new Curso(){ Nombre = "102", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add( new Curso(){ Nombre = "202", Jornada = TiposJornada.Tarde});

            //Aparte de agregar más lementos individuales, se pueden agregar más listas
            var otraColeccion = new List<Curso>(){
                new Curso(){Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "502", Jornada = TiposJornada.Tarde} 
            };

            escuela.Cursos.AddRange(otraColeccion);

            //Es posible eliminar elementos de una colección o eliminar todos los elementos de una colección, donde el metodo Clear() elimina todos los elementos
            otraColeccion.Clear();

            //Con remove se selecciona un elemento en especifico para removerlo
            escuela.Cursos.Remove();

            //Se llama a la función que imprime los valores de la escuela
            ImprimirCursosEscuela(escuela);
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
        //Uso de cilcos para imprimir el arreglo de objetos
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            WriteLine("\nImprimir el arreglo de objetos con un ciclo for->");
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine("El nombre del curso es: " + arregloCursos[i].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[i].UniqueId);
            }
        }
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            WriteLine("\nImprimir el arreglo de objetos con un ciclo While->");
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine("El nombre del curso es: " + arregloCursos[contador].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[contador].UniqueId);
                contador++;
            }
        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            WriteLine("\nImprimir el arreglo con un ciclo Do-While->");
            int contador = 0;
            do
            {
                WriteLine("El nombre del curso es: " + arregloCursos[contador].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[contador].UniqueId);
                contador++;
            } while (contador < arregloCursos.Length);

        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine("El nombre del curso es: " + curso.Nombre + ".\nY el ID unico del curso es: " + curso.UniqueId);
            }
        }
    }
}