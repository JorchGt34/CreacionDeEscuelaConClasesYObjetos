using System;
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
            var curso1 = new Curso() {
                Nombre = "101",
                //UniqueId = "jajajaja" Esto no se puede cuando la propiedad "set" es privada
            };
            var curso2 = new Curso() {
                Nombre = "201"
            };
            var curso3 = new Curso() {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("===========");
            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            Console.WriteLine(curso2.Nombre + "," + curso2.UniqueId);
            Console.WriteLine(curso3);
            }
    }
}