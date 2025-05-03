using System;
using System.Runtime.CompilerServices;
using System.Timers;
using static System.Console; //Un espacio de nombre que solo ocupa que escribamos WriteLine
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
            WriteLine(escuela.Nombre);
            WriteLine(escuela.País);
            WriteLine(escuela);
            var escuelaDos = new Escuela("Platzi Academy", 2012, TiposDeEscuela.Preparatoria, ciudad: "Bogotá");//Los parametros opcionales pueden ser omitidos al poner el siguiente parametro seguudo de ":", o al no poner más parametros
            //Si no hay constructor, se pueden agregar valores de la siguiente manera

            //Arreglos
            escuela.Cursos = new Curso[]{
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "202"},
                new Curso(){Nombre = "303"}
            }; //Aqui se registra un arreglo de 3 posiciones que contiene 3 datos de tipo curso
            ImprimirCursosEscuela(escuela);
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("\n===============\n");
            WriteLine("Cursos de la escuela");
            WriteLine("\n===============\n");
            
            if (escuela.Cursos == null || escuela == null)
            {
                return;
            } else {
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