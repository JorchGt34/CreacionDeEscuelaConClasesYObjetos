using System;
using System.Runtime.CompilerServices;
using System.Timers;
using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("uaa", 1980);
            escuela.País = "México";
            escuela.Ciudad = "Aguascalientes";
            escuela.TipoEscuela = TiposDeEscuela.Universidad; //Se usa un valor de tipo enumeración llamado tipos de escuela
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela.País);
            Console.WriteLine(escuela);
            var escuelaDos = new Escuela("Platzi Academy", 2012, TiposDeEscuela.Preparatoria, ciudad: "Bogotá");//Los parametros opcionales pueden ser omitidos al poner el siguiente parametro seguudo de ":", o al no poner más parametros
            //Si no hay constructor, se pueden agregar valores de la siguiente manera

            //Arreglos
            var arregloCursos = new Curso[3]; //Aqui se registra un arreglo de 3 posiciones que contiene 3 datos de tipo curso

            //Aqui se le asigna el valor del curso 1 a la posicion uno del arreglo
            var curso1 = new Curso()
            {
                Nombre = "101",
                //UniqueId = "jajajaja" Esto no se puede cuando la propiedad "set" es privada
            };

            arregloCursos[0] = curso1;
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;
            var curso3 = new Curso()
            {
                Nombre = "301"
            };
            arregloCursos[2] = curso3;

            Console.WriteLine("\n===============\n");
            ImprimirCursosFor(arregloCursos);
            Console.WriteLine("\n===============\n");
            ImprimirCursosWhile(arregloCursos);
            Console.WriteLine("\n===============\n");
            ImprimirCursosDoWhile(arregloCursos);
            Console.WriteLine("\n===============\n");
            ImprimirCursosForEach(arregloCursos);
        }
        //Uso de cilcos para imprimir el arreglo de objetos
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            Console.WriteLine("\nImprimir el arreglo de objetos con un ciclo for->");
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine("El nombre del curso es: " + arregloCursos[i].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[i].UniqueId);
            }
        }
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            Console.WriteLine("\nImprimir el arreglo de objetos con un ciclo While->");
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine("El nombre del curso es: " + arregloCursos[contador].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[contador].UniqueId);
                contador++;
            }
        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            Console.WriteLine("\nImprimir el arreglo con un ciclo Do-While->");
            int contador = 0;
            do
            {
                Console.WriteLine("El nombre del curso es: " + arregloCursos[contador].Nombre + ".\nY el ID unico del curso es: " + arregloCursos[contador].UniqueId);
                contador++;
            } while (contador < arregloCursos.Length);

        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine("El nombre del curso es: " + curso.Nombre + ".\nY el ID unico del curso es: " + curso.UniqueId);
            }
        }
    }
}