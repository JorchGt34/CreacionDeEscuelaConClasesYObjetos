using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("uaa", 1980);
            escuela.País = "México";
            escuela.Ciudad = "Aguascalientes";
            Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela.País);
        }
    }
}